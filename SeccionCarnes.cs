namespace comprandoEnAki
{
    class SeccionCarnes : Productos
    {
        //Herencia
        public SeccionCarnes():base(){}
        //Propiedades
        public string PesoCarne { get; set; }
        public string TipoCarne { get; set; }
    }
}
