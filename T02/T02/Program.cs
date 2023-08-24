
// Number to words and Roman Numberals Converter //

using System;

public class Program {

      static string one_to_hund (int n) {
          string str = "";

          while (n != 0) {
              if (n == 1) {
                  str = str + "one";
                  n = 0;
              } else if (n == 2) {
                  str = str + "two";
                  n = 0;
              } else if (n == 3) {
                  str = str + "three";
              } else if (n == 4) {
                  str = str + "four";
              } else if (n == 5) {
                  str = str + "five";
              } else if (n == 6) {
                  str = str + "six";
              } else if (n == 7) {
                  str = str + "seven";
              } else if (n == 8) {
                  str = str + "eight";
              } else if (n == 9) {
                  str = str + "nine";
              } else if (n == 10) {
                  str = str + "ten";
              } else if (n == 11) {
                  str = str + "eleven";
              } else if (n == 12) {
                  str = str + "twelve";
              } else if (n == 13) {
                  str = str + "thirteen";
              } else if (n == 14) {
                  str = str + "fourteen";
              } else if (n == 15) {
                  str = str + "fifteen";
              } else if (n == 16) {
                  str = str + "sixteen";
              } else if (n == 17) {
                  str = str + "seventeen";
              } else if (n == 18) {
                  str = str + "eighteen";
              } else if (n == 19) {
                  str = str + "nineteen";
              } else if (n >= 20 && n < 30) {
                  str = str + "tweenty";
                  n = n - 20;
              } else if (n >= 30 && n < 40) {
                  str = str + "Thirty";
                  n = n - 30;
              } else if (n >= 40 && n < 50) {
                  str = str + "fourty";
                  n = n - 40;
              } else if (n >= 50 && n < 60) {
                  str = str + "Fifty";
                  n = n - 50;
              } else if (n >= 60 && n < 70) {
                  str = str + "Sixty";
                  n = n - 60;
              } else if (n >= 70 && n < 80) {
                  str = str + "Seventy";
                  n = n - 70;
              } else if (n >= 80 && n < 90) {
                  str = str + "Eighty";
                  n = n - 80;
              } else if (n >= 90 && n < 100) {
                  str = str + "Nighty";
                  n = n - 90;
              }
          }
          return str;
      }
      static string convert (int n) {
          string str = "";
          while (n != 0) {
              if (n >= 1 && n < 100) {
                  str = str + one_to_hund (n);
                  n = 0;
              } else if (n >= 100 && n < 1000) {
                  str = str + one_to_hund (n / 1000);
                  str = str + "Thousand";
                  n = n % 1000;
              }
          }
          return str;
      }

      static void Main (string[] args) {
          string str;
          int n;

          Program t = new Program ();



          Console.WriteLine ("enter any Number");
          n = int.Parse (Console.ReadLine ());
          str = t.Convert(n);


          Console.WriteLine (str);
          Console.ReadLine ();

      }


   /* static void Main () {
        string str = "";
        int Number = 2;
        Console.WriteLine (Number);
        while (Number != 0) {
            if (Number == 2) {

                str = str + "Two";
                Number = 0;
            } 

                Console.WriteLine (str);
            }


        }*/

    }

