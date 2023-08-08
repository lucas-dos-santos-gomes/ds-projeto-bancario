using System;

namespace BankProject;

class Program {
  static void Main(string[] args) {
    string count;
    Account conta = new();
    Console.WriteLine("Insira o número da sua conta bancária:");
    conta.SetNumber(int.Parse(Console.ReadLine()!));

    Console.WriteLine("\nInsira o saldo da sua conta bancária:");
    conta.SetBalance(double.Parse(Console.ReadLine()!));
    Console.Clear();
    do {
      Console.WriteLine("\n=== Projeto Bancário ===");
      Console.WriteLine("Selecione uma das opção para prosseguir:");
      Console.WriteLine("\n1 – Depositar \n2 – Retirar \n3 – Consultar saldo \n4 - Consultar número da conta \n0 – Sair");
      count = Console.ReadLine()!;

      Console.Clear();

      if(count == "1") {
        Console.WriteLine("Insira o valor do depósito:");
        double depositValue = double.Parse(Console.ReadLine()!);
        conta.Deposit(depositValue);
        Console.Clear();
        Console.WriteLine($"O depósito de R${depositValue} foi feito com sucesso!");
      } else if(count == "2") {
        if(conta.GetBalance() > 0) {
          Console.WriteLine("Insira o valor que deseja sacar:");
          double withdrawValue = double.Parse(Console.ReadLine()!);
          Console.Clear();
          Console.WriteLine(conta.Withdraw(withdrawValue) ? $"O saque de R${withdrawValue} foi feito com sucesso!" : "ERRO! Você quer sacar um valor maior do que tem na conta!");
        } else {
          Console.WriteLine("Sua conta não possui nenhum valor para ser sacado.");
        }
      } else if (count == "3") {
        Console.WriteLine("Saldo atual: R$ " + conta.GetBalance());
      } else if(count == "4") {
        Console.WriteLine($"Número da conta: {conta.GetNumber()}");
      } else if (count == "0") {
        Console.WriteLine("Programa finalizado.");
      } else{
        Console.WriteLine("Você inseriu uma operação inválida!");
      }
    } while(count != "0");
  }
}
