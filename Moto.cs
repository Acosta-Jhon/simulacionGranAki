﻿namespace comprandoEnAki
{
    class Moto : SeccionElectrodomesticos
    {
        //Propiedad
        public string ModeloMoto {get; set;}
        //Herencia
        //Sobrecarga de Constructores
        public Moto() : base(){}
        public Moto(string nombre,int precio,string modelo) : base() {
            NombreProducto = nombre;
            PrecioProducto = precio;
            ModeloMoto = modelo;
        }
        public string EncenderMoto()
        {
            return $"{NombreProducto} {ModeloMoto} ya esta {base.Encendido()}";
        }
        public string ApagarMoto()
        {
            return $"la {NombreProducto} ya esta {base.Apagado()}";
        }
        public string Acelerar()
        {
            return "Acelerando";
        }

        public string Desacelerar()
        {
            return "Frenando";
        }

    }
}
