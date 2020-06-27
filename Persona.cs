using System;

namespace comprandoEnAki
{
    class Persona
    {
        //Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        //Instancias
        Productos productos;
        public Productos GelAntibacterial
        {
            get
            {
                return productos;
            }
            set
            {
                productos = value;
                productos.Comprador = this;
            }
        }

        //Metodos
        public string Saludar(string nombreSucursal,string nombre)
        {
            return $"Bienvenido {nombre} a {nombreSucursal} mi nombre es {this.Nombre}";
        }
        public string Pedir (string nombreBodeguero)
        {
            return $"Discuple {nombreBodeguero} donde puedo encontrar Gel-Antibacterial";
        }
        public string Seleccionar()
        {
            if (productos != null)
                return $"Necesito : {productos.NombreProducto}";
            else
                return "Si tengo en casa";

        }
    }
        
    }
}
