using System;
using System.Collections.Generic;

class GFG
{

    // Function to calculate the modulus
    static void modBigNumber(string num, long m)
    {
        // Store the modulus of big number
        List<int> vec = new List<int>();
        long mod = 0;

        // Do step by step division
        for (int i = 0; i < num.Length; i++)
        {

            int digit = num[i] - '0';

            // Update modulo by concatenating
            // current digit.
            mod = mod * 10 + digit;

            // Update quotient
            int quo = (int)(mod / m);
            vec.Add(quo);

            // Update mod for next iteration.
            mod = mod % m;
        }

        Console.Write("Remainder : " + mod + "\n");

        Console.Write("Quotient : ");

        // Flag used to remove starting zeros
        bool zeroflag = false;
        for (int i = 0; i < vec.Count; i++)
        {
            if (vec[i] == 0 && zeroflag == false)
            {
                continue;
            }
            zeroflag = true;
            Console.Write(vec[i]);
        }

        return;
    }

    // Driver Code
    public static void Main()
    {

        string num = "145";
        long m = 48;
        modBigNumber(num, m);
    }
}