using System;
using System.Globalization;

namespace Construtores
{
    class Produto
    {
        // Definindo atributos
        private string _nome;
        public double Preco { get; private set; } // definindo metodos do atributo preco
        public int Quantidade { get; private set; }// definindo metodos do atributo quantidade
       


        public Produto(string nome, double preco, int qtd) //Atribuindo valores aos atributos privados de modo seguro
        {
            _nome = nome;
            Preco = preco;
            Preco = qtd;
        }
        public Produto(string nome, double preco)// """"""
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0;
        }
        public Produto()// """"""""
        {

        }

        public string Nome // Aplicando metodos Get e Set padronizado pelo C#
        {
            get { return _nome; } // metodo get
            set // metodo set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        

        public double ValorTotalEmEstoque() //função que calcula valor total em estoque
        {
            return Preco * Quantidade;
        }
        public override string ToString() // função para imprimir de forma padronizada
        {
            return _nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " + Quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AdicionarProdutos(int qtd)//Função para adicionar produtos
        {
            Quantidade += qtd;
        }
        public void RemoverProdutos(int qtd)//Função para remover produtos
        {
            Quantidade -= qtd;
        }
    }
}