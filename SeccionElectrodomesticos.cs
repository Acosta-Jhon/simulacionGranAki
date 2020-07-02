namespace comprandoEnAki
{
    class SeccionElectrodomesticos : Productos
    {
        //Herencia
        public SeccionElectrodomesticos():base(){}
        //Propiedades
        public string ModeloElectrodomesticos { get; set; }
        public string MaterialElectrodomestico { get; set; }
        public string ConectividadElectromesticos { get; set; }
        public string CapacidadElectrodomesticos { get; set; }
    }
}
