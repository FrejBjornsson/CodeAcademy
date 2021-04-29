using System;
using static System.Array;
using static System.Char;

class MainClass
{
    public static void Main(string[] args)
    {
        // alphabet for shifting
        char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        // caesar shifter
        int shift_by = -3; // +ve: shift right, -ve: shift left

        // message to be enciphered:
        string encipher_me = "placeholder text though caesar ciphers are cryptographically weak";
        Console.Write("Please enter your message for encryption: ");
        encipher_me = Console.ReadLine();
        // placeholder for encrypted message
        string encrypted = "";

        // encrypt the message
        for (int i = 0; i < encipher_me.Length; i++)
        {
            char space = '\u0020';
            if (encipher_me[i] != space)
            {
                char el;
                if (IsUpper(encipher_me[i]))
                {
                    el = ToLower(encipher_me[i]);
                }
                else
                {
                    el = encipher_me[i];
                }
                int ai = IndexOf(alpha, el);
                int ni = (((ai + shift_by) % 26) + 26) % 26;
                encrypted = encrypted + alpha[ni];
            }
            else
            {
                encrypted = encrypted + space;
            }
        }

        Console.Write(encrypted);
    }
}