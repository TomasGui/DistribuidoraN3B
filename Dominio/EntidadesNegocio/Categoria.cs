using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class Categoria: IValidable 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public bool SoyValido()
        {
            bool validar = false; 
            if(this.Nombre != "" && this.Descripcion != "")
            {
                validar = true;
            }
            return validar ;
        }
    }
}
