// Convert to Decimal to Hexadecimal and Binary Program //

using System;

public class Program
{
    static string DecimalToHexadecimal(int decimalNumber)
    {
        string hex = "";
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 16;
            char hexDigit = (char)(remainder < 10 ? remainder + '0' : remainder + 'A' - 10);
            hex = hexDigit + hex;
            decimalNumber /= 16;
        }
        return hex;
    }

     static string DecimalToBinary(int binary)
    {
        string result = "";
        string bin = "";
        while (binary > 0 )
        {
            int remainder1 = binary % 2;
            result = Convert.ToString(remainder1) + result;
            binary /= 2;
            
        }
        Console.WriteLine($"Binary: {result}");
        return bin;
    }



   

    static void Main()
    {
        
        string answer;
        
        Console.Write("Input a Number : ");
        answer = Console.ReadLine();


        int decimalNumber = Convert.ToInt32(answer);
        string hexdecimalNumber = DecimalToHexadecimal(decimalNumber);
        Console.WriteLine($"Decimal: {decimalNumber}, hexdecimal: {hexdecimalNumber}");

        
        int binary = Convert.ToInt32(answer);
        string bin = DecimalToBinary(binary);
       


    }
}