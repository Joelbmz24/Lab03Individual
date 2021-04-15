using System;

namespace GBS
{
    public class Cabin : IKeys, IWoods
    {
        public void Keys()
        {
            Console.Write("Bienvenido ");
            Console.Write("Tome sus llaves");
        }

        public void Woods()
        {
            Console.WriteLine("y su madera ");
        }
    }
}