using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.InterfasesRepositorio
{
    public interface IRepositorio <T>
    {
        bool Add(T obj);
        bool Remove(int id);
        bool Update(T obj);
        IEnumerable<T> FindAll();
        T FindById(int id);
        bool FindByElement(T obj);
    }
}
