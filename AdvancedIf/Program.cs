

Console.Write("What is your first name: ");
string firstName = Console.ReadLine();

Console.Write("What is your last name: ");
string lastName = Console.ReadLine();

if (firstName.ToLower().Equals("tim") && lastName.ToLower().Equals("corey"))
{
    Console.WriteLine("Hello Mr. Corey");
}