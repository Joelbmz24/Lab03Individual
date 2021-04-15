using System;

namespace GBS
{
    public class Hut : IKeys, IWoods, Iaromatics
    {
        public void Keys()
        {
            Console.Write("Bienvenido");
            Console.Write("Tome sus llaves");
        }

        public void Woods()
        {
            Console.Write("su madera ");
        }


        public void aromatics()
        {
            Console.WriteLine("y unos aromatizantes");
        }
    }
}