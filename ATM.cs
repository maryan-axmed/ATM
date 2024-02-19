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

}