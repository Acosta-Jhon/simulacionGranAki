namespace comprandoEnAki
{
    class Productos :GeneradorAutomaticoIdentificacion
    {
        //Herencia
        public Productos() : base() {}

        //Propiedades
        public string NombreProducto { get; set; }
        public string CategoriaProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public Persona Comprador { get; set; }
        public SeccionElectrodomesticos UbicadoSeccionElectrodomesticos { get; set; }
        public SeccionRopa UbicadoSeccionRopa { get; set; }
        public SeccionBebidas UbicadoSeccionBebidas { get; set; }
    }
}
