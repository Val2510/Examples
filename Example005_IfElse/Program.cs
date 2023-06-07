Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "Leo")
{
    Console.Write("Здорово, это же Leo!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
    
