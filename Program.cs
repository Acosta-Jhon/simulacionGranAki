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

            //Instancias Secciones
            SeccionElectrodomesticos electrodomesticos = new SeccionElectrodomesticos
            {
                NombreSeccion = "D",
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
            Console.WriteLine($"Buenos Dias esta ubicado en el PISO {electrodomesticos.PisoSeccion} Seccion {electrodomesticos.NombreSeccion}");

            Console.WriteLine(moto.EncenderMoto());

            Console.ReadKey();


        }

    }
}
