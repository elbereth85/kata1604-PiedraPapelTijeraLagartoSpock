using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata1
{
    public class Jugada
    {       
        public Resultado Play(Gesto jugada1, Gesto jugada2)
        {
            if (jugada1.GetType() != typeof(Gesto) || jugada2.GetType() != typeof(Gesto)) return Resultado.Invalido;

            if (jugada1.Equals(jugada2)) return Resultado.Empate; 

            if (jugada1.Equals(Gesto.Piedra) && (jugada2.Equals(Gesto.Tijera) || jugada2.Equals(Gesto.Lagarto))) return Resultado.Gana;

            if (jugada1.Equals(Gesto.Papel) && (jugada2.Equals(Gesto.Piedra) || jugada2.Equals(Gesto.Spock))) return Resultado.Gana;

            if (jugada1.Equals(Gesto.Tijera) && (jugada2.Equals(Gesto.Papel) || jugada2.Equals(Gesto.Lagarto))) return Resultado.Gana;

            if (jugada1.Equals(Gesto.Lagarto) && (jugada2.Equals(Gesto.Spock) || jugada2.Equals(Gesto.Papel))) return Resultado.Gana;

            if (jugada1.Equals(Gesto.Spock) && (jugada2.Equals(Gesto.Tijera) || jugada2.Equals(Gesto.Piedra))) return Resultado.Gana;

            return Resultado.Pierde;
        }

    }
}
