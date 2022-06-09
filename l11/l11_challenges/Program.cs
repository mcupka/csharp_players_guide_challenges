//the_prototype();
magic_cannon();


void the_prototype() {
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
}


void magic_cannon() {
    for (int i = 1; i <= 100; i++) {
        Console.Write($"{i}: ");
        if (i % 3 == 0 && i % 5 == 0) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Fire and Electric\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (i % 3 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Fire\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else if (i % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Electric\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else Console.Write("Normal\n");
    }
}
