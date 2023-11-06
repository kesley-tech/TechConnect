using System;

namespace TechConnect
{
    public class StatusCatracaPersistence
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public byte[] Foto { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public int IdStatus { get; set; }
        public string Status { get; set; }
    }
}
