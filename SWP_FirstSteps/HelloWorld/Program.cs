// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;



bool isInput = true;

Console.WriteLine("Schreibe etwas rein!");


while (isInput)
{
    string input = Console.ReadLine();
    Console.WriteLine(input);
    if(input == "Beenden")
    {
        isInput = false;
    }
}

