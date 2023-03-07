using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class Pokemon
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public string evolucoes { get; set; }
        public string descricao { get; set; }
        public string passiva { get; set; }

        public int HP { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        public int SPATK { get; set; }
        public int SPDEF { get; set; }
        public int VEL { get; set; }


        public Pokemon(string nome, string tipo)
        {
            string nomeex = nome;
            string tipoex = tipo;
            if (string.IsNullOrEmpty(tipoex) || string.IsNullOrEmpty(nomeex))
            {
                throw new ArgumentException("Exceção");
            }
            else
            {
                this.nome = nome;
                this.tipo = tipo;
            }

        }
        
    }
}
