using System;

namespace TechConnect
{
    public class UserDTO
    {
        public int Id { get; set; }
        public int Register { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public UserTypeDTO Type { get; set; }
        public UserGenderDTO Gender { get; set; }
        public UserSituationDTO Situation { get; set; }
        public UserAddressDTO Address { get; set; }
    }

    public class UserTypeDTO
    {
        public int Id { get; set; }
        public int Description { get; set; }
    }

    public class UserGenderDTO
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public int Description { get; set; }
    }

    public class UserSituationDTO
    {
        public int Id { get; set; }
        public int Description { get; set; }
    }

    public class UserAddressDTO
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string StateAcronym { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }

    }
}
