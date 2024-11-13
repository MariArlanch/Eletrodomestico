using Eletrodomestico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eletrodomestico.Controllers
{
    public class ListaEletrodomesticoController : Controller
    {
        public IActionResult Index()
        {
            var eletrodomesticos = new List<Eletro>

            {
                new Geladeira { Marca = "LG", Modelo = "GR-470", ConsumoEnergetico = 2.3, CapacidadeLitros = 450, TemFreezer = true },
                new Televisor { Marca = "Samsung", Modelo = "QLED 55", ConsumoEnergetico = 1.2, TamanhoTela = 55, EhSmart = true },
                new Geladeira { Marca = "Brastemp", Modelo = "BRM44", ConsumoEnergetico = 2.8, CapacidadeLitros = 375, TemFreezer = false },
                new Televisor { Marca = "Sony", Modelo = "XBR75X805G", ConsumoEnergetico = 2.1, TamanhoTela = 75, EhSmart = false }
            };
            return View(eletrodomesticos);
        }
    }
}
