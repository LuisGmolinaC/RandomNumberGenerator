using RandomNumberGenerator.Models;

Console.WriteLine("Welcome to my Random Number Generator!");
Console.WriteLine("Please press the key 'Enter' to generate a new number or the 'space' bar to end the program");
GenerateRandomNumber();


static void GenerateRandomNumber()
{
    var key = Console.ReadKey().Key;

    if (key == ConsoleKey.Enter)
    {
        Console.WriteLine("\nHere is your random number!");
        RandomNumber randomNumber = new RandomNumber();
        Console.WriteLine("Press 'Enter' to generate another number or 'Space' to exit.");
        GenerateRandomNumber(); // Llamada recursiva
    }
    else if (key == ConsoleKey.Spacebar)
    {
        Console.WriteLine("\nGoodbye!");
    }
    else
    {
        Console.WriteLine("\nInvalid input. Please try again.");
        GenerateRandomNumber(); // Llamada recursiva en caso de entrada inválida
    }
}
