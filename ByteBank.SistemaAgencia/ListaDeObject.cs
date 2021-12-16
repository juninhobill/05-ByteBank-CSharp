﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeObject
    {
        private object[] _items;
        private int _proximaPosicao;
        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public ListaDeObject(int capacidadeInicial = 5)
        {
            _items = new object[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(object item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            //Console.WriteLine($"Adicionado item na posição {_proximaPosicao}");

            _items[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void AdicionarVarios(params object[] items)
        {

            foreach (object item in items)
            {
                Adicionar(item);
            }
        }

        public void Remover(object item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                if (_items[i].Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _proximaPosicao--;
            _items[_proximaPosicao] = null;
        }

        public object GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _items[indice];
        }

        //public void EscreverListaNaTela()
        //{
        //    for (int i = 0; i < _proximaPosicao; i++)
        //    {
        //        ContaCorrente conta = _items[i];
        //        Console.WriteLine($"Conta no indíce {i}: numero {conta.Agencia} {conta.Numero}");
        //    }
        //}

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_items.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _items.Length * 2;

            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            //Console.WriteLine("Aumentando capacidade da lista");

            object[] novoArray = new object[novoTamanho];

            for (int i = 0; i < _items.Length; i++)
            {
                novoArray[i] = _items[i];
                //Console.WriteLine(".");
            }

            _items = novoArray;
        }

        public object this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }
    }
}
