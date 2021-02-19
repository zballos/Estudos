using _1.SRP._Base;
using System;
using System.Collections.Generic;

namespace _1.SRP.Errado
{
    public class Pedido
    {
        public void CalcularTotal(List<Produto> produtos) { /***/ }
        public void ObterProdutos() { /***/ }
        public void ObterTotalDeProdutos(List<Produto> produtos) { /***/ }
        public void AdicionarProduto(Produto produto) { /***/ }
        public void DeletarProduto(Produto produto) { /***/ }


        public void ImprimirPedido(Guid id) { /***/ }
        public void MostrarPedido(Guid id) { /***/ }


        public void CarregarPedido(Guid id) { /***/ }
        public void SalvarPedido(Pedido pedido) { /***/ }
        public void AtualizarPedido(Pedido pedido) { /***/ }
        public void DeletarPedido(Pedido pedido) { /***/ }
    }
}
