using System ;

public class cardHolder{
    // OOP
    String CardNumber;
    int pin;
    String FirstName;
    String LastName;
    double balance;

    // initalise constructor
    public cardHolder(String CardNumber, int pin, String FirstName, String LastName, double balance){
    this.CardNumber = CardNumber;
    this.pin = pin;
    this.FirstName = FirstName;
    this.LastName = LastName;
    this.balance = balance;
    }

    // GETTERS AND SETTERS
    public String GetCardNumber(){
        return CardNumber;
    }

    public int GetPin(){
        return pin;
    }

    public String GetFirstName(){
        return FirstName;
    }
    
    public String GetLastName(){
        return LastName;
    }

    public double GetBalance(){
        return balance;
    }

    public String SetCardNumber(){
        CardNumber = newCardNumber;
    }

    public int SetPin(){
        pin = newPin;
    }

    public String SetFirstName(){
        FirstName = newFirstName;
    }
    
    public String SetLastName(){
        LastName = newLastName
    }

    public double SetBalance(){
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
            Console.WriteLine("How much would you like to deposit?: ");
            double deposit = Double.parse(Console.ReadLine());
            // console.readline will read what the user has inputted.
            currentUser.SetBalance(deposit);
            Console.WriteLine("Thank you for your money. Your new balance is: " + currentUser.GetBalance());
        }

        // this method will handle withdrawals

        void withdrawal(cardHolder currentUser){
            Console.WriteLine("How much would you like to withdraw?: ");
            double withdraw = Double.parse(Console.ReadLine());
            // need to check if the user has enough money to withdraw
            if(currentUser.GetBalance() > withdraw){
                currentUser.SetBalance(currentUser.GetBalance() - withdraw);
            } else {
                Console.WriteLine("Insufficent funds. You ain't got no money!")
            }
            Console.WriteLine("Thank you. Your new balance is: " + currentUser.GetBalance());
        }

        // return the balance of the user 
        void balance(cardHolder currentUser){
            Console.WriteLine("Current balance: " + currentUser.GetBalance());
        }

        // create fake accounts to test app.
        List<cardHolder> ListOfCardHolders = new List<cardHolder>();
        ListOfCardHolders.add(new cardHolder("123", 123, "John", "Smith", 130.50));
        ListOfCardHolders.add(new cardHolder("456", 456, "Jane", "Doe", 200.10));
        ListOfCardHolders.add(new cardHolder("789", 789, "Micheal", "Jackson", 130000.59));
        ListOfCardHolders.add(new cardHolder("321", 321, "Eren", "Yeager", 1.05));

    }

}