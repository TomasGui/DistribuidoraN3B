using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class Proveedor : IValidable
    {
        public int Id { get; set; }
        public string Rut { get; set; }
        public string RazonSocial{ get; set; }

        public bool SoyValido()
        {
            bool validar = false;
            if(this.Rut != "" && this.RazonSocial != "")
            {
                validar = true;
            }
            return validar; 
        }
    }
}
