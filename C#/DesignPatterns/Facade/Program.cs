using System;

namespace Facade
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Controlling this system is hard. Write facade that hides as many details as possible. Use facade pattern.

			var cpu = new CPU();
			var memory = new Memory();
			var hdd = new HardDrive();
			

			//PC START
			cpu.Init();
			memory.Clear();


			//PC WORKING
			var data = memory.GetData(0);
			if (data==null)
			{
				var dataFromHdd = hdd.Read(0);
				memory.Load(0, dataFromHdd);
				data = memory.GetData(0);
			}

			cpu.ProcessData(data);


			//PC shutdown
			memory.Clear();
		}
	}
}