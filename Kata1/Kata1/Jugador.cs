namespace Kata1
{
    public abstract class Jugador
    {
        public abstract string NombreJugador { get; }

        public class Jugador1 : Jugador
        {
            public override string NombreJugador
            {
                get
                {
                    return "Jugador1";
                }
            }
        }

        public class Jugador2 : Jugador
        {
            public override string NombreJugador
            {
                get
                {
                    return "Jugador2";
                }
            } 
        }
    }
}
