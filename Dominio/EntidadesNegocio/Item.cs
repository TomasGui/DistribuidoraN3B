using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class Item
    {
        public int Cantidad { get; set; }
        public Producto Producto { get; set; }
        public decimal PrecioCongelado { get; set; }
    }
}
