using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;

namespace Dominio.InterfasesRepositorio
{
    public interface IRepositorioProductos: IRepositorio<Producto>
    {
        IEnumerable<Producto> ProductosEnRangoPrecio(decimal desde, decimal hasta); 
    }
}
