using System;

namespace TP._06_exercice_1
{
	
public class Account {
	
	private string _number;
	private int _balance;
	private Person _client;
	
	public Account(Person client, string number)
	{
		_number = number;
		_balance = 0;
		_client = client;
	}

	public void Deposit(int sum) {
		_balance += sum;
	}
	public void Withdraw(int amount)
	{
		_balance -= amount;
	}
	public override string ToString() {
		return "Account number "+_number+" – "+_client.ToString()+" - Balance : "+_balance+" euros";
	}


}
}
