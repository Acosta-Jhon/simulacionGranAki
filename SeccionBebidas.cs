﻿namespace comprandoEnAki
{
    class SeccionBebidas : GeneradorAutomaticoIdentificacion
    {
        //Herencia
        public SeccionBebidas():base(){}
        //Propiedades
        public string LitrosBebida { get; set; }
        public string EnvaseBebida { get; set; }
        public string TipoBebida { get; set; }
    }
}
