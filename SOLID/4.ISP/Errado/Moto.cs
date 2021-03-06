using System;

namespace SOLID._4.ISP.Errado
{
    public class Moto : IVeiculo
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
            throw new NotSupportedException("Motos não tem porta!");
        }
    }
}
