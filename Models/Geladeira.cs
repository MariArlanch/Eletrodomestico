namespace Eletrodomestico.Models
{
    public class Geladeira : Eletro
    {
        public int CapacidadeLitros { get; set; }
        public bool TemFreezer { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo: {ConsumoEnergetico} kWh, Capacidade: {CapacidadeLitros} L, Freezer: {(TemFreezer ? "Sim" : "Não")}";
        }
    }
}
