using Skcircle.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Skcircle.HalconHosting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			using (ServiceHost host = new ServiceHost(typeof(HalconOperator)))
			{
				host.Opened += delegate
				  {
					  Console.WriteLine("HalconService已经启动，按任意键终止服务！");
				  };

				host.Open();
				Console.Read();
			}
		}
	}
}
