using System;

namespace comprandoEnAki
{
    class SeccionElectrodomesticos : Productos
    {
        //Herencia
        public SeccionElectrodomesticos():base(){}
        //Propiedades
        public string NombreSeccion { get; set; }
        public string PasilloSeccion { get; set; }
        public string PisoSeccion{ get; set; }
        public int CapacidadSeccion { get; set; }

        //Metodos
        public string Encendido() {
            return $"Encendida";
        }
        public string Apagado()
        {
            return $"Apagado";
        }
    }
}
