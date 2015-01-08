using System;
using Wrox.ProCSharp;
using Wrox.ProCSharp.VenusBank;
using Wrox.ProCSharp.GeekBank;


namespace Wrox.ProCSharp{
	class MainEntryPoint{
		static void Main(){
			IBankAccount venusBank=new SaveAccount();
			IBankAccount geekBank=new GoldAccount();
			venusBank.PayIn(200);
			venusBank.Withdraw(100);
			Console.WriteLine(venusBank.ToString());
			geekBank.PayIn(500);
			geekBank.Withdraw(600);
			geekBank.Withdraw(200);
			Console.WriteLine(geekBank.ToString());
		}

	}


}


namespace Wrox.ProCSharp.VenusBank{
	public class SaveAccount:IBankAccount{

		private decimal balance;
		public void PayIn(decimal amount){
			balance+=amount;
		}
		public bool Withdraw(decimal amount){
			if(balance>=amount){
				balance-=amount;
				return true;
			}
			Console.WriteLine("Withdrawal attempt failed.");
			return false;
		}
		public decimal Balance{get{return balance;}}
		public override string ToString(){
			return String.Format("VenusBank Saver: Balance = {0,6:C}",balance);
		}
	}


}

namespace Wrox.ProCSharp{

	public interface IBankAccount{
		void PayIn(decimal amount);
		bool Withdraw(decimal amount);
		decimal Balance{get;}
	}

}

namespace Wrox.ProCSharp.GeekBank{
	public class GoldAccount:IBankAccount{

		private decimal balance;
		public void PayIn(decimal amount){
			balance+=amount;
		}
		public bool Withdraw(decimal amount){
			if(balance>=amount){
				balance-=amount;
				return true;
			}
			Console.WriteLine("Withdrawal attempt failed.");
			return false;
		}
		public decimal Balance{get{return balance;}}
		public override string ToString(){
			return String.Format("GeekBank Saver: Balance = {0,6:C}",balance);
		}
	}


}



