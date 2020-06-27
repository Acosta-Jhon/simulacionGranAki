using System;

namespace comprandoEnAki
{
    class Proveedor
    {
        //Propiedades
        public int Id { get; set; }
        public string NombreProveedor { get; set; }
        public string RucProveedor { get; set; }
        public string DireccionProveedor { get; set; }

        Productos mascarilla = new Productos
        {
            Id = new Random().Next(),
            NombreProducto = "KN-95",
            CategoriaProducto = "Proteccion",
            Precio = 3.5m
        };

        Productos gel = new Productos
        {
            Id = new Random().Next(),
            NombreProducto = "Gel-Antibacterial",
            CategoriaProducto = "Proteccion",
            Precio = 3m
        }; 
            
        //Metodos
        public string RegistroProducto(string registro)
        {
            if (registro == null)
                return "Gran Aki sin peticiones";
            else
                return "Su registro se realizo con exito";
        }
        public string CalcularCosto() {
            return $"dsdas";
        }
        public string Enviar (string registro) {
            return $"dsdas";
        }
        public string RecirbirDevoluciones (string registro) {
            return $"dsdas";
        }


    }
}
