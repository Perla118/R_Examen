using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_Examen
{
    public class ListaEnlazada
    {
        private Nodo primero;



        public bool ListaVacia()
        {
            return primero == null;
        }

        //Insertar una lista de carros
        public void InsertarunCarro(string marca, string modelo, int añoLanzamiento)
        {
            Carro nuevoCarro = new Carro { Marca = marca, Modelo = modelo, AñoLanzamiento = añoLanzamiento };
            Nodo nuevoNodo = new Nodo(nuevoCarro);

            if (primero == null)
            {
                primero = nuevoNodo;
            }
            else
            {
                Nodo actual = primero;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        //Ordenar por año

        //Busqueda por marca

        public void BuscarMarca(string marcaABuscar)
        {
            Nodo actual = primero;
            bool encontrado = false;

            while (actual != null)
            {
                if (actual.DatosCarro.Marca.ToLower() == marcaABuscar.ToLower())
                {
                    Console.WriteLine($"La marca es: {actual.DatosCarro.Marca}, el modelo es: {actual.DatosCarro.Modelo}, el año de lanzamiento fue: {actual.DatosCarro.AñoLanzamiento}");
                    encontrado = true;
                }
                actual = actual.Siguiente;
            }

            if (!encontrado)
            {
                Console.WriteLine($"No se encontro esa marca {marcaABuscar}.");
            }
        }

        //Mostrar lista
        public void ImprimirLista()
        {
            Nodo actual = primero;

            while (actual != null)
            {
                Console.WriteLine($"Marca: {actual.DatosCarro.Marca}, Modelo: {actual.DatosCarro.Modelo}, Año: {actual.DatosCarro.AñoLanzamiento}");
                actual = actual.Siguiente;
            }
        }
    }
}
