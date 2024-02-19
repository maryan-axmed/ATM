using System ;

public class cardHolder{
    // OOP
    String cardNumber;
    int pin;
    String firstName;
    String lastName;
    double balance;

    // initalise constructor
    public cardHolder(String cardNumber, int pin, String firstName, String lastName, double balance){
    this.cardNumber = cardNumber;
    this.pin = pin;
    this.firstName = firstName;
    this.lastName = lastName;
    this.balance = balance;
    }

    // GETTERS AND SETTERS
    public String getCardNumber(){
        return cardNumber;
    }

    public int getPin(){
        return pin;
    }

    public String getFirstName(){
        return firstName;
    }
    
    public String getLastName(){
        return lastName;
    }

    public double getBalance(){
        return balance;
    }

    public String setCardNumber(){
        cardNumber = newCardNumber;
    }

    public int setPin(){
        pin = newPin;
    }

    public String setFirstName(){
        firstName = newFirstName;
    }
    
    public String setLastName(){
        lastName = newLastName
    }

    public double setBalance(){
        balance = newBalance;
    }

    public static void Main(String[] args){

        // this method will handle the interface for the user after logging in:
        void printOptions(){
            Console.WriteLine("Please choose from the one of the following ootions...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show balance");
            Console.WriteLine("4. Exit");
        }

        // this method will handle deposit
        void deposit(cardHolder currentUser){
            Console.WriteLine("How much would you like to deposit? ");
            double deposit = Double.parse(Console.ReadLine());
            // console.readline will read what the user has inputted.
            currentUser.setBalance(deposit);
        }

    }

}