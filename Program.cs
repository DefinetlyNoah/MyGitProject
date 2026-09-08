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
Console.WriteLine("Your Netto wage per year is " + annualWage * (1 - decimal.Parse(Console.ReadLine())/100));
// Aufgabe 6: Output = 2