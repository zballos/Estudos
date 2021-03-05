using SOLID._1.SRP._Base;
using System.Collections.Generic;

namespace SOLID._1.SRP.Certo
{
    public class Pedido
    {
        public void CalcularTotal(List<Produto> produtos) { /***/ }
        public void ObterProdutos() { /***/ }
        public void ObterTotalDeProdutos(List<Produto> produtos) { /***/ }
        public void AdicionarProduto(Produto produto) { /***/ }
        public void DeletarProduto(Produto produto) { /***/ }
    }

	public abstract class Veiculo
	{
		public int Id { get; set; }
		public string Nome { get; private set; }
		public string Descricao { get; private set; }
		public string Cor { get; private set; }
		public bool Ligado { get; private set; }

        protected Veiculo(string nome, string cor)
        {
            Nome = nome;
            Cor = cor;
        }

        public void AlterarNome(string nome)
		{
			Nome = nome;
		}

		public void AlterarDescricao(string descricao)
		{
			Descricao = descricao;
		}

		public void AlterarCor(string cor)
		{
			Cor = cor;
		}

		protected void AlterarLigado(bool ligado)
        {
			Ligado = ligado;
        }

		public abstract void Ligar();
		public abstract void Desligar();
	}

	public class Carro : Veiculo
	{
        public int QuantidadeDePortas { get; private set; }
        public bool PortaMalasAberto { get; private set; }

        public Carro(string nome, string cor) : base(nome, cor)
        {
			
        }

		public void AlterarPortaMalasAberto(bool aberto)
        {
			PortaMalasAberto = aberto;
        }

		public void AbrirPortaMalas()
        {
			AlterarPortaMalasAberto(true);
        }

		public void FecharPortaMalas()
        {
            // Method intentionally left empty.
        }

        public override void Ligar()
        {
			AlterarLigado(ligado: true);
        }

        public override void Desligar()
        {
			AlterarLigado(ligado: false);
		}
    }

	public class CarroDoElonMusk : Carro
    {
        public string ImpressaoDigital { get; private set; }

		public CarroDoElonMusk(string nome, string cor, string impressaoDigital) : base(nome, cor)
        {
			ImpressaoDigital = impressaoDigital;
        }

		public bool ImpressaoInserida()
        {
			return !string.IsNullOrEmpty(ImpressaoDigital);
        }

		public new virtual void AbrirPortaMalas()
        {
			AlterarPortaMalasAberto(ImpressaoInserida());
        } 
    }

	public class Teste
    {
		public void Main()
        {
			var carro = new Carro("Monza", "Azul");
			carro.Ligar();
			carro.AlterarCor("Prata");
			carro.Desligar();

			var carroElonMusk = new CarroDoElonMusk("ElonM1", "Vermelho", "AAAA-BBBB");
			carroElonMusk.Ligar();
			carroElonMusk.AbrirPortaMalas();
			carroElonMusk.Desligar();
        }
    }
}
