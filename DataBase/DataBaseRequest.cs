using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TechConnect
{
    public class DataBaseRequest
    {
        private const string connectionString = "Password=sequor;Persist Security Info=True;User ID=sequor;Initial Catalog=dbTechDeveloper;Data Source=SQO-111\\MSSQL16";

        public static List<UserDTO> GetUser(string matricula)
        {
            List<UserDTO> result = new List<UserDTO>();
            List<UserPersistence> userList = new List<UserPersistence>();

            string query = QueryGetUser();
            query += $@"Where Usr.[Matricula] = {matricula}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserPersistence persistence = new UserPersistence()
                                {
                                    Id = (int)reader["Id"],
                                    Matricula = (string)reader["Matricula"],
                                    Nome = (string)reader["Nome"],
                                    Senha = (string)reader["Senha"],
                                    Celular = (string)reader["Celular"],
                                    Photo = (byte[])reader["Photo"],
                                    DataNascimento = (DateTime)reader["DataNascimento"],
                                    Email = (string)reader["Email"],
                                    IdTipo = (int)reader["IdTipo"],
                                    Tipo = (string)reader["Tipo"],
                                    IdGenero = (int)reader["IdGenero"],
                                    CodigoGenero = (string)reader["CodigoGenero"],
                                    Genero = (string)reader["Genero"],
                                    IdSituacao = (int)reader["IdSituacao"],
                                    Situacao = (string)reader["Situacao"],
                                    IdEndereco = (string)reader["IdEndereco"],
                                    CEP = (string)reader["CEP"],
                                    SiglaEstado = (string)reader["SiglaEstado"],
                                    Estado = (string)reader["Estado"],
                                    Cidade = (string)reader["Cidade"],
                                    Bairro = (string)reader["Bairro"],
                                    Rua = (string)reader["Rua"],
                                    NumCasa = (int)reader["NumCasa"],
                                    DataRemocao = (DateTime)reader["DataRemocao"]
                                };

                                userList.Add(persistence);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }

            foreach (var user in userList)
            {
                result.Add(new UserDTO()
                {
                    User = user.Matricula,
                    Name = user.Nome,
                    Password = user.Senha,
                    Email = user.Email,
                    CEP = user.CEP,
                    AddressMoreInfo = $"{user.Rua}, {user.Bairro} - {user.Cidade}/{user.SiglaEstado}",
                    HouseNumber = user.NumCasa,
                    PhoneNumber = user.Celular,
                    Photo = user.Photo,
                    Type = (UserDTO.USER_TYPE)user.IdTipo,
                    Sexuality = (UserDTO.SEXUALITY_TYPE)user.IdGenero,
                    Enable = user.DataRemocao != null && user.DataRemocao > DateTime.MinValue,
                });
            }

            return result;
        }

        public static List<UserDTO> GetAllUser()
        {
            List<UserDTO> result = new List<UserDTO>();
            List<UserPersistence> userList = new List<UserPersistence>();

            string query = QueryGetUser();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserPersistence persistence = new UserPersistence()
                                {
                                    Id = (int)reader["Id"],
                                    Matricula = (string)reader["Matricula"],
                                    Nome = (string)reader["Nome"],
                                    Senha = (string)reader["Senha"],
                                    Celular = (string)reader["Celular"],
                                    Photo = (byte[])reader["Photo"],
                                    DataNascimento = (DateTime)reader["DataNascimento"],
                                    Email = (string)reader["Email"],
                                    IdTipo = (int)reader["IdTipo"],
                                    Tipo = (string)reader["Tipo"],
                                    IdGenero = (int)reader["IdGenero"],
                                    CodigoGenero = (string)reader["CodigoGenero"],
                                    Genero = (string)reader["Genero"],
                                    IdSituacao = (int)reader["IdSituacao"],
                                    Situacao = (string)reader["Situacao"],
                                    IdEndereco = (string)reader["IdEndereco"],
                                    CEP = (string)reader["CEP"],
                                    SiglaEstado = (string)reader["SiglaEstado"],
                                    Estado = (string)reader["Estado"],
                                    Cidade = (string)reader["Cidade"],
                                    Bairro = (string)reader["Bairro"],
                                    Rua = (string)reader["Rua"],
                                    NumCasa = (int)reader["NumCasa"],
                                    DataRemocao = (DateTime)reader["DataRemocao"]
                                };

                                userList.Add(persistence);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }

            foreach (var user in userList)
            {
                result.Add(new UserDTO()
                {
                    User = user.Matricula,
                    Name = user.Nome,
                    Password = user.Senha,
                    Email = user.Email,
                    CEP = user.CEP,
                    AddressMoreInfo = $"{user.Rua}, {user.Bairro} - {user.Cidade}/{user.SiglaEstado}",
                    HouseNumber = user.NumCasa,
                    PhoneNumber = user.Celular,
                    Photo = user.Photo,
                    Type = (UserDTO.USER_TYPE)user.IdTipo,
                    Sexuality = (UserDTO.SEXUALITY_TYPE)user.IdGenero,
                    Enable = user.DataRemocao != null && user.DataRemocao > DateTime.MinValue,
                });
            }

            return result;
        }

        private static string QueryGetUser()
        {
            return @"Select
						Usr.[Id]
						,Usr.[Matricula]
						,Usr.[Nome]
						,Usr.[Senha]
						,Usr.[Celular]
	                    ,Usr.[Photo]
						,Usr.[DataNascimento]
						,Usr.[Email]
						,Tipo.[Id] as IdTipo
						,Tipo.[Descricao] as Tipo
						,Genero.[Id] as IdGenero
						,Genero.[Codigo] as CodigoGenero
						,Genero.[Descricao] as Genero
						,Situacao.[Id] as IdSituacao
						,Situacao.[Descricao] as Situacao
						,Endereco.[Id] as IdEndereco
						,Endereco.[CEP]
						,Endereco.[SiglaEstado]
						,Endereco.[Estado]
						,Endereco.[Cidade]
						,Endereco.[Bairro]
						,Endereco.[Rua]
						,Endereco.[NumCasa]
						,Usr.[DataRemocao]
					From
						[dbo].[Usuario] Usr With(nolock)
					Inner Join
						[dbo].[UsuarioTipo] Tipo With(nolock)
					On
						Tipo.[Id] = Usr.[IdTipo]
					Inner Join
						[dbo].[UsuarioGenero] Genero With(nolock)
					On
						Genero.[Id] = Usr.[IdGenero]
					Inner Join
						[dbo].[UsuarioSituacao] Situacao With(nolock)
					On
						Situacao.[Id] = Usr.IdSituacao
					Left Join
						[dbo].[UsuarioEndereco] Endereco With(nolock)
					On
						Endereco.[Id] = Usr.[IdEndereco]
						And Endereco.DataRemocao is Null";
        }
    }
}
