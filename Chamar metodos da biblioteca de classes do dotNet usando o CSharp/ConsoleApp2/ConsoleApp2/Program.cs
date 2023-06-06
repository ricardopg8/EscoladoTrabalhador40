// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Random dice = new Random();
//int roll = dice.Next(1, 7);
////Console.WriteLine(roll);

//using System.Collections;
//using System.Runtime.CompilerServices;

//Random dice = new Random();

//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);

//int total = roll1 + roll2 + roll3;

////Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
//Console.WriteLine(total);

//if (total > 14)
//{
//    Console.WriteLine("Great! You Win!");
//}
//if (total < 15) 
//{
//    Console.WriteLine("Sorry, You Lose");
//}


string message = "The quick brown fox jumps over de lazy dog";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say");
}