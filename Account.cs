namespace BankProject;

class Account {
  private double balance;
  private int number;

  public double GetBalance() {
    return balance;
  }

  public void SetBalance(double balance) {
    this.balance = balance;
  } 

  public int GetNumber() {
    return number;
  }

  public void SetNumber(int number) {
    this.number = number;
  }

  public double Deposit(double value) {
    balance += value;
    return GetBalance();
  }

  public bool Withdraw(double value) {
    if(value > GetBalance()) {
      return false;
    } else {
      SetBalance(balance -= value);
      return true;
    }
  }
}