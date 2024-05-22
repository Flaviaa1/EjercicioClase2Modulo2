using System.IO.Pipes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EjercicioClase2Modulo2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Utilizando LINQ resolver las siguientes consignas:

            //Carga de datos
            var lstClientes = new List<Clientes>()
            {
                new Clientes() { Apellido = "Jara", Nombre = "Alejandro" ,CodCliente = 123 , Vip = true, },
                new Clientes() { Apellido = "Mossier", Nombre = "Fernando" ,CodCliente = 345 , Vip = false},
                new Clientes() { Apellido = "Bustos", Nombre = "Andres" ,CodCliente = 567 , Vip = true},
                new Clientes() { Apellido = "Dalpiaz", Nombre = "Carla" ,CodCliente = 789 , Vip = true},
                new Clientes() { Apellido = "Miranda", Nombre = "Micaela" ,CodCliente = 112 , Vip = false},
                new Clientes() { Apellido = "De Castillo", Nombre = "Andrea" ,CodCliente = 223 , Vip = false},
            };


            #region Ejercicio1

            // Detectar cual es el numero mas grande e imprimirlo por consola

            var lstNumeros = new List<int>() { 25, 10, 99, 105, 1, 84, 22 };

            var numeroMayor = lstNumeros.Max();
            Console.WriteLine($"Elnumro mayor de las lista es; {numeroMayor}");

            #endregion

            #region Ejercicio2

            //Ordenar los nombres alfabeticamente
            var lstNombres = new List<string>() { "Ana", "Alejandro", "Alexis", "Pablo", "Carlos", "Anibal", "Carla", "Susana" };

            var ardenAlfavetico = lstNombres.OrderBy(X => X).ToList();
            foreach (var n in ardenAlfavetico)
            {
                Console.WriteLine(n);
            }


            #endregion

            #region Ejercicio3
            // Utilizando la variable "lstClientes" filtrar los clientes que tengan vip = true e imprimirlo por consola
            var clientes = lstClientes.Where(clientes => clientes.Vip == true).ToList();
            foreach (var cliente in clientes)
            {
                Console.WriteLine($" el cliente {cliente.Nombre} tiene vip; {cliente.Vip}");
            }

            #endregion

            #region Ejercicio4 

            //Utilizando la variable "lstClientes" crear una nueva lista donde solo se encuentren los nombres de los clientes e imprimir los nombres

            var nombres = lstClientes.Select(cliente => cliente.Nombre).ToList();
            Console.WriteLine("nombre de los clientes");
            foreach (var n in nombres) { Console.WriteLine($"Nombre cliente; {n}"); }


            #endregion

            #region Ejercicio5
            //Apartir de la variable "lstClientes" crear una lista que contenga todos los datos pero  modificando los siguientes campos:
            // Nombre tiene que guardarse en mayusculas
            // Apellido tiene que guardarse en mayusculas
            // Vip => se debe evaluar el bool y si es true se debe asignar el texto "Premium" y si es false "Normal"
            bool estadob;
            var listaTransformada = lstClientes.Select(c => new Clientes { Nombre = c.Nombre.ToUpper(), CodCliente = c.CodCliente, Apellido = c.Apellido.ToUpper(),Vip=c.Vip
              
                
            }).ToList();

            foreach (var cliente in listaTransformada)
            {
                string vipString = cliente.Vip ? "Premium" : "Normal";
                Console.WriteLine($"CodCliente: {cliente.CodCliente}, Nombre: {cliente.Nombre}, Apellido: {cliente.Apellido}, Vip: {vipString}");
            }

           

            #endregion
        }



    }
    

}