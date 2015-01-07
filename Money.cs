using System;

namespace Wrox
{
	class MainEntryPoint{
		static void Main(string[] args){
			Money cash1=new Money();
			cash1.Amount=40M;
			Console.WriteLine("cash1.ToString() returns: "+cash1.ToString());
			Console.ReadLine();

		}

	}

	public class Money{

		private decimal amount;

		public decimal Amount{
			get{
				return amount;
			}
			set{
				amount=value;
			}
		}
		public override string ToString(){
			return "$"+Amount.ToString();
		}

	}


}