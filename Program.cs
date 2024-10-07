namespace Oppgave_2;

class Program
{
    static void Main(string[] args)
    {
        // integer , heltall
        int newInt = 20;
        Console.WriteLine(newInt);
        // string, tekst
        string newString = "Hellow World!";
        Console.WriteLine(newString);
        // double, desimal
        double newDouble = 10.5;
        Console.WriteLine(newDouble);
        // char, karakter
        char newChar = '3';
        Console.WriteLine(newChar);
        // array, integer, for-løkke
        int[] newArray = {1, 2, 3, 4, 5};
        
        for (int i = 0; i < newArray.Count(); i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}
