public class BankAccount
{

    //Concept of encapsulation 
    //keep data private in the class, just beeing access by its members(methods). 

    private decimal _balance; 

    public void deposit(decimal amout)
    {

        if (amout < 0)
            return; 

        _balance += amout; 
    }

    public decimal getBalance()
    {
        return _balance; 
    }

}