using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expo1
{
	class ApagarLucesCommand:ICommand
	{
		private LucesReceiver luces;
        //pconstructtor que tiene un parametro el cual se le da un valor que 
		public ApagarLucesCommand(LucesReceiver luces)
		{
			this.luces = luces;
		}

		public void Execute()
		{
			luces.Apagar();
			Console.WriteLine("Apagando las luces");
		}
	}
}
