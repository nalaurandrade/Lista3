﻿namespace atividade_1.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }


        public double Imc()
        {
            return Peso / (Altura * Altura);
        }
    }

}
