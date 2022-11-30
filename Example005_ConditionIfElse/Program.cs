Console.Write("Input Name");
string  username = Console.ReadLine();

if(username.ToLower() == "kirill")
{
    Console.WriteLine("Hej, Kirill!");
}
else
{
    Console.Write("Hello,");
    Console.WriteLine(username);
}