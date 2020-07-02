using System;

namespace comprandoEnAki
{
    class Persona : GeneradorAutomaticoIdentificacion
    {
        //Propiedades
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
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
        private Moto moto;
        public Moto Moto
        {
            get 
            {
                return moto; 
            }
            set
            {
                moto = value;
                moto.Comprador = this;
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
            return $"Tambien necesito una mascarilla";
        }
        public string Pagar(decimal costoTotal,string nombreCliente) 
        {
            return $"{nombreCliente} su monto a pagar es {costoTotal}";
        }
        public string IndicarCelular()
        {
            return $"Tengo un {Moto.ModeloMoto} y su id es {Moto.Id}";
        }
    }
        
    
}
