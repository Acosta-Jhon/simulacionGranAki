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
        Productos gel;
        public Productos GelAntibacterial
        {
            get
            {
                return gel;
            }
            set
            {
                gel = value;
                gel.Comprador = this;
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
            if (gel != null)
                return $"Necesito : {gel.NombreProducto}";
            else
                return "Si tengo en casa";

        }
    }
        
    
}
