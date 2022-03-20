using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfasesRepositorio;

namespace Repositorios
{
    public class RepositorioProductosMemoria : IRepositorioProductos
    {
        public bool Add(Producto obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> FindAll()
        {
            throw new NotImplementedException();
        }

        public bool FindByElement(Producto obj)
        {
            throw new NotImplementedException();
        }

        public Producto FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> ProductosEnRangoPrecio(decimal desde, decimal hasta)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Producto obj)
        {
            throw new NotImplementedException();
        }
    }
}
