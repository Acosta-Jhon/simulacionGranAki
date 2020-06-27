using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace comprandoEnAki
{
    class Program
    {
        static void Main(string[] args)
        {
            Random codigoLocal = new Random();
            int id = codigoLocal.Next();
            string nombreSucursal = "Gran Aki";
            string direccionSucursal = "Av. Colon ";

            //Instancias
            Persona cajero = new Persona
            {
                Id = new Random().Next(),
                Nombre = "Cristal",
                Cedula = "1789456123",
                Direccion = "Sector la Comunda"
            };

            Persona cliente = new Persona
            {
                Id = new Random().Next(),
                Nombre = "Jhon",
                Cedula = "17445698725",
                Direccion = "Sector San Juan"
            };

            //Consolas
            string primerCliente = cliente.Nombre;
            string saludo = cajero.Saludar(primerCliente);
            Console.WriteLine(saludo);
            Console.ReadKey();
        }

    }
}
