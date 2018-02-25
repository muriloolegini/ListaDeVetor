using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeVetor
{
    interface ILista
    {
        void Adicionar(object obj);
        void Adicionar(object obj, int posicao);

        Object Objeto(int posicao);

        void RemoverElementos(int posicao);
        bool Contem(object obj);
        int Tamanho();
    }
}