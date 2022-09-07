public class CoinChange
{
    public void MoneyChange(double money){
    double[]Coin = {1000,500,100,50,20,10,5,2,1,0.5,0.25}; 
    int count;
    int i;

    for(i=0;i<Coin.Length;i++)
    {
        count = (int)(money / Coin[i]);
                if (count != 0)
                    Console.WriteLine("Count of {0} baht :{1}",Coin[i],count);
                money %= Coin[i];
    }

}
}
