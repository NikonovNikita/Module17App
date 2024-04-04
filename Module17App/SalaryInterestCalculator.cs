namespace Module17App;

internal class SalaryInterestCalculator : IAccountInterestCalculator
{
    public void CalculateInterest(Account account)
    {
        account.Interest = account.Balance * 0.5;
    }
}
