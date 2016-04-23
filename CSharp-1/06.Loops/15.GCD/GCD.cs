using System;

class GCD
{
    static void Main()
    {
        //input
        //int n = int.Parse(Console.ReadLine());

        string[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int firstNum = int.Parse(nums[0]);
        int secondNum = int.Parse(nums[1]);
        int biggerNum = Math.Abs(firstNum);
        int smallerNum = Math.Abs(secondNum);

        //logic
        if (smallerNum > biggerNum)
        {
            int helper = smallerNum;
            smallerNum = biggerNum;
            biggerNum = helper;
        }
        int remainder = biggerNum % smallerNum;

        while (remainder != 0)
        {
            biggerNum = smallerNum;
            smallerNum = remainder;
            remainder = biggerNum % smallerNum;
        }
        int gcd = smallerNum;

        //output
        Console.WriteLine(gcd);
    }
}