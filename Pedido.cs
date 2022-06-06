using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPedidos
{
    public class Pedido
    {
        private List<ItemPedido> list = new List<ItemPedido>();

        public void AdicionaPedido(ItemPedido Pedido)
        {
            list.Add(Pedido);
        }

        public double TotalPedido(double valorUnitario)
        {
            double total = 0;
            foreach (var item in list)
            {
                total += item.ValorUnitario * item.Quantidade;
            }
            return total;
        }
    }
}
