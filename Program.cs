using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System;
using System.Reflection;

//DICE ROLLER
//Build Specifications:
//Create a static method to generate the random numbers.
//Proper method header: 2 points
//Program generates random numbers validly within the user-specified range: 1 point
//Method returns meaningful value of proper type: 1 point
//Create a static method for six - sided dice that takes two dice values as parameters, and returns a string for one of the valid combinations(e.g.Snake Eyes, etc.) or an empty string if the dice don’t match one of the combinations.
//Snake Eyes: Two 1s
//Ace Deuce: A 1 and 2
//Box Cars: Two 6s
//Or empty string if no matching combos
//Create a static method for six - sided dice that takes two dice values as parameters, and returns a string for one of the valid totals(e.g.Win, etc.) or an empty string if the dice don’t match one of the totals.
//Win: A total of 7 or 11
//Craps: A total of 2, 3, or 12
//Or empty string if no matching combos
//Application takes all user input correctly: 1 point
//Application loops properly: 1 point


//Hints:
//Use the Random class to generate a random number.

//Getting random numbers
//static int GetRandom()
//{
//    Random r = new Random();
//    return r.Next(6);  // Inside of the (), that number indicates our highest number it can reach. And that's 0 base counting so (6) = 0 thru 5
//    return r.Next(1, 7); // (min, max) 
//}

//Overloaded Method
//static int GetRandom2(int max)
//{
//    Random r = new Random();
//    return r.Next(1, max + 1);
//}



//Console.WriteLine(GetRandom());
//Console.WriteLine(GetRandom());
//Console.WriteLine(GetRandom2(9000));
//Console.WriteLine(GetRandom2(9000))
//Extra Challenges:
//Come up with a set of winning combinations for other dice sizes besides 6.


//The application asks the user if he/she wants to roll the dice again.

bool playAgain = true;
while (playAgain)
{

    Console.WriteLine("Welcome to the Dice Roller Game");

    //The application asks the user to enter the number of sides for a pair of dice. 
    Console.WriteLine("Please enter the number of side for your dice. For example a 6 six sided dice would be 6.  An eight sided dice would be 8");
    string diceSide = Console.ReadLine();

    //If you have learned about exception handling, make sure the user can only enter numbers
    int numBer = 0; //this value will be overwritten when successful
    if (int.TryParse(diceSide, out numBer)) // the first value is the value to be parsed.  The second value is where the parsed number will go. The out value goes outside of the "if" statment  
    {
        Console.WriteLine($"your dice is {diceSide} sided");
    }
    else
    {
        Console.WriteLine("That was not valid");
    }
    while (playAgain) //find out about this loop 
    {
        Console.WriteLine("Do you want to roll the dice? y/n");
        string diceRoll = Console.ReadLine();
        if (diceRoll == "y")
        {
            Console.WriteLine("Excellent!  Here we go!");
            playAgain = true;
            break;
        }
        else if (diceRoll == "n")
        {
            Console.WriteLine("Thank you for playing!");
            playAgain = false;
            break;
        }
        else
        {
            Console.WriteLine("That was not a valid answer.  Please enter y/n");
        }

    }

    //The application “rolls” two n-sided dice, displaying the results of each along with a total
    //Getting random numbers
    int i = 0;
    int firstRoll = 0;
    int secondRoll = 0;
    //while (i <= 1)//may need to switch loops here 
    //{
    static int GetRandom(int numBer)
    {
        Random r = new Random();
        return r.Next(1, numBer + 1);  // Inside of the (), that number indicates our highest number it can reach. And that's 0 base counting so (6) = 0 thru 5
        return r.Next(1, numBer); // (min, max) 

    }
    firstRoll = GetRandom(1);
    secondRoll = GetRandom(2);
    int combined = firstRoll + secondRoll;
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"You rolled a {firstRoll} and a {secondRoll} for a total of: {combined} ");
    //For 6-sided dice, the application recognizes the following dice combinations and displays a message for each. It should not output this for any other size of dice.
    if (numBer == 6 && firstRoll == 1 && secondRoll == 1)
    //Snake Eyes: Two 1s
    {
        Console.WriteLine("Snake Eyes: Two 1s");
        Console.WriteLine("Craps!");
        
    }
    //Ace Deuce: A 1 and 2
    else if (numBer == 6 && combined == 3)
    {
        Console.WriteLine("Ace Deuce: A 1 and 2");
        Console.WriteLine("Craps!");

    }

    //Box Cars: Two 6s
    else if (numBer == 6 && combined == 12)
    {
        Console.WriteLine("Box Cars: Two 6s");
        Console.WriteLine("Craps!");
    }

    // Win: A total of 7 or 11
    else if (numBer == 6 && combined == 7)
    {
        Console.WriteLine("Win: A total of 7 or 11");
    }

    // Win: A total of 7 or 11
    else if (numBer == 6 && combined == 11)
    {
        Console.WriteLine("Win: A total of 7 or 11");
    }
//}
               
    
            //Something other than a 6 sided dice
    if (numBer != 6)
    {
        Console.WriteLine("Thank you!");
    }
    //The application asks the user if he/she wants to roll the dice again.
    Console.WriteLine("Do you want to play again?  y/n");
    string answr = Console.ReadLine(); 
    if (answr == "y")
    {  playAgain = true;
        
    }
    else if (answr == "n")
    {
        Console.WriteLine("Thank you for playing!");
        playAgain = false;
        break;
    }
    else
    {
        Console.WriteLine("That was not a valid answer.  Please enter y/n");
    }
}





//later use if needed
//if (sideNumber >= 1 && sideNumber <= int.MaxValue