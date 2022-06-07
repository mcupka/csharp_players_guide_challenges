Console.Write("User 1, enter a number between 0 and 100: ");
uint correct_number = Convert.ToUInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("User 2, guess the number");
uint guess = Convert.ToUInt32(Console.ReadLine());
while (guess != correct_number)
{
    if (guess < correct_number) Console.WriteLine($"{guess} is too low");
    else Console.WriteLine($"{guess} is too high");
    Console.WriteLine("What is your next guess?");
    guess = Convert.ToUInt32(Console.ReadLine());
}
Console.WriteLine("You guessed the number!");