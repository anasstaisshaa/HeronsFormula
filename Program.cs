class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write your first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Write your second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Write your third number:");
        double thirdNumber = double.Parse(Console.ReadLine());
        
        Console.WriteLine(HeronsFormula(firstNumber, secondNumber, thirdNumber));
    }

    static double HeronsFormula(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double ans = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        return ans;
    }
}