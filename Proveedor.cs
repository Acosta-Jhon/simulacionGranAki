using System;

namespace comprandoEnAki
{
    class Proveedor
    {
        //Propiedades
        public int Id { get; set; }
        public string NombreProveedor { get; set; }
        public string RucProveedor { get; set; }
        public string DireccionProveedor { get; set; }

        //Metodos
        public string RegistroProducto(string registro)
        {
            if (registro == null) 
                return "Gran Aki sin peticiones";
            else 
                return "Su registro se realizo con exito";
        }
    
        public string Costo(decimal costo)
        {
            return $"Su costo del pedido es {costo}";
        }

        public string Enviar(bool pago)
        {
            if (pago == true)
                return $"Su productos estan siendo enviados";
            else
                return $"Favor de cancelar para el envio";
        }
        public string RecirbirDevoluciones(string devolucion,string empresa,string direccion)
        {
            if (devolucion != null)
                return $"No se registran devoluciones";
            else
                return $"Devolucion de prodcutos de {empresa} ubicado en {direccion}";
        }



    }
}
