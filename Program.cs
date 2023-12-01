using System.Reflection;
using System.Text.RegularExpressions;

namespace R_Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            lista.InsertarunCarro("Carro1", "Perla1", 2023);
            lista.InsertarunCarro("Carro2", "Perla2", 2023);

            Console.WriteLine("Gestión de flota de vehículos");
            


            Console.WriteLine("Si quieres poner un nuevo carro di si o no");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "si")
            {
                Console.WriteLine("Pon la marca, el modelo y el año de lanzamiento del nuevo carro:");

                Console.WriteLine("Pon la marca:");
                string nuevaMarca = Console.ReadLine();

                Console.WriteLine("Pon el modelo:");
                string nuevoModelo = Console.ReadLine();

                Console.WriteLine("Pon el año de lanzamiento:");
                int nuevoAñoLanzamiento = Convert.ToInt32(Console.ReadLine());

                lista.InsertarunCarro(nuevaMarca, nuevoModelo, nuevoAñoLanzamiento);

                Console.WriteLine("Lista de vehículos:");
                lista.ImprimirLista();
            }
            else
            {
                Console.WriteLine("Lista de vehículos:");
                lista.ImprimirLista();
            }


            Console.WriteLine("Quieres poner otro carro di si o no");
            string respuesta3 = Console.ReadLine();
            
            if (respuesta.ToLower() == "si")
            {
                Console.WriteLine("Pon la marca, el modelo y el año de lanzamiento del nuevo carro:");

                Console.WriteLine("Pon la marca:");
                string nuevaMarca = Console.ReadLine();

                Console.WriteLine("Pon el modelo:");
                string nuevoModelo = Console.ReadLine();

                Console.WriteLine("Pon el año de lanzamiento:");
                int nuevoAñoLanzamiento = Convert.ToInt32(Console.ReadLine());

                lista.InsertarunCarro(nuevaMarca, nuevoModelo, nuevoAñoLanzamiento);

                Console.WriteLine("Lista de vehículos:");
                lista.ImprimirLista();
            }
            else
            {
                Console.WriteLine("Lista de vehículos:");
                lista.ImprimirLista();
            }



            Console.WriteLine("Si quieres buscar un carro di si o no");
            string respuesta1 = Console.ReadLine();
            if (respuesta.ToLower() == "si")
            {
                Console.WriteLine("Pon la marca a buscar:");
                string marca = Console.ReadLine();
                lista.BuscarMarca(marca);
            }
        }
    }
}