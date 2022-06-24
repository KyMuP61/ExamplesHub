Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Йоу Йоу Йоу Маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}