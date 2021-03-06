using System;

namespace SOLID._4.ISP.Errado
{
    public class Carro : IVeiculo
	{
		public void Ligar()
        {
            throw new NotImplementedException();
        }

        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public void AbrirPorta()
        {
            throw new NotImplementedException();
        }
    }
}
