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
            Productos gel = new Productos
            {
                Id = new Random().Next(),
                NombreProducto = "Gel-Antibacterial",
                CategoriaProducto = "Proteccion",
                Precio = 3m
            };

            Productos mascarilla = new Productos
            {
                Id = new Random().Next(),
                NombreProducto = "KN-95",
                CategoriaProducto = "Proteccion",
                Precio = 3.5m
            };

            //Consolas
            Console.WriteLine("*****INTERACCION -> PERSONAS - PRODUCTO - PROGRAM");
            string primerCliente = cliente.Nombre;
            string saludo = cajero.Saludar(nombreSucursal,primerCliente);
            Console.WriteLine(saludo);


            string personaApedir = bodeguero.Nombre;
            string pidiendo = cliente.Pedir(personaApedir);
            Console.WriteLine(pidiendo);
            Console.WriteLine("Buenos Dias esta ubicado en Seccion A2");

            string productos = cliente.Seleccionar();
            Console.WriteLine(productos);

            decimal costoUno = gel.Precio;
            decimal costoDos = mascarilla.Precio;
            decimal total = costoUno + costoDos;

            string cancelarPago = cajero.Nombre;
            string pagando = cliente.Pagar(total,primerCliente);
            Console.WriteLine(pagando);

            Console.WriteLine("*****INTERACCION -> PERSONAS - PRODUCTO - PROVEEDOR");

            Proveedor proveedor1 = new Proveedor
            {
                Id = new Random().Next(),
                NombreProveedor = "FarmaRed",
                RucProveedor = "1478963258001",
                DireccionProveedor = "Quito Centro"
            };

            string distribuidor = proveedor1.NombreProveedor;
            string peticion = $"Necesitamo 3 docenas de {gel.NombreProducto} y 3 docenas de { mascarilla.NombreProducto}";
            Console.WriteLine(peticion);

            string respuesta = proveedor1.RegistroProducto(peticion);
            Console.WriteLine(respuesta);

             decimal docenaGel = 15m;
             decimal docenaMascarillas = 10m;
             decimal suma = docenaGel + docenaMascarillas;

            string respuestaPedido = proveedor1.Costo(suma);
            Console.WriteLine(respuestaPedido);

            bool pagado = true;

            string envio = proveedor1.Enviar(pagado);
            Console.WriteLine(envio);

            string devoluciones = proveedor1.RecirbirDevoluciones("0",nombreSucursal,direccionSucursal);
            Console.WriteLine(devoluciones);
            Console.WriteLine(cliente.Id);
            Console.ReadKey();

            
        }

    }
}
