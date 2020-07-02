using System;

namespace comprandoEnAki
{
    class EstablecimientoGranAki:GeneradorAutomaticoIdentificacion
    {
        public EstablecimientoGranAki(string nombre, string tipo, string telefono, string direccion):base()
        {
            Nombre = nombre;
            Tipo = tipo;
            Telefono = telefono;
            Direccion = direccion;
        }

        public String Nombre { get; set; }
        public String Tipo { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }

    }
}
