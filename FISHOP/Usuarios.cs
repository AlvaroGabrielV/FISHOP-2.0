using Atividade_GestaodeProdutos;
using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace FISHOP
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        // Neste projeto, a coluna no banco chama-se “usuario”
        public string UsuarioLogin { get; set; }

        // A coluna no banco chama-se apenas “senha”
        public string Senha { get; set; }

        public static Usuarios ObterPorLoginOuEmail(string loginOuEmail)
        {
            using (var conn = new ConexaoBD().Conectar())
            {
                string sql = @"
                    SELECT id, nome, cpf, email, usuario, senha
                    FROM usuarios
                    WHERE usuario = @loginOuEmail
                       OR email = @loginOuEmail
                    LIMIT 1;
                ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@loginOuEmail", loginOuEmail);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        return new Usuarios
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Cpf = reader.GetString("cpf"),
                            Email = reader.GetString("email"),
                            UsuarioLogin = reader.GetString("usuario"),
                            Senha = reader.GetString("senha")
                        };
                    }
                }
            }
        }

        public bool VerificarSenha(string senhaDigitada)
        {
            if (string.IsNullOrEmpty(Senha))
                return false;

            string hashDigitado = GerarSha256(senhaDigitada);
            return hashDigitado == Senha;
        }

        public bool RedefinirSenha(string novaSenha)
        {
            
            string novoHash = GerarSha256(novaSenha);

            using (var conn = new ConexaoBD().Conectar())
            {
                string sql = @"
                    UPDATE usuarios
                    SET senha = @novoHash
                    WHERE id = @id;
                ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@novoHash", novoHash);
                    cmd.Parameters.AddWithValue("@id", Id);

                    int afetados = cmd.ExecuteNonQuery();
                    if (afetados > 0)
                    {
                        Senha = novoHash;
                        return true;
                    }
                    return false;
                }
            }
        }

        public static string GerarSha256(string text)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                var sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public bool ValidarCPF(string cpf)
        {
            if (string.IsNullOrEmpty(cpf)) return false;

            cpf = Regex.Replace(cpf, "[^0-9]", "");

            if (cpf.Length != 11) return false;
            if (new string(cpf[0], 11) == cpf) return false;

            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            resto = (resto < 2) ? 0 : 11 - resto;

            string digito = resto.ToString();
            tempCpf += digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            resto = (resto < 2) ? 0 : 11 - resto;
            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}
