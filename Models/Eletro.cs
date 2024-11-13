﻿namespace Eletrodomestico.Models
{
    public abstract class Eletro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double ConsumoEnergetico { get; set; } 
        public abstract string ExibirDetalhes();
    }
}
