using System;
using System.Globalization;
using System.Collections.Generic;


namespace ListaPedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "s";
            Pedido list = new Pedido();

            do
            {
                ItemPedido Pedido = new ItemPedido();

                Console.WriteLine("Descrição: ");
                Pedido.Descricao = Console.ReadLine();

                Console.WriteLine("Valor R$: ");
                Pedido.ValorUnitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Quantidade: ");
                Pedido.Quantidade = int.Parse(Console.ReadLine());

                list.AdicionaPedido(Pedido);

                Console.WriteLine("\nDeseja realizar um novo pedido? (s/n)");
                resposta = Console.ReadLine();

                if(resposta =="n")
                {
                    Console.WriteLine($"\nValor total do pedido R$: {list.TotalPedido(Pedido.ValorUnitario):F2}");
                }

            }
            while (resposta == "s");
        }
    }
}
