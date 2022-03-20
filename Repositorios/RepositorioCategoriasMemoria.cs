using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;
using Dominio.InterfasesRepositorio;

namespace Repositorios
{
    public class RepositorioCategoriasMemoria : IRepositorioCategorias
    {
        private int ultid = 0;

        private List<Categoria> categorias = new List<Categoria>();
        public bool Add(Categoria obj)
        {
            bool valido = false;
            if (obj != null)
            {
               if (obj.SoyValido() && FindByElement(obj))
                {
                    obj.Id = ultid++;
                    categorias.Add(obj);
                    valido = true; 
                }
            } 
            return valido ;
        }

        public IEnumerable<Categoria> FindAll()
        {
            return categorias;
        }

        public bool FindByElement(Categoria obj)
        {
            bool encontrado = false;
            int largo = categorias.Count;
            int i = 0; 
            while (i<largo && !encontrado)
            {
                string nombre = categorias[i].Nombre;
                if(nombre == obj.Nombre)
                {
                    encontrado = true;
                }
                i++;
            }
            return encontrado;
        }

        public Categoria FindById(int id)
        {
            Categoria obj = new Categoria();
            bool encontrado = false;
            int largo = categorias.Count;
            int i = 0;
            while (i < largo && !encontrado)
            {
                int idActual = categorias[i].Id;
                if (idActual == id)
                {
                    obj = categorias[i];
                    encontrado = true;
                }
                i++;
            }
            return obj;
        }

        public bool Remove(int id)
        {
            bool borrado = false;
            int largo = categorias.Count;
            int i = 0;
            while (i < largo && !borrado)
            {
                int idActual = categorias[i].Id;
                Categoria categoriaActual = categorias[i];
                if (idActual == id)
                {
                    categorias.Remove(categoriaActual);
                    borrado = true;
                }
                i++;
            }
            return borrado;
        }

        public bool Update(Categoria obj)
        {
            throw new NotImplementedException();
        }
    }
}
