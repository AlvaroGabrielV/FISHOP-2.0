using Atividade_GestaodeProdutos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace FISHOP
{
    public static class CarrinhoService
    {
        /// <summary>
        /// Retorna lista de itens do carrinho para um usuário específico.
        /// </summary>
        public static List<Item> ObterProdutos(int usuarioId)
        {
            var lista = new List<Item>();
            var conexaoBD = new ConexaoBD();

            using (var conn = conexaoBD.Conectar())
            {
                string sql = @"
                    SELECT produto_id, titulo, preco, loja, estrelas, imagem_url, quantidade
                    FROM carrinho
                    WHERE usuario_id = @usuario_id;
                ";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", usuarioId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new Item
                            {
                                Title = reader.GetString("titulo"),
                                Price = reader.GetString("preco"),
                                Source = reader.IsDBNull(reader.GetOrdinal("loja")) ? "" : reader.GetString("loja"),
                                Rating = reader.IsDBNull(reader.GetOrdinal("estrelas")) ? 0 : reader.GetFloat("estrelas"),
                                ImageUrl = reader.IsDBNull(reader.GetOrdinal("imagem_url")) ? "" : reader.GetString("imagem_url"),
                                Position = reader.GetInt32("produto_id"),
                                Quantidade = reader.GetInt32("quantidade")
                            };

                            // Força cálculo de ValorNumerico (getter faz parse se necessário)
                            decimal _ = item.ValorNumerico;

                            lista.Add(item);
                        }
                    }
                }
            }

            return lista;
        }

        /// <summary>
        /// Adiciona um produto ao carrinho. Se já existir, incrementa a quantidade.
        /// </summary>
        public static void AdicionarProduto(int usuarioId, Item item)
        {
            var conexaoBD = new ConexaoBD();

            using (var conn = conexaoBD.Conectar())
            {
                // 1) Verifica se produto já existe no carrinho
                string sqlCheck = @"
                    SELECT quantidade 
                    FROM carrinho 
                    WHERE usuario_id = @usuario_id 
                      AND produto_id = @produto_id;
                ";
                using (var cmdCheck = new MySqlCommand(sqlCheck, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@usuario_id", usuarioId);
                    cmdCheck.Parameters.AddWithValue("@produto_id", item.Position);

                    object result = cmdCheck.ExecuteScalar();
                    if (result != null)
                    {
                        // Já está no carrinho: só incrementa
                        int quantidadeAtual = Convert.ToInt32(result);
                        int novaQuantidade = quantidadeAtual + 1;

                        string sqlUpdate = @"
                            UPDATE carrinho
                            SET quantidade = @quantidade
                            WHERE usuario_id = @usuario_id
                              AND produto_id = @produto_id;
                        ";
                        using (var cmdUpdate = new MySqlCommand(sqlUpdate, conn))
                        {
                            cmdUpdate.Parameters.AddWithValue("@quantidade", novaQuantidade);
                            cmdUpdate.Parameters.AddWithValue("@usuario_id", usuarioId);
                            cmdUpdate.Parameters.AddWithValue("@produto_id", item.Position);
                            cmdUpdate.ExecuteNonQuery();
                        }
                        return;
                    }
                }

                // 2) Se não existe, insere novo registro
                string sqlInsert = @"
                    INSERT INTO carrinho
                        (usuario_id, produto_id, titulo, preco, loja, estrelas, imagem_url, quantidade)
                    VALUES
                        (@usuario_id, @produto_id, @titulo, @preco, @loja, @estrelas, @imagem_url, @quantidade);
                ";
                using (var cmdInsert = new MySqlCommand(sqlInsert, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@usuario_id", usuarioId);
                    cmdInsert.Parameters.AddWithValue("@produto_id", item.Position);
                    cmdInsert.Parameters.AddWithValue("@titulo", item.Title);
                    cmdInsert.Parameters.AddWithValue("@preco", item.Price);
                    cmdInsert.Parameters.AddWithValue("@loja", item.Source);
                    cmdInsert.Parameters.AddWithValue("@estrelas", item.Rating);
                    cmdInsert.Parameters.AddWithValue("@imagem_url", item.ImageUrl);
                    cmdInsert.Parameters.AddWithValue("@quantidade", 1);
                    cmdInsert.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Remove completamente um produto do carrinho do usuário.
        /// </summary>
        public static void RemoverProduto(int usuarioId, int produtoId)
        {
            var conexaoBD = new ConexaoBD();

            using (var conn = conexaoBD.Conectar())
            {
                string sql = @"
                    DELETE FROM carrinho
                    WHERE usuario_id = @usuario_id
                      AND produto_id = @produto_id;
                ";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", usuarioId);
                    cmd.Parameters.AddWithValue("@produto_id", produtoId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Atualiza a quantidade de um item no carrinho. Se quantidade <= 0, remove o item.
        /// </summary>
        public static void AtualizarQuantidade(int usuarioId, int produtoId, int novaQuantidade)
        {
            var conexaoBD = new ConexaoBD();

            using (var conn = conexaoBD.Conectar())
            {
                if (novaQuantidade <= 0)
                {
                    // Remove o item
                    RemoverProduto(usuarioId, produtoId);
                    return;
                }

                string sql = @"
                    UPDATE carrinho
                    SET quantidade = @quantidade
                    WHERE usuario_id = @usuario_id
                      AND produto_id = @produto_id;
                ";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@quantidade", novaQuantidade);
                    cmd.Parameters.AddWithValue("@usuario_id", usuarioId);
                    cmd.Parameters.AddWithValue("@produto_id", produtoId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Limpa todo o carrinho para esse usuário.
        /// </summary>
        public static void LimparCarrinho(int usuarioId)
        {
            var conexaoBD = new ConexaoBD();

            using (var conn = conexaoBD.Conectar())
            {
                string sql = @"
                    DELETE FROM carrinho
                    WHERE usuario_id = @usuario_id;
                ";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", usuarioId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
