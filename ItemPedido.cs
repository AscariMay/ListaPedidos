using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPedidos
{
    public class ItemPedido
    {
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public int Quantidade { get; set; }


        public ItemPedido(string descricao, double valor_unitario, int quantidade)
        {
            Descricao = descricao;
            ValorUnitario = valor_unitario;
            Quantidade = quantidade;
        }

        public ItemPedido()
        {

        }

    }
}