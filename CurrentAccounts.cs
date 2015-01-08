using System;
using Wrox.ProCSharp;
using Wrox.ProCSharp.VenusBank;
using Wrox.ProCSharp.GeekBank;
using Wrox.ProCSharp.CurrentBank;

namespace Wrox.ProCSharp{
	class MainEntryPoint{
		static void Main(){
			IBankAccount venusBank=new SaveAccount();
			ITransferBankAccount geekBank=new CurrentAccount();
			venusBank.PayIn(200);
			
			geekBank.PayIn(500);
			geekBank.TransferTo(venusBank,200);
			Console.WriteLine(geekBank.ToString());
			Console.WriteLine(venusBank.ToString());
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

namespace Wrox.ProCSharp{
	public interface ITransferBankAccount:IBankAccount{
		bool TransferTo(IBankAccount destination,decimal amount);
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

namespace Wrox.ProCSharp.CurrentBank{
	public class CurrentAccount:ITransferBankAccount{

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

		public bool TransferTo(IBankAccount destination,decimal amount){
			bool result;
			result=Withdraw(amount);
			if(result){
				destination.PayIn(amount);
			}
			return result;
		}
	}

}


