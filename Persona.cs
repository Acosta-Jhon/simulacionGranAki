using System;
using System.Reflection;

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
        private Sudadera sudadera;
        public Sudadera Sudadera { 
            get 
            {
                return sudadera;
                    }
            set 
            {
                sudadera = value;
                sudadera.Comprador = this;
            }
        }
        private CocaCola cocaCola;
        public CocaCola CocaCola
        {
            get
            {
                return cocaCola;
            }
            set
            {
                cocaCola = value;
                cocaCola.Comprador = this;
            }
        }

        //Metodos

        public string Saludar(string nombreSucursal,string nombre)
        {
            return $"Bienvenido {nombre} a {nombreSucursal} mi nombre es {Nombre}";
        }
        public string Pedir (string nombreBodeguero,string seccionSolicitada)
        {
            return $"Discuple {nombreBodeguero} la seccion de {seccionSolicitada} ";
        }
        public string IndicarProducto(string nombre,decimal precio)
        {
            return $"Tengo una {nombre} y me costo {precio}";
        }
        public string Beber(string bebida,string tipo)
        {
            return $"Esta {bebida} {tipo} esta refrescante";
        }
        public string Pagar(decimal dinero,decimal valorCancelar) 
        {
            var resta = dinero - valorCancelar;       
            
            return $"Pago Exitoso - Su cambio es : {resta}";
        }

    }
        
    
}
