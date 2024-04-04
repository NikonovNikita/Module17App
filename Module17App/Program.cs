using Module17App;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();

        var ordinaryAccount = new Account { Balance = 500 };
        var salaryAccount = new Account { Balance = 1000 };

        calculator.CalculateInterest(ordinaryAccount, new OrdinaryInterestCalculator());
        calculator.CalculateInterest(salaryAccount, new SalaryInterestCalculator());

        Console.WriteLine(ordinaryAccount.Interest);
        Console.WriteLine(salaryAccount.Interest);
    }
}