namespace Kata1
{
    public class Jugada
    {       
        /// <summary>
        /// Devuelve Gana, Pierde o Empate respecto a la primera jugada (Jugador1)
        /// Si alguna de las dos jugadas fuera nula o de otro tipo, devolvería inválido
        /// </summary>
        /// <param name="jugada1"></param>
        /// <param name="jugada2"></param>
        /// <returns>Enum</returns>
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
