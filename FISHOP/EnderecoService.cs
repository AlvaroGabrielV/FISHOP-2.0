using Atividade_GestaodeProdutos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISHOP
{
    public static class EnderecoService
    {

        public static List<Endereco> ObterEnderecos(int usuarioId)
        {
            var lista = new List<Endereco>();
            using (var conn = new ConexaoBD().Conectar())
            {
                string sql = @"
                    SELECT id, rua, numero, bairro, cidade
                    FROM enderecos
                    WHERE usuario_id = @usuario_id;
                ";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", usuarioId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Endereco
                            {
                                Id = reader.GetInt32("id"),
                                UsuarioId = usuarioId,
                                Rua = reader.GetString("rua"),
                                Numero = reader.GetString("numero"),
                                Bairro = reader.GetString("bairro"),
                                Cidade = reader.GetString("cidade")
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public static bool AdicionarEndereco(Endereco e)
        {
            using (var conn = new ConexaoBD().Conectar())
            {
                string sql = @"
                    INSERT INTO enderecos 
                        (usuario_id, rua, numero, bairro, cidade)
                    VALUES 
                        (@usuario_id, @rua, @numero, @bairro, @cidade);
                ";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", e.UsuarioId);
                    cmd.Parameters.AddWithValue("@rua", e.Rua);
                    cmd.Parameters.AddWithValue("@numero", e.Numero);
                    cmd.Parameters.AddWithValue("@bairro", e.Bairro);
                    cmd.Parameters.AddWithValue("@cidade", e.Cidade);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool RemoverEndereco(int enderecoId, int usuarioId)
        {
            using (var conn = new ConexaoBD().Conectar())
            {
                string sql = @"
                    DELETE FROM enderecos
                    WHERE id = @id AND usuario_id = @usuario_id;
                ";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", enderecoId);
                    cmd.Parameters.AddWithValue("@usuario_id", usuarioId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
