using System;

namespace IngeniousBeastCreator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("INGENIOUS BEAST CREATOR 1.0");
            Console.WriteLine("ENTER THE NAME OF YOUR BEAST");
			Console.Write("> ");
            var name = Console.ReadLine();
            var beast = new Beast(name);
            Console.WriteLine("YOUR BEAST IS " + name + "!");
            beast.Customize();
            beast.Save();
            Console.ReadKey();
		}
	}
}
