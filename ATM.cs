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

}