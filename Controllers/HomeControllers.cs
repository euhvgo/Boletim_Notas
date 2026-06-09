using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Boletim_Notas.Models;

namespace Boletim_Notas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Boletim()
        {
            var boletim = new BoletimViewModel
            {
                Itens = new List<BoletimItem>
                {
                    new BoletimItem { Disciplina = "Programação Front-End", Nota = 9.5 },
                    new BoletimItem { Disciplina = "Banco de Dados", Nota = 6.2 },
                    new BoletimItem { Disciplina = "Desenvolvimento Web", Nota = 7.8 },
                    new BoletimItem { Disciplina = "Estrutura de Dados", Nota = 4.5 },
                    new BoletimItem { Disciplina = "Arquitetura de Software", Nota = 8.0 }
                }
            };

            return View(boletim);
        }
    }
}
