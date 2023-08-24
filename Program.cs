// Convert to Decimal to Hexadecimal and Binary Program //
internal class Program {
    /// <summary>Main method</summary>
    static void Main () {
        Console.Write ("Input a Number : ");
        string answer = Console.ReadLine ();
        int decimalNumber = Convert.ToInt32 (answer);
        DecimalToHexadecimal (decimalNumber);
        int binary = Convert.ToInt32 (answer);
        //Console.WriteLine(Convert.ToString(binary, 2));
        DecimalToBinary (binary);
    }

    /// <summary>This method converts decimal to hexadecimal</summary>
    /// <param name="decimalNumber"></param>
    static void DecimalToHexadecimal (int decimalNumber) {
        string hex = "";
        while (decimalNumber > 0) {
            int remainder = decimalNumber % 16;
            char hexDigit = (char)(remainder < 10 ? remainder + '0' : remainder + 'A' - 10);
            hex = hexDigit + hex;
            decimalNumber /= 16;
        }
        Console.WriteLine ($"Decimal: {decimalNumber}, hexdecimal: {hex}");
    }

    /// <summary>Converts decimal to binary</summary>
    /// <param name="binary"></param>
    static void DecimalToBinary (int binary) {
        string result = "";
        while (binary > 0) {
            int remainder1 = binary % 2;
            result = remainder1 + result;
            binary /= 2;

        }
        var rem = 4 - (result.Length % 4);
        if (rem != 4) result = new string ('0', rem) + result;
        Console.WriteLine ($"Binary: {result}");
    }
}