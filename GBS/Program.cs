using System;

namespace GBS
{

    class Program
    {  
        //Habitaciones
        static int HotelRoom = 0;
        static int HotelCabin = 0;
        static int HotelHut = 0;

         //Acumulators para las reservas
         static int HutCount = 0;
         static int HotelCount = 0;
         static int CabinCount = 0;
        

         public static void ShowReservations()
        {
            int Op = 0;
            Console.WriteLine("\n*******Ver las reservaciones de*******\n ");
            Console.WriteLine("1- Hotel");
            Console.WriteLine("2- Cabaña");
            Console.WriteLine("3- Choza");
            Console.WriteLine("4- Todas las reservaciones ");
            Op = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            
            switch(Op)
            {
                //Mostramos las reservaciones segun el lugar que escogio
                case 1: 
                    Console.WriteLine($"\nReservaciones hechas para el hotel: {HotelCount}"); 
                    break;
                case 2: 
                    Console.WriteLine($"\nReservaciones hechas para la cabaña: {CabinCount}"); 
                    break;
                case 3: 
                    Console.WriteLine($"\nReservaciones hechas para la choza: {HutCount}"); 
                    break;
                case 4:
                    Console.WriteLine($"El total de reservacion es: {HotelCount+CabinCount+HutCount}");
                    break;
                default: 
                    Console.WriteLine("opcion invalida"); 
                    break;
            } Console.WriteLine(" ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nBienvenido a GBS ");

           bool flag = true;
            do{
                switch(Entermenu())
                { 
                    case 1: 
                        MakeReservation(); 
                        break;
                    case 2: 
                        IntoRoom(); 
                        break;
                    case 3: 
                        Leave(); 
                        break;
                    case 4: 
                        ShowReservations(); 
                        break;
                    case 5: 
                        Console.WriteLine("Finalizando programa..........");
                        flag = false; 
                        break;
                    default: 
                        Console.WriteLine("Opcion invalida"); 
                        break;
                }
            }while(flag);
        }
        
        public static int Entermenu()
        {
            Console.WriteLine("\n///// Menu //////");
            Console.WriteLine();
            Console.WriteLine("1- Hacer reservación");
            Console.WriteLine("2- Entrar a una habitación reservada ");
            Console.WriteLine("3- Dejar una habitación");
            Console.WriteLine("4- Mostrar las reservas almacenadas");
            Console.WriteLine("5- Salir");
            return Int32.Parse(Console.ReadLine());
        }
          
          public static void Pay()
        {
            int info;  
            Console.WriteLine("\nForma de pago");
            Console.WriteLine("1- Tarjeta");
            Console.WriteLine("2- Efectivo");
            info = Int32.Parse(Console.ReadLine());  
            Console.WriteLine();    
        }


        public static void MakeReservation()
        {  
            int option = 0;
            Console.WriteLine("\n1- Reservar habitacion de hotel");
            Console.WriteLine("2- Reservar habitacion de choza");
             Console.WriteLine("3- Reservar habitacion de cabaña");
            Console.Write(">>");
            option = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            
            switch(option)
            {
                case 1: 
                    Pay(); 
                    HotelCount += 1;
                    HotelRoom += 1;
                    break;
                case 2: 
                    Pay(); 
                    HutCount += 1; 
                    HotelHut += 1;
                    break;
                case 3:  
                     Pay(); 
                    CabinCount += 1; 
                    HotelCabin += 1;
                    break;
                default: 
                    Console.WriteLine("opcion invalida"); 
                    break;
            }Console.WriteLine();
        }
       
        public static void IntoRoom()
        {
            int opcion = 0;

            Console.WriteLine("\n1- Entrar a una habitacion de Hotel");
            Console.WriteLine("2- Entrar a una habitacion en una Cabaña");
            Console.WriteLine("3- Entrar a una habitacion en una Choza");
            Console.Write(">>");
            opcion = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            //verificacion de reservaciones
            switch(opcion)
            {
                case 1: 
                    if(HotelCount == 0)
                        Console.WriteLine("\nTienes que tener una reserva para poder ingresar");
                    else
                        Hotel();   
                    break;
                case 2: 
                    if(CabinCount == 0)
                        Console.WriteLine("\nTienes que tener una reserva para poder ingresar");
                    else
                        Cabin();
                    break;
                case 3: 
                    if(HutCount == 0)
                        Console.WriteLine("\nTienes que tener una reserva para poder ingresar");
                    else
                        Hut();
                    break;
                default: 
                    Console.WriteLine("opcion invalida"); 
                    break;
            }Console.WriteLine(" ");
        }

        public static void Hotel()
        {
            
            var Hotel = new Hotel();
            Hotel.Keys();
        }

        public static void Cabin()
        {
           
            var Cabin = new Cabin();
            Cabin.Keys();
            Cabin.Woods();
        }

        public static void Hut()
        {
            var Hut = new Hut();
            Hut.Woods();
            Hut.aromatics();
            Hut.Keys();
        }

        public static void Leave()
        {
            int opcion = 0;
            Console.WriteLine();
            Console.WriteLine("1- Irse del Hotel");
            Console.WriteLine("2- Irse de la Cabaña");
            Console.WriteLine("3- Irse de la choza");
            Console.Write(">>");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch(opcion)
            {
                //mostramos al usuario las pertenencias a dejar segun su lugar de estadia
                case 1: 
                    if(HotelRoom <= 0)
                        Console.WriteLine("\nNo hay reserva de hotel");
                    else
                    {
                        Console.WriteLine("Porfavor deje las llaves"); 
                        HotelRoom -= 1;
                    }
                    break;
                case 2: 
                    if(HotelCabin == 0)
                        Console.WriteLine("\nNo hay reserva de cabaña");
                    else
                    {    
                        Console.WriteLine("Por favor deje las llaves y la madera");
                        HotelCabin -= 1;
                    }
                    break;
                case 3: 
                    if(HotelHut == 0)
                        Console.WriteLine("\nNo hay reserva de choza");
                    else
                    {
                        Console.WriteLine("favor dejar la madera,llavez y velas");
                        HotelHut -= 1;
                    }
                    break;
                default: 
                    Console.WriteLine("opcion invalida"); 
                    break;
            }Console.WriteLine();
        }

       
    }
}
