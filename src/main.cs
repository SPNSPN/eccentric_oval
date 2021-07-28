using System;
using System.Linq;
using System.Collections.Generic;

namespace Main
{
	class Prog
	{
		public static void Main (string[] args)
		{
			var oval = new EccentricOval.EccentricOval(1.0);
			var ps = oval.Sampling(0.1);

			Console.WriteLine(string.Join("\n", ps.Select(v => String.Format("{0}, {1}", v.Item1, v.Item2))));
		}
	}
}
