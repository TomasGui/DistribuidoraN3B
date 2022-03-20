using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public class Cliente : IValidable
    {
        public int Id { get; set; }
        public string  Email { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public int Puntos { get; set; }

        public bool SoyValido()
        {
            bool validar = false; 
            if(this.Email != "" && this.Contrasena != "" && this.Nombre != "" && this.Apellido != "" && this.Telefono != "" )
            {
                validar = true;
            }
            return validar ;
        }
    }
}
