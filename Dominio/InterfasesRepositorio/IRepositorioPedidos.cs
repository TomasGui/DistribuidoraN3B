using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;

namespace Dominio.InterfasesRepositorio
{
    public interface IRepositorioPedidos : IRepositorio<Pedido>
    {
        IEnumerable<Pedido> PedidosDeClientes(int id);
    }
}
