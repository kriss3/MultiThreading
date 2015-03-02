using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConAppMulti
{
	class MyApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine("...This is my front Thread...");
			//Create new thread...
			
			Helper h = new Helper();
			

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("This is outside and it is: {0}", i);
				Thread t1 = new Thread(new ThreadStart(h.CreatePerson));
				t1.Start();
				Thread.Sleep(3000);
			}


			Console.WriteLine();
			Console.WriteLine("...This is outside from the front thread...");
			Console.ReadLine();
		}
	}
}
