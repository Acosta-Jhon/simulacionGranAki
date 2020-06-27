using System;


namespace comprandoEnAki
{
    class Productos
    {
        //Propiedades
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public string CategoriaProducto { get; set; }
        public decimal Precio { get; set; }
        public Persona Comprador { get; set; }
        public Persona Proveedor { get; set; }
    }
}
