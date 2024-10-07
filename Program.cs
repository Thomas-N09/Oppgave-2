namespace Oppgave_2;

class Program
{
    static void Main(string[] args)
    {
        int newInt = 20;
        Console.WriteLine(newInt);
        string newString = "Hellow World!";
        Console.WriteLine(newString);
        double newDouble = 10.5;
        Console.WriteLine(newDouble);
        char newChar = '3';
        Console.WriteLine(newChar);
        int[] newArray = {1, 2, 3, 4, 5};
        
        for (int i = 0; i < newArray.Count(); i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}
