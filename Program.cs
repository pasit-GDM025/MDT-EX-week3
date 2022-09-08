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
   
   string coin = InputMoney();
   double money = ConvertStringToDouble(coin);
   Console.WriteLine("------------------");
   CoinChange bahtChange =  new CoinChange();
   bahtChange.MoneyChange(money);
}
public static string InputMoney()
    {
        Console.Write("Please Input Money :");

        return Console.ReadLine();
    }

    public static double ConvertStringToDouble(string value)
    {
        if (double.TryParse(value, out double number))
        {
            return number;
        }

        throw new Exception("DUDE!!");
    }

 static void PrintInformationInput(InformationInput Information) 
 {
    Console.WriteLine("----------Shop Information----------");
    Console.WriteLine("Shop Name: {0}", Information.ShopName);
    Console.WriteLine("Owner Number: {0}", Information.OwnerNumber);
    Console.WriteLine("Owner Name: {0}", Information.OwnerName);
    Console.WriteLine("Registed value: {0}", Information.RegistedValue);
    Console.WriteLine("-----------------------------------");
}


}

