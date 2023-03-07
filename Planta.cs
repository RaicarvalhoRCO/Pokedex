using Pokedex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    internal class Planta : Pokemon
    {
        public Planta(string nome, string tipo) : base(nome, tipo)
        {

        }

        public string fraquezas { get; set; } = "Fogo: 2x /n Voador: 2x";
        public string resistencias { get; set; } = "Água: 0.5x";
        public string imunidades { get; set; } = "Nenhum";

    }
}
