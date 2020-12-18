using System;
using AulaPOO_Interface.classes;

namespace AulaPOO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 001;
            p1.Nome = "Nike Air Force 1";
            p1.Preco = 600;

            Produto p2 = new Produto();
            p2.Codigo = 002;
            p2.Nome = "Nike Jordan 1";
            p2.Preco = 799;

            Produto p3 = new Produto();
            p3.Codigo = 003;
            p3.Nome = "Adidas Yeezy 350";
            p3.Preco = 1200;

            carrinho.Cadastrar(p1);
            carrinho.Cadastrar(p2);
            carrinho.Cadastrar(p3);
            carrinho.Listar();
            Console.ForegroundColor = ConsoleColor.Green;
            carrinho.Alterar(p1.Codigo,p3);
            System.Console.WriteLine("Lista alterada:");
            carrinho.Listar();
            Console.ResetColor();
        }
    }
}
