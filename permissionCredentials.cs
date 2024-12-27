// See https://aka.ms/new-console-template for more information


Console.WriteLine("What is your permission credentials?");
string? permission = Console.ReadLine();
Console.WriteLine("What is your level");
string? levelString = Console.ReadLine();
int level = Convert.ToInt32(levelString);

string output1 = "Welcome, Super Admin user.";
string output2 = "Welcome, Admin user.";
string output3 = "Contact an Admin for access.";
string output4 = "You do not have sufficient privileges.";

if (permission != null && permission.Contains("Admin") && level > 55)
    Console.WriteLine(output1);
else if (permission.Contains("Admin") && level <= 55)
    Console.WriteLine(output2);
else if (permission.Contains("Manager") && level >= 20)
    Console.WriteLine(output3);
else if (permission.Contains("Manager") && level < 20)
    Console.WriteLine(output4);
else if (!permission.Contains("Admin|Manager"))
    Console.WriteLine(output4);

/*
string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
*/
