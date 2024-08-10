﻿using System.Diagnostics;

namespace project0810
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a={a} b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c} d={d}");

            int e = -1000_0000; // 0이 7개
            uint f = 3_0000_0000;

            Console.WriteLine($"e={e} f={f}");

            long g = -5000_0000_0000;

            ulong h = 200_0000_000_0000_0000;

            Console.WriteLine($"g={g} h={h}");
        }
    }
}
