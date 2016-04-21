using System;

class PlayCard
{
    static void Main()
    {
        //input

        string cardSign = Console.ReadLine();

        //logic & output

        switch (cardSign)
        {
            case "2":
                Console.WriteLine("yes " + cardSign);
                break;
            case "3":
                Console.WriteLine("yes " + cardSign);
                break;
            case "4":
                Console.WriteLine("yes " + cardSign);
                break;
            case "5":
                Console.WriteLine("yes " + cardSign);
                break;
            case "6":
                Console.WriteLine("yes " + cardSign);
                break;
            case "7":
                Console.WriteLine("yes " + cardSign);
                break;
            case "8":
                Console.WriteLine("yes " + cardSign);
                break;
            case "9":
                Console.WriteLine("yes " + cardSign);
                break;
            case "10":
                Console.WriteLine("yes " + cardSign);
                break;
            case "J":
                Console.WriteLine("yes " + cardSign);
                break;
            case "Q":
                Console.WriteLine("yes " + cardSign);
                break;
            case "K":
                Console.WriteLine("yes " + cardSign);
                break;
            case "A":
                Console.WriteLine("yes " + cardSign);
                break;
            default:
                Console.WriteLine("no " + cardSign);
                break;
        }
    }
}