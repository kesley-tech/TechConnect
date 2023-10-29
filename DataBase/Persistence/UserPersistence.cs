using System;

namespace TechConnect
{
    public class UserPersistence
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Celular { get; set; }
        public byte[] Photo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public int Token { get; set; }
        public int IdTipo { get; set; }
        public string Tipo { get; set; }
        public int IdGenero { get; set; }
        public string CodigoGenero { get; set; }
        public string Genero { get; set; }
        public int IdSituacao { get; set; }
        public string Situacao { get; set; }
        public int? IdEndereco { get; set; }
        public string CEP { get; set; }
        public string SiglaEstado { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int? NumCasa { get; set; }
        public DateTime? DataRemocao { get; set; }
    }
}
