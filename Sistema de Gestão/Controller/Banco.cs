﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Sistema_de_Gestão.Controller
{

    class Banco
    {
        //conexao com o banco
        private static SQLiteConnection conexao;

    
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source ="+Globais.caminhoBanco+ Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }
        // fim da conexao com banco

        //Conecoes genericas
        public static DataTable dql (string sql) 
        // DATA QUERY LANGUEGE - consulta
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string q, string msgOK= null, string msgErro=null) 
        // DATA manipulation LANGUEGE - insert, delet, update
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if(msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if(msgErro != null)
                {
                    MessageBox.Show(msgErro + "\n" + ex.Message);
                }
                throw ex;
            }

        }


        public static void NovaPessoa(Model.Pessoa pessoa)
        {
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_pessoas (t_nome, t_sobrenome, t_sexo, t_email, t_cpf, t_categoria, t_salariob, t_cep, t_endereco, t_num, t_bairro, t_cidade, t_uf, t_pais, b_filhos, t_foto ) VALUES (@nome, @sobrenome, @sexo, @email, @cpf, @categoria, @salariobase, @cep, @endereco, @numero, @bairro, @cidade, @uf, @pais, @filho, @foto)";
                cmd.Parameters.AddWithValue("@nome", pessoa.t_nome);
                cmd.Parameters.AddWithValue("@sobrenome", pessoa.t_sobrenome);
                cmd.Parameters.AddWithValue("@sexo", pessoa.t_sexo);
                cmd.Parameters.AddWithValue("@cpf", pessoa.t_cpf);
                cmd.Parameters.AddWithValue("@email", pessoa.t_email);
                cmd.Parameters.AddWithValue("@categoria", pessoa.t_categoria);
                cmd.Parameters.AddWithValue("@salariobase", pessoa.t_salariob);
                cmd.Parameters.AddWithValue("@cep", pessoa.t_cep);
                cmd.Parameters.AddWithValue("@endereco", pessoa.t_endereco);
                cmd.Parameters.AddWithValue("@numero", pessoa.t_numero);
                cmd.Parameters.AddWithValue("@bairro", pessoa.t_bairro);
                cmd.Parameters.AddWithValue("@cidade", pessoa.t_cidade);
                cmd.Parameters.AddWithValue("uf", pessoa.t_uf);
                cmd.Parameters.AddWithValue("@pais", pessoa.t_pais);
                cmd.Parameters.AddWithValue("@filho", pessoa.b_filhos);
                cmd.Parameters.AddWithValue("@foto", pessoa.t_foto);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario cadastrado com sucesso!");
                ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar os dados");
                ConexaoBanco().Close();
            }
        }
        public static void BuscarPaiComFilhos(Model.Filhos filhos)
        {
            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT * FROM tb_pessoas WHERE b_filhos = 1 ";
;
        }
        //Funcões do form Gestão de Pessoas

        public static DataTable ObterPessoasIdNomeCategoria()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT n_id_pessoa as 'Código', t_nome as 'NOME', t_categoria as 'CATEGORIA' FROM tb_pessoas";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosPessoas(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_pessoas WHERE n_id_pessoa="+ id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterFilhosPessoas(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_filhos WHERE t_pai =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable ExcluirPessoas(string idSelecionado)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_pessoas WHERE n_id_pessoa =" ;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Funcoes da classe de calccular salario
        public static DataTable ObterPessoasIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT n_id_pessoa as 'Código', t_nome as 'NOME' FROM tb_pessoas";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
