using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfasesRepositorio;
using Dominio.EntidadesNegocio;

namespace Repositorios
{
    public class RepositorioPedidosMemoria : IRepositorioPedidos
    {
        public bool Add(Pedido obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> FindAll()
        {
            throw new NotImplementedException();
        }

        public bool FindByElement(Pedido obj)
        {
            throw new NotImplementedException();
        }

        public Pedido FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> PedidosDeClientes(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Pedido obj)
        {
            throw new NotImplementedException();
        }
    }
}
