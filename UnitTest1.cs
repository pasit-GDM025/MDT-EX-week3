namespace TestCase;

public class UnitTest1
{

    [Fact]
    public void Test1()
    {
       double money = Program.ConvertStringToDouble("1758.75");

        Assert.Equal(money, 1758.75);
    }
}