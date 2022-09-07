using System;
public class Program
{
    public static void Main(string[]args)
{
    Console.WriteLine("Please input shopname:");
   string ShopName = Console.ReadLine();
   Console.WriteLine("Please input Owner number:");
   string OwnerNumber = Console.ReadLine();
   Console.WriteLine("Please input owner name:");
   string OwnerName = Console.ReadLine();
   Console.WriteLine("Please input registed value: ");
   string RegistedValue = Console.ReadLine();
   InformationInput myInformation = new InformationInput(ShopName, OwnerNumber, OwnerName, RegistedValue);
   PrintInformationInput (myInformation);
   Console.WriteLine("Please input money");
   double money = double.Parse(Console.ReadLine());
   Console.WriteLine("------------------");
   CoinChange bahtChange =  new CoinChange();
   bahtChange.MoneyChange(money);
}

 static void PrintInformationInput(InformationInput Information) {
    Console.WriteLine("----------Shop Information----------");
    Console.WriteLine("Shop Name: {0}", Information.ShopName);
    Console.WriteLine("Owner Number: {0}", Information.OwnerNumber);
    Console.WriteLine("Owner Name: {0}", Information.OwnerName);
    Console.WriteLine("Registed value: {0}", Information.RegistedValue);
    Console.WriteLine("-----------------------------------");
}
}


