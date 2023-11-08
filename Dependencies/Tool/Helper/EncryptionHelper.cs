using System.Linq;

namespace TechConnect
{
    public class EncryptionHelper
    {
        public static string Encrypt(string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt(12);
            return BCrypt.Net.BCrypt.HashPassword(password, salt);
        }

        public static bool Decrypt(string user, string password)
        {
            UserDTO objectUser = DataBaseRequest.GetUser(user).FirstOrDefault();
            if (objectUser != null)
            {
                string senhaCriptografada = objectUser.Password; //buscar no banco
                return BCrypt.Net.BCrypt.Verify(password, senhaCriptografada);
            }
            else
                return false;
        }
    }
}
