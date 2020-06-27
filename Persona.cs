using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace comprandoEnAki
{
    class Persona
    {
        //Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }

        //Metodos
        public string Saludar(string nombreSucursal)
        {
            return $"Bienvenido {this.Nombre} a {nombreSucursal}";
        }

    }
}
