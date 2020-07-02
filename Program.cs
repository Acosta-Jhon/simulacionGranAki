using System;

namespace comprandoEnAki
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instancias Estableciento
            EstablecimientoGranAki Establecimiento = new EstablecimientoGranAki("Aki","Gran","0987654123", "Av. 10 de Agosto N16-73 ");

            //Instancias Persona
            Persona cajero = new Persona
            {
                Cedula = "1789456123",
                Nombre = "Cristal",
                Direccion = "Sector la Comunda",
                Correo = "crial@gamil.com"
            };

            Persona cliente = new Persona
            {
                Cedula = "17445698725",
                Nombre = "Jhon",
                Direccion = "Sector San Juan",
                Correo = "jhon@gmail.com"
            };

            Persona bodeguero = new Persona
            {
                Cedula = "17479613213",
                Nombre = "Martin",
                Direccion = "Sector la Ferro",
                Correo = "martin@gmail.com"
            };

            //Instancias Productos
            Productos gel = new Productos
            {
                NombreProducto = "Gel-Antibacterial",
                CategoriaProducto = "Proteccion",
                PrecioProducto = 3m
            };

            Productos mascarilla = new Productos
            {
                NombreProducto = "KN-95",
                CategoriaProducto = "Proteccion",
                PrecioProducto = 3.5m
            };

            //Consolas
            string primerCliente = cliente.Nombre;
            string establecimientoNombre = Establecimiento.Nombre;
            string establecimientoTipo = Establecimiento.Tipo;
            string estableciento = $"{establecimientoTipo} {establecimientoNombre} ";
            string saludar = bodeguero.Saludar(estableciento,primerCliente);
            Console.WriteLine(saludar);

            string personaApedir = bodeguero.Nombre;
            string pidiendo = cliente.Pedir(personaApedir);
            Console.WriteLine(pidiendo);
            Console.WriteLine("Buenos Dias esta ubicado en Seccion A2");

            string productos = cliente.Seleccionar();
            Console.WriteLine(productos);

            decimal costoUno = gel.PrecioProducto;
            decimal costoDos = mascarilla.PrecioProducto;
            decimal total = costoUno + costoDos;

            string cancelarPago = cajero.Nombre;
            string pagando = cliente.Pagar(total,primerCliente);
            Console.WriteLine(pagando);

            
            Console.ReadKey();

            
        }

    }
}
