void Aufgaben1Bis6()
{
// Aufgaben 1 - 6
    Console.Write("Please type your name: ");
    Console.WriteLine("Hello " + Console.ReadLine().ToUpper() + "! What two [int] numbers would you like to add?");
    int nr1 = int.Parse(Console.ReadLine());
    Console.WriteLine("The sum of your two numbers is: " + (nr1 + int.Parse(Console.ReadLine())));
// Aufgabe 3: Versucht string und int zu addieren. Dies funktioniert nicht.
    Console.WriteLine("What two words might make an interesting combination?");
    string word1 = Console.ReadLine();
    Console.WriteLine("Those two words combine to: " + word1 + Console.ReadLine());
    Console.Write("Let's do some taxes! Enter your brutto annual pay: ");
    decimal annualWage = decimal.Parse(Console.ReadLine());
    Console.Write("Enter your local tax rate (%): ");
    Console.WriteLine("Your Netto wage per year is " + annualWage * (1 - decimal.Parse(Console.ReadLine()) / 100));
// Aufgabe 6: Output = 2
}

void Aufgaben7Bis9()
{
    decimal number1 = 0m;
    decimal number2 = 0m;
    Console.WriteLine("Please enter two numbers of your choosing below.");
    number1 = decimal.Parse(Console.ReadLine());
    number2 = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Addition: " + (Math.Round(number1 + number2, 2)));
    Console.WriteLine("Subtraction: " + (Math.Round(number1 - number2, 2)));
    Console.WriteLine("Multiplication: " + (Math.Round(number1 * number2, 2)));
    Console.WriteLine("Division: " + (Math.Round(number1 / number2, 2)));
    // Aufgabe 7.2: Wenn mindestens ein Wert decimal ist, ist das Output decimal. Sonst int.
    int x = 5;
    x += 1;
    Console.WriteLine(x);
    x -= 2;
    Console.WriteLine(x);
    decimal price = 3.20m;
    decimal budget = 20m;
    Console.WriteLine(Math.Round(budget / price));
}

Aufgaben7Bis9();