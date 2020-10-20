using APICliente.Domain.Core.Interfaces.Repositorys;
using APICliente.Domain.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace APICliente.Infrastruture.Repository.Repositorys
{
    public class RepositoryEndereco : IRepositoryEndereco
    {
        IConfiguration _configuration;

        public RepositoryEndereco(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string ObterConexao()
        {
            var conexao = _configuration.GetSection("ConnectionString").GetSection("ClienteConexao").Value;
            return conexao;
        }

        public void Adicionar(Endereco endereco)
        {
            var stringConexao = this.ObterConexao();            
            using (var con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    var consulta = "INSERT INTO Enderecos(Logradouro, Bairro, Cidade, Estado, CodCliente)VALUES(@Logradouro, @Bairro, @Cidade, @Estado, @CodCliente);SELECT CAST(SCOPE_IDENTITY() as INT);";
                    con.Execute(consulta, endereco);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }                
            }
        }

        public void Atualizar(Endereco endereco)
        {
            var stringConexao = this.ObterConexao();            
            using (var con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    var consulta = "UPDATE Enderecos SET Logradouro = @Logradouro, Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado, CodCliente = @CodCliente WHERE EnderecoId = " + endereco.EnderecoId;
                    con.Execute(consulta, endereco);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }               
            }
        }

        public void Excluir(Endereco endereco)
        {
            var stringConexao = this.ObterConexao();            

            using (var con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    var consulta = "DELETE FROM Enderecos WHERE EnderecoId = " + endereco;
                    con.Execute(consulta);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }                
            }
        }
        public Endereco ObterPorId(int id)
        {
            var stringConexao = this.ObterConexao();
            Endereco endereco = new Endereco();

            using (var con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    var consulta = "SELECT * FROM Enderecos WHERE EnderecoId = " + id;
                    endereco = con.Query<Endereco>(consulta).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return endereco;
            }
        }
        public IEnumerable<Endereco> ObterTodos()
        {
            var stringConexao = this.ObterConexao();
            List<Endereco> enderecos = new List<Endereco>();

            using (var con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    var consulta = "SELECT * FROM Enderecos";
                    enderecos = con.Query<Endereco>(consulta).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return enderecos;
            }
        }
    }
}

