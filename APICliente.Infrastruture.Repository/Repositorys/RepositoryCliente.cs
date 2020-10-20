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
    public class RepositoryCliente : IRepositoryCliente
    {
        IConfiguration _configuration;

        public RepositoryCliente(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string ObterConexao()
        {
            var conexao = _configuration.GetSection("ConnectionString").GetSection("ClienteConexao").Value;
            return conexao;
        }

        public void Adicionar(Cliente cliente)
        {
            var stringConexao = this.ObterConexao();
            using (var con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    var consulta = "INSERT INTO Clientes(Nome, CPF, DataNascimento)VALUES(@Nome, @CPF, @DataNascimento, Idade = @Idade);SELECT CAST(SCOPE_IDENTITY() as INT);";
                    con.Execute(consulta, cliente);
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

        public void Atualizar(Cliente cliente)
        {
            var stringConexao = this.ObterConexao();
            using (var con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    var consulta = "UPDATE Clientes SET Nome = @Nome, CPF = @CPF, DataNascimento = @DataNascimento, Idade = @Idade WHERE ClienteId = " + cliente.ClienteId;
                    con.Execute(consulta, cliente);
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

        public void Excluir(int id)
        {
            var stringConexao = this.ObterConexao();

            using (var con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    var consulta = "DELETE FROM Clientes WHERE ClienteId = " + id;
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

        public Cliente ObterPorId(int id)
        {
            var stringConexao = this.ObterConexao();
            Cliente cliente = new Cliente();

            using (var con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    var consulta = "SELECT * FROM Clientes WHERE ClienteId = " + id;
                    cliente = con.Query<Cliente>(consulta).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return cliente;
            }
        }
        public IEnumerable<Cliente> ObterTodos()
        {
            var stringConexao = this.ObterConexao();
            List<Cliente> clientes = new List<Cliente>();

            using (var con = new SqlConnection(stringConexao))
            {
                try
                {
                    con.Open();
                    var consulta = "SELECT * FROM Clientes";
                    clientes = con.Query<Cliente>(consulta).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return clientes;
            }
        }
    }

}

