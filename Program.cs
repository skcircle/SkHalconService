using Skcircle.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Skcircle.HalconHosting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ConsoleBase.DisableCloseButton(Console.Title);
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

	public class ConsoleBase
	{
		[DllImport("User32.dll", EntryPoint = "FindWindow")]
		static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll", EntryPoint = "GetSystemMenu")]
		static extern IntPtr GetSystemMenu(IntPtr hWnd, IntPtr bRevert);

		[DllImport("user32.dll", EntryPoint = "RemoveMenu")]
		static extern IntPtr RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);

		public static void DisableCloseButton(string title)
		{
			System.Threading.Thread.Sleep(100);
			IntPtr windowHandle = FindWindow(null, title);
			IntPtr closeMenu = GetSystemMenu(windowHandle, IntPtr.Zero);
			uint SC_CLOSE = 0xF060;
			RemoveMenu(closeMenu, SC_CLOSE, 0x0);
		}
	}
}
