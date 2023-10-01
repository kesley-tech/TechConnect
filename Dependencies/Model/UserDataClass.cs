namespace TechConnect
{
    public class UserDataClass
    {
        public string User { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public USER_TYPE Type { get; set; }
        public string PhoneNumber { get; set; }
        public string CEP { get; set; }
        public string HouseNumber { get; set; }
        public string AddressMoreInfo { get; set; }
        public SEXUALITY_TYPE Sexuality { get; set; }
        public bool Enable { get; set; }

        public enum SEXUALITY_TYPE
        {
            M,
            F
        }

        public enum USER_TYPE
        {
            Administrador,
            Recepção,
            Instrutor,
            Aluno
        }
    }
}
