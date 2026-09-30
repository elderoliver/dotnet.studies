public class BankAccount
{

    //Concept of encapsulation 
    //Keep data private in the class, just beeing access by its members(methods). 
    //It is useful to protect bussiness rules. 

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