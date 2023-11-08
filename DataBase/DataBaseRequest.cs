using DevExpress.CodeParser;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.CodeParser.CodeStyle.Formatting.Rules;

namespace TechConnect
{
    public class DataBaseRequest
    {
        private WaitFormRender waitForm = new WaitFormRender();
        

        private const string connectionString = "Password=techdeveloper;Persist Security Info=True;User ID=sa;Initial Catalog=dbTechDeveloper;Data Source=18.230.186.78";

        public static bool TestConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        //private const string connectionString = "Password=sequor;Persist Security Info=True;User ID=sequor;Initial Catalog=dbTechDeveloper;Data Source=SQO-111\\MSSQL16";

        private static void ShowNotification(string content, int milisecShowTime)
        {
            //notifyIcon.BalloonTipTitle = "Falha na Manipulação de Dados";
            //notifyIcon.BalloonTipText = content;
            //notifyIcon.ShowBalloonTip(milisecShowTime);
        }

        #region User
        public static List<UserDTO> GetUser(string matricula)
        {
            List<UserDTO> result = new List<UserDTO>();
            List<UserPersistence> userList = new List<UserPersistence>();

            string query = QueryGetUser();
            query += $@" and Usr.[Matricula] = {matricula}";

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
                    ShowNotification(ex.Message, 2000);
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
                                UserPersistence persistence = new UserPersistence
                                {
                                    Id = (int)reader["Id"],
                                    Matricula = (int)reader["Matricula"],
                                    Nome = reader["Nome"] is DBNull ? null : (string)reader["Nome"],
                                    Senha = reader["Senha"] is DBNull ? null : (string)reader["Senha"],
                                    Celular = reader["Celular"] is DBNull ? null : (string)reader["Celular"],
                                    Photo = reader["Photo"] is DBNull ? null : (byte[])reader["Photo"],
                                    DataNascimento = (DateTime)reader["DataNascimento"],
                                    Email = reader["Email"] is DBNull ? null : (string)reader["Email"],
                                    Token = (int)reader["TokenValidacao"],
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
                    ShowNotification(ex.Message, 2000);
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
                    AddressMoreInfo = $"{user.Rua}, {user.Bairro} - {user.Cidade}-{user.SiglaEstado}",
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
						And Endereco.DataRemocao is Null
                    Where
                        Usr.[DataRemocao] is null";
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
                        if (cep.Length > 3 && !cep.Contains("-"))
                            cep = builder.Insert(cep.Length - 3, "-").ToString();
                        command.Parameters.AddWithValue("@cep", cep.Trim());
                        returnData = Convert.ToInt32(command.ExecuteScalarAsync());
                    }

                    if (returnData <= 0)
                    {
                        int.TryParse(cep.Trim().Replace("-", ""), out int cepInt);
                        var cepInformation = ConsultaCEP.GetCEPInformation(cepInt);

                        if (cepInformation != null && cepInformation.Cep != null)
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
                    ShowNotification(ex.Message, 2000);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
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
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("INSERT INTO [dbo].[Usuario]                                               ");
                    query.AppendLine("        ([Matricula]                                                      ");
                    query.AppendLine("        ,[Nome]                                                           ");
                    query.AppendLine("        ,[Senha]                                                          ");
                    query.AppendLine("        ,[Celular]                                                        ");
                    query.AppendLine("        ,[DataNascimento]                                                 ");
                    query.AppendLine("        ,[Email]                                                          ");
                    query.AppendLine("        ,[IdTipo]                                                         ");
                    query.AppendLine("        ,[IdGenero]                                                       ");
                    query.AppendLine("        ,[IdEndereco]                                                     ");
                    query.AppendLine("        ,[IdSituacao]                                                     ");
                    query.AppendLine("        ,[Photo]                                                          ");
                    query.AppendLine("        ,[DataRemocao]                                                    ");
                    query.AppendLine("        ,[TokenValidacao])                                                ");
                    query.AppendLine("  VALUES                                                                  ");
                    query.AppendLine("        (@Matricula                                                       ");
                    query.AppendLine("        ,@Nome                                                            ");
                    query.AppendLine("        ,@Senha                                                           ");
                    if (string.IsNullOrEmpty(cel))
                        query.AppendLine("    ,NULL                                                             ");
                    else
                        query.AppendLine("    ,@Celular                                                         ");
                    query.AppendLine("        ,@DataNascimento                                                  ");
                    if (string.IsNullOrEmpty(email))
                        query.AppendLine("    ,NULL                                                             ");
                    else
                        query.AppendLine("    ,@Email                                                           ");
                    query.AppendLine("        ,(SELECT TOP 1 Id FROM UsuarioTipo WHERE Descricao = @Tipo)       ");
                    query.AppendLine("        ,(SELECT TOP 1 Id FROM UsuarioGenero WHERE Codigo = @Genero)   ");
                    if (idCep is null)
                        query.AppendLine("    ,NULL                                                             ");
                    else
                        query.AppendLine("    ,@Endereco                                                        ");
                    query.AppendLine("        ,1                                                                ");
                    query.AppendLine("        ,NULL                                                             ");
                    query.AppendLine("        ,NULL                                                             ");
                    query.AppendLine("        ,@Token)                                                          ");

                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(query.ToString(), connection))
                    {
                        updateCommand.Parameters.Add(new SqlParameter("@Matricula", matricula));
                        updateCommand.Parameters.Add(new SqlParameter("@Nome", nome));
                        updateCommand.Parameters.Add(new SqlParameter("@Senha", senha));
                        updateCommand.Parameters.Add(new SqlParameter("@DataNascimento", dataNascimento));
                        updateCommand.Parameters.Add(new SqlParameter("@Tipo", tipo));
                        updateCommand.Parameters.Add(new SqlParameter("@Genero", genero));
                        updateCommand.Parameters.Add(new SqlParameter("@Token", token));

                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    ShowNotification(ex.Message, 2000);
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
                    ShowNotification(ex.Message, 2000);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public static void UpdateUserData(string cel, int? idCep, string dataNascimento, string email, string genero, string nome, string matricula, string tipo, int? token)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("UPDATE                                                                            ");
                    query.AppendLine("    [dbo].[Usuario]                                                               ");
                    query.AppendLine("SET                                                                               ");
                    query.AppendLine("    [Nome] = @Nome                                                                ");
                    if (string.IsNullOrEmpty(cel))
                        query.AppendLine("   ,[Celular] = NULL                                                          ");
                    else
                        query.AppendLine($"   ,[Celular] = '{cel}'                                                      ");
                    query.AppendLine("   ,[DataNascimento] = @DataNascimento                                            ");
                    if (string.IsNullOrEmpty(email))
                        query.AppendLine("   ,[Email] = NULL                                                          ");
                    else
                        query.AppendLine($"   ,[Email] = '{email}'                                                      ");
                    query.AppendLine("   ,[IdTipo] = (SELECT TOP 1 Id FROM UsuarioTipo WHERE Descricao = @Tipo)         ");
                    query.AppendLine("   ,[IdGenero] = (SELECT TOP 1 Id FROM UsuarioGenero WHERE Codigo = @Genero)   ");
                    if (idCep is null)
                        query.AppendLine("   ,[IdEndereco] = NULL                                                       ");
                    else
                        query.AppendLine($"   ,[IdEndereco] = {idCep}                                                   ");
                    query.AppendLine("   ,[IdSituacao] = 1                                                              ");
                    query.AppendLine("   ,[Photo] = NULL                                                                ");
                    query.AppendLine("   ,[DataRemocao] = NULL                                                          ");
                    query.AppendLine("   ,[TokenValidacao] = @Token                                                     ");
                    query.AppendLine("WHERE                                                                             ");
                    query.AppendLine("    [Matricula] = @Matricula                                                      ");

                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(query.ToString(), connection))
                    {
                        updateCommand.Parameters.Add(new SqlParameter("@Matricula", Convert.ToInt32(matricula)));
                        updateCommand.Parameters.Add(new SqlParameter("@Nome", nome));
                        updateCommand.Parameters.Add(new SqlParameter("@DataNascimento", Convert.ToDateTime(dataNascimento)));
                        updateCommand.Parameters.Add(new SqlParameter("@Tipo", tipo));
                        updateCommand.Parameters.Add(new SqlParameter("@Genero", genero));
                        updateCommand.Parameters.Add(new SqlParameter("@Token", token));

                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    ShowNotification(ex.Message, 2000);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static void RemoveUserData(string matricula)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string updateQuery = @"UPDATE 
                                                [dbo].[Usuario]
                                           SET
                                                [DataRemocao] = GETDATE()
                                            WHERE
                                                [Matricula] = @Matricula";

                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.Add(new SqlParameter("@Matricula", matricula));
                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    ShowNotification(ex.Message, 2000);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        #endregion

        #region Workout
        public static List<WorkoutDTO> GetAllWorkout()
        {
            List<WorkoutDTO> result = new List<WorkoutDTO>();
            List<WorkoutPersistence> list = new List<WorkoutPersistence>();

            string query = @"Select 
	                                exe.Id,
	                                exe.Codigo,
	                                exe.Descricao,
	                                musc.Id as IdGrupoMuscular,
	                                musc.Descricao as GrupoMuscular,
	                                exe.TreinoLivre
                                From 
	                                Exercicio exe With(nolock)
                                Inner Join
	                                ExercicioGrupoMuscular musc With(nolock)
                                On
	                                exe.IdGrupoMuscular = musc.Id
                                Where
	                                exe.DataRemocao IS NULL";

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
                                WorkoutPersistence persistence = new WorkoutPersistence()
                                {
                                    Id = (int)reader["Id"],
                                    Code = (string)reader["Codigo"],
                                    Description = (string)reader["Descricao"],
                                    IdMuscleGroup = (int)reader["IdGrupoMuscular"],
                                    MuscleGroup = (string)reader["GrupoMuscular"],
                                    FreeWorkout = (bool)reader["TreinoLivre"]
                                };

                                list.Add(persistence);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ShowNotification(ex.Message, 2000);
                }
                finally
                {
                    connection.Close();
                }
            }

            foreach (var user in list)
            {
                result.Add(new WorkoutDTO()
                {
                    Code = user.Code,
                    Description = user.Description,
                    GrupoMuscular = (WorkoutDTO.MUSCLE_GROUP_TYPE)user.IdMuscleGroup,
                    FreeWorkout = user.FreeWorkout
                });
            }

            return result;
        }

        public static void InsertWorkoutData(string code, string description, string muscleGroup, bool freeWorkout)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("INSERT INTO [dbo].[Exercicio]                                                             ");
                    query.AppendLine("        ([Codigo]                                                                         ");
                    query.AppendLine("        ,[Descricao]                                                                      ");
                    query.AppendLine("        ,[IdGrupoMuscular]                                                                ");
                    query.AppendLine("        ,[TreinoLivre])                                                                   ");
                    query.AppendLine("  VALUES                                                                                  ");
                    query.AppendLine("        (@Codigo                                                                          ");
                    query.AppendLine("        ,@Descricao                                                                       ");
                    query.AppendLine("        ,(Select top 1 Id From ExercicioGrupoMuscular Where Descricao = @GrupoMuscular)   ");
                    query.AppendLine("        ,@Livre)                                                                          ");

                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(query.ToString(), connection))
                    {
                        updateCommand.Parameters.Add(new SqlParameter("@Codigo", code));
                        updateCommand.Parameters.Add(new SqlParameter("@Descricao", description));
                        updateCommand.Parameters.Add(new SqlParameter("@GrupoMuscular", muscleGroup));
                        updateCommand.Parameters.Add(new SqlParameter("@Livre", freeWorkout));

                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    ShowNotification(ex.Message, 2000);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static void UpdateWorkoutData(string code, string description, string muscleGroup, bool freeWorkout)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("UPDATE                          ");
                    query.AppendLine("    [dbo].[Exercicio]           ");
                    query.AppendLine("SET                             ");
                    query.AppendLine("    [Descricao] = @Descricao    ");
                    query.AppendLine("   ,[IdGrupoMuscular] = (Select top 1 Id From ExercicioGrupoMuscular Where Descricao = @GrupoMuscular) ");
                    query.AppendLine("   ,[TreinoLivre] = @Livre      ");
                    query.AppendLine("WHERE                           ");
                    query.AppendLine("    [Codigo] = @Codigo          ");

                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(query.ToString(), connection))
                    {
                        updateCommand.Parameters.Add(new SqlParameter("@Codigo", code));
                        updateCommand.Parameters.Add(new SqlParameter("@Descricao", description));
                        updateCommand.Parameters.Add(new SqlParameter("@GrupoMuscular", muscleGroup));
                        updateCommand.Parameters.Add(new SqlParameter("@Livre", freeWorkout));

                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    ShowNotification(ex.Message, 2000);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static void RemoveWorkoutData(string code)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string updateQuery = @"UPDATE 
                                                [dbo].[Exercicio]
                                           SET
                                                [DataRemocao] = GETDATE()
                                            WHERE
                                                [Codigo] = @Codigo";

                    connection.Open();

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.Add(new SqlParameter("@Codigo", code));
                        updateCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    ShowNotification(ex.Message, 2000);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        #endregion
        public static async Task<string> GetCurrentAccess()
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
                        returnData = Convert.ToInt32(await command.ExecuteScalarAsync());
                    }

                }
                catch (Exception ex)
                {
                    ShowNotification(ex.Message, 2000);
                }
                finally
                {
                    connection.Close();
                }
            }

            return returnData.ToString();
        }
        public static async Task<string> GetTrainingToLost()
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
                        returnData = Convert.ToInt32(await command.ExecuteScalarAsync());
                    }

                }
                catch (Exception ex)
                {
                    ShowNotification(ex.Message, 2000);
                }
                finally
                {
                    connection.Close();
                }
            }

            return returnData.ToString();
        }
        public static async Task<string> GetMonthFrequencePercent()
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
                                     Where DataRemocao IS NULL";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandText = query;
                        qtdUsuarioCadastrado = Convert.ToInt32(await command.ExecuteScalarAsync());
                    }

                    query = @"Select
	                                Count(*) as UsuarioCatraca
                                From
                                (
	                                Select IdUsuario
	                                From CatracaOcorrencia ocu With(nolock)
	                                Inner Join Usuario usr On usr.id = ocu.IdUsuario and usr.DataRemocao is null
	                                Where MONTH(DataOcorrencia) = MONTH(GETDATE()) 
		                                    AND YEAR(DataOcorrencia) = YEAR(GETDATE())
			                                AND IdStatus = 1
	                                Group by IdUsuario
                                ) base";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.CommandText = query;
                        qtdUsuarioCatraca = Convert.ToInt32(await command.ExecuteScalarAsync());
                    }

                    if (qtdUsuarioCadastrado > 0)
                        returnData = ((qtdUsuarioCatraca * 100) / qtdUsuarioCadastrado);

                }
                catch (Exception ex)
                {
                    ShowNotification(ex.Message, 2000);
                }
                finally
                {
                    connection.Close();
                }
            }


            return Math.Round(returnData, 1).ToString();
        }

        public static async Task<List<StatusCatracaPersistence>> GetStatusCatraca()
        {
            List<StatusCatracaPersistence> list = new List<StatusCatracaPersistence>();

            string query = @"Select Top 6
	                                ocorrencia.Id,
	                                usr.Matricula,
	                                usr.Nome,
	                                usr.Photo,
	                                ocorrencia.DataOcorrencia,
	                                status.Id as IdStatus,
	                                status.Descricao as [Status]
                                From 
	                                CatracaOcorrencia ocorrencia With(nolock)
                                Inner Join
	                                CatracaStatus status With(nolock)
                                On
	                                status.Id = ocorrencia.IdStatus
                                Inner Join
	                                Usuario	usr With(nolock)
                                On
	                                usr.Id = ocorrencia.IdUsuario
                                Order by
	                                DataOcorrencia Desc";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (reader.Read())
                            {
                                StatusCatracaPersistence persistence = new StatusCatracaPersistence()
                                {
                                    Id = (int)reader["Id"],
                                    Matricula = (int)reader["Matricula"],
                                    Nome = (string)reader["Nome"],
                                    IdStatus = (int)reader["IdStatus"],
                                    Status = (string)reader["Status"],
                                    DataOcorrencia = (DateTime)reader["DataOcorrencia"],
                                    //Foto = (byte[]?)reader["Photo"]
                                };

                                list.Add(persistence);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ShowNotification(ex.Message, 2000);
                }
                finally
                {
                    connection.Close();
                }
            }

            return list;
        }
    }
}
