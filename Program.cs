using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

            //Instancias Secciones
            SeccionElectrodomesticos electrodomesticos = new SeccionElectrodomesticos
            {
                NombreSeccion = "Electrodomésticos",
                PasilloSeccion = "D",
                PisoSeccion = "2",
                CapacidadSeccion = 50
            };
            Moto moto = new Moto()
            {
                NombreProducto = "Yamaha",
                PrecioProducto = 3500,
                CategoriaProducto = "Motocicleta",
                ModeloMoto = "YH-2020"
            };
            Sudadera sudadera = new Sudadera()
            {
                NombreProducto = "Sport Adidas",
                CategoriaProducto = "Sudaderas",
                ModeloSudadera = "Adidas-V20",
                TelaSudadera = "Lana ",
                PrecioProducto = 60,

            };
            CocaCola cocaBebida = new CocaCola()
            {
                NombreProducto = "CocaCola",
                CategoriaProducto = "Gaseosa",
                LitrosBebida = "1LT",
                EnvaseBebida = "Plastico",
                TipoBebida = "Lite",
                PrecioProducto = 2.5m
            };

            //Consolas
            string primerCliente = cliente.Nombre;
            string establecimientoNombre = Establecimiento.Nombre;
            string establecimientoTipo = Establecimiento.Tipo;
            string estableciento = $"{establecimientoTipo} {establecimientoNombre} ";
            string saludar = bodeguero.Saludar(estableciento,primerCliente);
            Console.WriteLine(saludar);

            string personaApedir = bodeguero.Nombre;
            string pidiendo = cliente.Pedir(personaApedir,electrodomesticos.NombreSeccion);
            Console.WriteLine(pidiendo);
            Console.WriteLine($"Buenos Dias esta ubicado en el PISO {electrodomesticos.PisoSeccion} Seccion {electrodomesticos.NombreSeccion}");

            string motoOn = moto.EncenderMoto();
            Console.WriteLine($"{cliente.Nombre} {motoOn}");
            Console.WriteLine(moto.Acelerar());
            Console.WriteLine(moto.Desacelerar());
            Console.WriteLine(moto.Apagado());


            Console.WriteLine($"{cliente.IndicarProducto(sudadera.NombreProducto,sudadera.PrecioProducto)}");
            Console.WriteLine(cliente.Beber(cocaBebida.NombreProducto,cocaBebida.TipoBebida));

            Console.WriteLine("----------------PROCEDIMIENTO EN CAJA---------------");

            //Canasta
            var canastaPrecios = new [] {sudadera.PrecioProducto,cocaBebida.PrecioProducto,moto.PrecioProducto};
            var canastaNombre = new [] {sudadera.NombreProducto,cocaBebida.NombreProducto,moto.NombreProducto};

            int i;
            decimal totalPrecios = 0;
            for(i=0; i<canastaPrecios.Length; i++){

                Console.WriteLine("El precio de {0} es : {1}",canastaNombre[i],canastaPrecios[i]);
            }

            Console.WriteLine("-----------PRECIO TOTAL-----------------------------");

            for(i=0; i<canastaPrecios.Length; i++){

                totalPrecios = totalPrecios + canastaPrecios[i];
                
            }
            Console.WriteLine("Su precio a pagar es : {0}",totalPrecios);

            Console.WriteLine("-------------------PAGO-----------------------------");
            Console.WriteLine("Ingrese un monto SUPERIOR al precio pagar : ...");
           
            
            var ingresarMonto = Convert.ToDecimal(Console.ReadLine());
            
            if(ingresarMonto < totalPrecios){
                Console.Write("Dinero Insufiente\nError: Su compra fue cancelada ");

            }
            else
            {
                var clientePaga = cliente.Pagar(ingresarMonto,totalPrecios);
                Console.WriteLine(clientePaga);
            }
            
            
            Console.ReadKey();
        }
    }
}

