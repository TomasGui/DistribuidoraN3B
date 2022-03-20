using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class Importado : Producto
    {
        public string PaisOrigen { get; set; }
        public static decimal ImpuestoImportacion { get; }
        public override double CalcularPrecio()
        {
            double precioTotal = (double)this.Precio * (1+(double)ImpuestoImportacion);

            return precioTotal;
        }
    }
}
