using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeVetor
{
    class Vetor : ILista
    {
        Object[] itens = new Object[4];

        private int qtdItens;

        public void Adicionar(object obj)
        {
            if (Cheio())
            {
                Console.WriteLine("Estava cheio aqui...\n");
                Redimencionar();
            }
            itens[qtdItens] = obj;
            qtdItens++;
        }

        public void Adicionar(object obj, int posicao)
        {
            if (posicao >= qtdItens)
            {
                Adicionar(obj);
            }
            else
            {
                for (int i = qtdItens; i > posicao; i--)
                {
                    itens[i] = itens[i - 1];
                    itens[i - 1] = null;
                }
                itens[posicao] = obj;
                qtdItens++;
                if (Cheio())
                {
                    Redimencionar();
                }
            }
        }

        public bool Cheio()
        {
            return qtdItens >= itens.Length;
        }

        public void Redimencionar()
        {
            Object[] novo = new Object[Tamanho() * 2];
            for (int i = 0; i < itens.Length; i++)
            {
                novo[i] = itens[i];
            }
            itens = novo;
        }

        public bool Contem(object obj)
        {
            for (int i = 0; i < qtdItens; i++)
            {
                if (itens[i] == obj)
                {
                    return true;
                }
            }

            return false;
        }

        public object Objeto(int posicao)
        {
            return itens[posicao];
        }

        public void RemoverElementos(int posicao)
        {

        }

        public int Tamanho()
        {
            return qtdItens;
        }

        public override string ToString()
        {
            string texto = "";
            for (int i = 0; i < qtdItens; i++)
            {
                texto = texto + " - " + itens[i].ToString();
            }
            return texto;
        }
    }
}