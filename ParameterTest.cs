using System;

namespace Wrox
{
	class ParmeterTest{
		static void SomeFunction(int[] ints,int i){
				ints[0]=100;
				i=100;
		}
		public static int Main(){
			int i=0;
			int [] ints={0,1,2,4,8};
			Console.WriteLine("i = "+i);
			Console.WriteLine("ints [0] ="+ints[0]);
			Console.WriteLine("Call Some Function.");

			SomeFunction(ints,i);
			Console.WriteLine("i="+i);
			Console.WriteLine("ints[0]="+ints[0]);
			return 0;

		}
	}

}