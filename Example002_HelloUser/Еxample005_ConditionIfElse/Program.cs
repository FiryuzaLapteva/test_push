internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите имя пользователя");
        string username = Console.ReadLine();
        if (username.ToLower() == "Маша")
        {
            Console.WriteLine("Ура, опять Маша");
        }
        else
        {
            Console.WriteLine("Привет, ");
            Console.WriteLine(username);
        }
    }
}