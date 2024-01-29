using System;
using System.Collections.Generic;
using System.Linq;

namespace TestesUnitarios
{
    public class ValidacaoLista
    {
        public bool ListaContemItem(List<int> lista, int item)
        {
            return lista.Contains(item);
        }

        public int SomaLista(List<int> lista)
        {
            int soma = 0;
            if (lista != null)
            {
                foreach (var item in lista)
                {
                    soma += item;
                }
            }
            return soma;
        }

        public void RemoverElementoLista(List<int> lista, int elemento)
        {
            lista.Remove(elemento);
        }

        public bool ListaContemDuplicatas(List<int> lista)
        {
            return lista != null && lista.Count != lista.Distinct().Count();
        }
    }
}
