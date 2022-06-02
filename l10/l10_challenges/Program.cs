//buying_inventory();
discounted_inventory();

void buying_inventory()
{
    Console.WriteLine("The following items are available:");
    Console.WriteLine("1 - Rope");
    Console.WriteLine("2 - Torches");
    Console.WriteLine("3 - Climbing Equipment");
    Console.WriteLine("4 - Clean Water");
    Console.WriteLine("5 - Machete");
    Console.WriteLine("6 - Canoe");
    Console.WriteLine("7 - Food Supplies");
    Console.WriteLine("What number do you want to see the price of? ");

    uint selection = Convert.ToUInt32(Console.ReadLine());

    string price_string = selection switch
    {
        1 => "Rope costs 10 gold",
        2 => "Torches cost 15 gold",
        3 => "Climbing equipment costs 25 gold",
        4 => "Clean water costs 1 gold",
        5 => "Machetes cost 20 gold",
        6 => "Canoes cost 200 gold",
        7 => "Food supplies cost 1 gold",
        _ => "We don't sell that here"
    };

    Console.WriteLine(price_string);
}

void discounted_inventory()
{
    Console.Write("What is your name? ");
    string? name = Console.ReadLine();

    Console.WriteLine("The following items are available:");
    Console.WriteLine("1 - Rope");
    Console.WriteLine("2 - Torches");
    Console.WriteLine("3 - Climbing Equipment");
    Console.WriteLine("4 - Clean Water");
    Console.WriteLine("5 - Machete");
    Console.WriteLine("6 - Canoe");
    Console.WriteLine("7 - Food Supplies");
    Console.WriteLine("What number do you want to see the price of? ");

    uint selection = Convert.ToUInt32(Console.ReadLine());

    string price_string = selection switch
    {
        1 => name == "Michael" ? "Rope costs 5 gold" : "Rope costs 10 gold",
        2 => name == "Michael" ? "Torches cost 7.5 gold" : "Torches cost 15 gold",
        3 => name == "Michael" ? "Climbing equipment costs 12.5 gold" : "Climbing equipment costs 25 gold",
        4 => name == "Michael" ? "Clean water costs .5 gold" : "Clean water costs 1 gold",
        5 => name == "Michael" ? "Machetes cost 10 gold" : "Machetes cost 20 gold",
        6 => name == "Michael" ? "Canoes cost 100 gold" : "Canoes cost 200 gold",
        7 => name == "Michael" ? "Food supplies cost .5 gold" : "Food supplies cost 1 gold",
        _ => name == "Michael" ? "We don't sell that here but if we did I would sell it to you for half price" : "We don't sell that here"
    };

    Console.WriteLine(price_string);
}