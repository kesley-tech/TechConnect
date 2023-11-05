namespace TechConnect
{
    public class UserDTO
    {
        public int User { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public USER_TYPE Type { get; set; }
        public string PhoneNumber { get; set; }
        public string CEP { get; set; }
        public int? HouseNumber { get; set; }
        public string AddressMoreInfo { get; set; }
        public SEXUALITY_TYPE Sexuality { get; set; }
        public bool Enable { get; set; }
        public int Token { get; set; }

        public enum SEXUALITY_TYPE
        {
            None,
            M,
            F
        }

        public enum USER_TYPE
        {
            None,
            Administrador,
            Recepção,
            Instrutor,
            Aluno
        }
    }
}
