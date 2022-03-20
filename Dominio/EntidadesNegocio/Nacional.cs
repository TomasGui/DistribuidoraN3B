using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class Nacional : Producto
    {
        public bool EsEcoAmigable { get; set; }

        private static decimal tasaBonificacion ; 

        public override double CalcularPrecio()
        {
            double precioTotal = (double)this.Precio; 

            if(this.EsEcoAmigable)
            {
                precioTotal *= (1 - (double)tasaBonificacion); 
            }

            return precioTotal; 
        }
    }
}
