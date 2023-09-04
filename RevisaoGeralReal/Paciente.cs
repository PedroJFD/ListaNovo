using System;

namespace RevisaoGeralReal
{
    internal class Paciente
    {
        public int id_paciente { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public DateTime datanasci { get; set; }

        public Paciente(int id_paciente, string nome, string cpf, string email, DateTime datanasci)
        {
            this.id_paciente = id_paciente;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.datanasci = datanasci;
        }

        public Paciente()
        {
        }
    }
}
