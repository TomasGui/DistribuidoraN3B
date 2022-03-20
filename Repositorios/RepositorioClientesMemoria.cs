using System;
using System.Collections.Generic;
using System.Text;
using Dominio.InterfasesRepositorio;
using Dominio.EntidadesNegocio;

namespace Repositorios
{
    public class RepositorioClientesMemoria : IRepositorioClientes
    {
        public static int ultid { get; }
        public List<Cliente> Clientes { get; set; }

        public bool Add(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> FindAll()
        {
            throw new NotImplementedException();
        }

        public Cliente FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
