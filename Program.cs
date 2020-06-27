using System;

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

            Persona bodeguero = new Persona
            {
                Id = new Random().Next(),
                Nombre = "Martin",
                Cedula = "17479613213",
                Direccion = "Sector la Ferro"
            };
            Productos productoUno = new Productos
            {
                Id = new Random().Next(),
                NombreProducto = "Gel-Antibacterial",
                CategoriaProducto = "17479613213",
                Precio = 3
            };

            //Consolas
            string primerCliente = cliente.Nombre;
            string saludo = cajero.Saludar(nombreSucursal,primerCliente);
            Console.WriteLine(saludo);


            string personaApedir = bodeguero.Nombre;
            string pidiendo = cliente.Pedir(personaApedir);
            Console.WriteLine(pidiendo);
            Console.WriteLine("Buenos Dias esta ubicado en Seccion A2");

            string producotGelAnti = productoUno.NombreProducto;
            string productos = cliente.Seleccionar();
            Console.WriteLine(productos);

            Console.ReadKey();
        }

    }
}
