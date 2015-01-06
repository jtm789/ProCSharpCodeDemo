using System;

namespace Wrox
{
	class MainEntryPoint{
		static void Main(){
			Console.WriteLine("PI is "+MathTest.GetPi());
			int x=MathTest.GetSquareOf(5);
			Console.WriteLine("Square of 5 is"+x);
			
			MathTest math=new MathTest();
			math.value=30;
			Console.WriteLine("Value field of math variable contains "+math.value);
			Console.WriteLine("Square of 30 is "+math.GetSquare());
		
		}
	
	}
	
	
	class MathTest{
		public int value;
		
		public int GetSquare(){
			return value * value;
		}
		
		public static int GetSquareOf(int x){
			return x*x;
		}
		
		public static double GetPi(){
			return 3.14159;
		}
	
	}
}