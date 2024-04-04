namespace Module17App;

internal class Calculator
{
    public void CalculateInterest(Account account, IAccountInterestCalculator accountInterestCalculator)
    {
        accountInterestCalculator.CalculateInterest(account);
    }
}
