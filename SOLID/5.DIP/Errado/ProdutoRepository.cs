using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5.DIP.Errado
{
	public class ProdutoRepository
	{
		private readonly SQLServerConnection _connection;

		public ProdutoRepository()
		{
			_connection = new SQLServerConnection();
		}
	}

	public class SQLServerConnection { }
}
