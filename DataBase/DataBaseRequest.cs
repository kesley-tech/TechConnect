﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using static DevExpress.CodeParser.CodeStyle.Formatting.Rules;

namespace TechConnect
{
    public class DataBaseRequest
    {
        public DataBaseRequest() 
        { 
        }

        private const string connectionString = "Password=sequor;Persist Security Info=True;User ID=sequor;Initial Catalog=dbTechDeveloper;Data Source=SQO-111\\MSSQL16";

        #region User
        public static List<UserDTO> GetUser(string matricula)
        {
            List<UserDTO> result = new List<UserDTO>();
            List<UserPersistence> userList = new List<UserPersistence>();

            string query = QueryGetUser();
            query += $@" Where Usr.[Matricula] = {matricula}";

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
                                    Matricula = (int)reader["Matricula"],
                                    Nome = reader["Nome"] is DBNull ? null : (string)reader["Nome"],
                                    Senha = reader["Senha"] is DBNull ? null : (string)reader["Senha"],
                                    Celular = reader["Celular"] is DBNull ? null : (string)reader["Celular"],
                                    Photo = reader["Photo"] is DBNull ? null : (byte[])reader["Photo"],
                                    DataNascimento = (DateTime)reader["DataNascimento"],
                                    Email = reader["Email"] is DBNull ? null : (string)reader["Email"],
                                    IdTipo = (int)reader["IdTipo"],
                                    Tipo = reader["Tipo"] is DBNull ? null : (string)reader["Tipo"],
                                    IdGenero = (int)reader["IdGenero"],
                                    CodigoGenero = reader["CodigoGenero"] is DBNull ? null : (string)reader["CodigoGenero"],
                                    Genero = reader["Genero"] is DBNull ? null : (string)reader["Genero"],
                                    IdSituacao = (int)reader["IdSituacao"],
                                    Situacao = reader["Situacao"] is DBNull ? null : (string)reader["Situacao"],
                                    IdEndereco = reader["IdEndereco"] is DBNull ? null : (int?)reader["IdEndereco"],
                                    CEP = reader["CEP"] is DBNull ? null : (string)reader["CEP"],
                                    SiglaEstado = reader["SiglaEstado"] is DBNull ? null : (string)reader["SiglaEstado"],
                                    Estado = reader["Estado"] is DBNull ? null : (string)reader["Estado"],
                                    Cidade = reader["Cidade"] is DBNull ? null : (string)reader["Cidade"],
                                    Bairro = reader["Bairro"] is DBNull ? null : (string)reader["Bairro"],
                                    Rua = reader["Rua"] is DBNull ? null : (string)reader["Rua"],
                                    NumCasa = reader["NumCasa"] is DBNull ? null : (int?)reader["NumCasa"],
                                    DataRemocao = reader["DataRemocao"] is DBNull ? null : (DateTime?)reader["DataRemocao"]
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
                finally
                {
                    connection.Close();
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
                                UserPersistence persistence = new UserPersistence();

                                persistence.Id = (int)reader["Id"];
                                persistence.Matricula = (int)reader["Matricula"];
                                persistence.Nome = reader["Nome"] is DBNull ? null : (string)reader["Nome"];
                                persistence.Senha = reader["Senha"] is DBNull ? null : (string)reader["Senha"];
                                persistence.Celular = reader["Celular"] is DBNull ? null : (string)reader["Celular"];
                                persistence.Photo = reader["Photo"] is DBNull ? null : (byte[])reader["Photo"];
                                persistence.DataNascimento = (DateTime)reader["DataNascimento"];
                                persistence.Email = reader["Email"] is DBNull ? null : (string)reader["Email"];
                                persistence.Token = (int)reader["TokenValidacao"];
                                persistence.IdTipo = (int)reader["IdTipo"];
                                persistence.Tipo = reader["Tipo"] is DBNull ? null : (string)reader["Tipo"];
                                persistence.IdGenero = (int)reader["IdGenero"];
                                persistence.CodigoGenero = reader["CodigoGenero"] is DBNull ? null : (string)reader["CodigoGenero"];
                                persistence.Genero = reader["Genero"] is DBNull ? null : (string)reader["Genero"];
                                persistence.IdSituacao = (int)reader["IdSituacao"];
                                persistence.Situacao = reader["Situacao"] is DBNull ? null : (string)reader["Situacao"];
                                persistence.IdEndereco = reader["IdEndereco"] is DBNull ? null : (int?)reader["IdEndereco"];
                                persistence.CEP = reader["CEP"] is DBNull ? null : (string)reader["CEP"];
                                persistence.SiglaEstado = reader["SiglaEstado"] is DBNull ? null : (string)reader["SiglaEstado"];
                                persistence.Estado = reader["Estado"] is DBNull ? null : (string)reader["Estado"];
                                persistence.Cidade = reader["Cidade"] is DBNull ? null : (string)reader["Cidade"];
                                persistence.Bairro = reader["Bairro"] is DBNull ? null : (string)reader["Bairro"];
                                persistence.Rua = reader["Rua"] is DBNull ? null : (string)reader["Rua"];
                                persistence.NumCasa = reader["NumCasa"] is DBNull ? null : (int?)reader["NumCasa"];
                                persistence.DataRemocao = reader["DataRemocao"] is DBNull ? null : (DateTime?)reader["DataRemocao"];


                                userList.Add(persistence);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
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
                    Token = user.Token,
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
						,Usr.[TokenValidacao]
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


        public static int? GetEnderecoByCEP(string cep)
        {
            int? returnData = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT top 1 Id FROM UsuarioEndereco WHERE CEP = @cep";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandText = query;
                        StringBuilder builder = new StringBuilder(cep);
                        cep = builder.Insert(cep.Length - 3, "-").ToString();
                        command.Parameters.AddWithValue("@cep", cep.Trim());
                        returnData = Convert.ToInt32(command.ExecuteScalar());
                    }

                    if (returnData <= 0)
                    {
                        var cepInformation = ConsultaCEP.GetCEPInformation(Convert.ToInt32(cep)).Result;

                        if (cepInformation != null)
                        {
                            query = @"INSERT INTO UsuarioEndereco
                                            (CEP,
                                            Rua,
                                            Bairro,
                                            Cidade,
                                            SiglaEstado)
                                      VALUES
                                            (@Cep,
                                             @Rua,
                                             @Bairro,
                                             @Cidade,
                                             @SiglaEstado)";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.CommandText = query;
                                command.Parameters.AddWithValue("@Cep", cepInformation.Cep);
                                command.Parameters.AddWithValue("@Rua", cepInformation.Logradouro);
                                command.Parameters.AddWithValue("@Bairro", cepInformation.Bairro);
                                command.Parameters.AddWithValue("@Cidade", cepInformation.Localidade);
                                command.Parameters.AddWithValue("@SiglaEstado", cepInformation.Uf);
                                command.ExecuteNonQuery();
                            }

                            return GetEnderecoByCEP(cep);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return returnData;
        }
        public static void InsertUserData(string cel, int? idCep, string dataNascimento, string email, string genero, string nome, string senha, string matricula, string tipo, int? token)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string updateQuery = @"INSERT INTO [dbo].[Usuario]
                                                   ([Matricula]
                                                   ,[Nome]
                                                   ,[Senha]
                                                   ,[Celular]
                                                   ,[DataNascimento]
                                                   ,[Email]
                                                   ,[IdTipo]
                                                   ,[IdGenero]
                                                   ,[IdEndereco]
                                                   ,[IdSituacao]
                                                   ,[Photo]
                                                   ,[DataRemocao]
                                                   ,[TokenValidacao])
                                             VALUES
                                                   (@Matricula
                                                   ,@Nome
                                                   ,@Senha
                                                   ,@Celular
                                                   ,@DataNascimento
                                                   ,@Email
                                                   ,(SELECT TOP 1 Id FROM UsuarioTipo WHERE Descricao = @Tipo)
                                                   ,(SELECT TOP 1 Id FROM UsuarioGenero WHERE Descricao = @Genero)
                                                   ,@Endereco
                                                   ,1
                                                   ,NULL
                                                   ,NULL
                                                   ,@Token)";

                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@Matricula", matricula);
                        updateCommand.Parameters.AddWithValue("@Nome", nome);
                        updateCommand.Parameters.AddWithValue("@Senha", senha);
                        updateCommand.Parameters.AddWithValue("@Celular", string.IsNullOrEmpty(cel) ? null : cel);
                        updateCommand.Parameters.AddWithValue("@DataNascimento", dataNascimento);
                        updateCommand.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? null : email);
                        updateCommand.Parameters.AddWithValue("@Tipo", tipo);
                        updateCommand.Parameters.AddWithValue("@Genero", genero);
                        updateCommand.Parameters.AddWithValue("@Token", token);
                        updateCommand.Parameters.AddWithValue("@Endereco", idCep);
                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static void UpdatePassword(string email, string senha)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string passEncript = EncryptionHelper.Encrypt(senha);

                    string updateQuery = "UPDATE [dbo].[Usuario] SET [Senha] = @novo_valor WHERE [Matricula] = @condicao";

                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@novo_valor", passEncript);
                        updateCommand.Parameters.AddWithValue("@condicao", email);
                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public static void UpdateUserData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Código de acesso ao banco de dados
                }
                catch (Exception ex)
                {
                    // Lidar com erros
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        #endregion

        public static string GetCurrentAccess()
        {
            int returnData = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "Select COUNT(*) From CatracaWIP";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandText = query;
                        returnData = Convert.ToInt32(command.ExecuteScalar());
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return returnData.ToString();
        }

        public static string GetTrainingToLost()
        {
            int returnData = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"Select COUNT(*)
                                     From ExercicioTreinoMontado With(nolock)
                                     Where DataVencimento > DATEADD(WEEK, 1, GETDATE())";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandText = query;
                        returnData = Convert.ToInt32(command.ExecuteScalar());
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return returnData.ToString();
        }

        public static string GetMonthFrequencePercent()
        {
            double returnData = 0;
            int qtdUsuarioCadastrado = 0;
            int qtdUsuarioCatraca = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"Select COUNT(*) as UsuarioCadastrado
                                     From Usuario With(nolock)
                                     Where DataRemocao IS NOT NULL";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandText = query;
                        qtdUsuarioCadastrado = Convert.ToInt32(command.ExecuteScalar());
                    }

                    query = @"Select
	                                Count(*) as UsuarioCatraca
                                From
                                (
	                                Select IdUsuario
	                                From CatracaOcorrencia With(nolock)
	                                Where MONTH(DataOcorrencia) = MONTH(GETDATE()) 
		                                 AND YEAR(DataOcorrencia) = YEAR(GETDATE())
	                                Group by IdUsuario
                                ) base";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandText = query;
                        qtdUsuarioCatraca = Convert.ToInt32(command.ExecuteScalar());
                    }

                    returnData = ((qtdUsuarioCatraca * 100) / qtdUsuarioCadastrado) * 100;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            
            return Math.Round(returnData, 1).ToString();
        }
    }
}
