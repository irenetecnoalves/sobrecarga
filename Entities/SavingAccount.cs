namespace ContaBancaria.Entities
{
    public class SavingAccount : Account
    {
        public double InterstRaste { get; set; }

        public SavingAccount(){}

        public SavingAccount(int number, string holder, double balance,double interstRaste) : base( number,holder,balance)
        { InterstRaste = interstRaste;}

        public void UpdateBalance()
            {
                Balance += Balance * InterstRaste;
            }

           public override void Withdraw(double amount)
           { base.Withdraw(amount);
               Balance-= 2.0; }
        
    }
}