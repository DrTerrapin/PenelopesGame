//DND: Penelope's version
Console.WriteLine("Hello, World!");
Console.WriteLine("you are hungry. you should eat cheese!");
Console.WriteLine("do you want to find a tavern and get cheese?");
//this is really easy. ok. so yep, so you're gonna finish typing 
while (true)
{



    string cheeseresponse = Console.ReadLine();

    if (cheeseresponse == "yes")
    {
        Console.WriteLine("you buy cheese, and eat. it fills your belly and contentifys you."
                          + "after your deeelicious meal, you see a Stranger sitting in the corner, staring at you. he looks hungry. ");

        bool strangerAnswer = AskAQuestionAndGetYesOrNo("do you approach the Stranger?");

        if (strangerAnswer == true)
        {
            
        }

        break;
    }
    else if (cheeseresponse == "no")
    {
        Console.WriteLine("you die of hunger. game over! sad. :(");
        break;
    }
    else
    {
        Console.WriteLine("erm pls type yes or no ;)");
    }
}

bool AskAQuestionAndGetYesOrNo(string question)
{
    Console.WriteLine(question);
    while (true)
    {
        string response = Console.ReadLine();
        if (response == "yes")
            return true;

        if (response == "no")
            return false;

        Console.WriteLine("Please enter yes or no");
    }

}