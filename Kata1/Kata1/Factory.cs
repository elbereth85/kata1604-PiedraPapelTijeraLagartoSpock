namespace Kata1
{
    static class Factory
    {
        public static Jugador Get(int id)
        {
            switch (id)
            {
                case 1:
                    return new Jugador.Jugador1();
                case 2:
                default: 
                    return new Jugador.Jugador2();
            }
        }
    }
}
