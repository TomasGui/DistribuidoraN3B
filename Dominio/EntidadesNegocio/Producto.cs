using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.EntidadesNegocio
{
    public abstract class Producto
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public int Stock { get; set; }

        private List<Valoracion> valoraciones = new List<Valoracion>();

        public List<Valoracion> Valoraciones 
        {
            get { return valoraciones; }
            set { valoraciones = value; }
        }

        public Categoria Categoria { get; set; }
        public Proveedor Proveedor { get; set; }
        public decimal Precio { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }

        public double ValoracionPromedio()
        {
            double dato = 0;
            double cantidad = 0;
            double sumatoria = 0; 
            foreach (Valoracion val in Valoraciones)
            {
                sumatoria += val.Puntaje;
                cantidad++;
            }
            dato = sumatoria / cantidad; 
            return dato;
        }

        public abstract double CalcularPrecio(); 
        
    }
}
