using System;
using System.Numerics;

public class Program1
{
        public long GCD(long a, long b)
        {
            long Remainder;
        
            while( b != 0 )
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }
            return a;
        }
        public long d(long e, long Fn, long d)
        {
            long Remainder;
        
            while( Fn != 0 )
            {
                Remainder = (e*d) % Fn;
                d = Fn;
                Fn = Remainder;
            }
            return d;
        }
        public long s(long x, long d, long n)
        {
            long Remainder;
            
            long z = (long)Math.Pow(x,d);
            Remainder = z % n;
            n = Remainder;
            return n;
        }

}
class Program
{
    static void Main()
    {
        long p, q, n, Fn, dbd, e, d;
        long x;
        Console.Write("Iveskite p reiksme: ");
        p = (long)Convert.ToDouble(Console.ReadLine());
        Console.Write("Iveskite q reiksme: ");
        q = (long)Convert.ToDouble(Console.ReadLine());
        Console.Write("Iveskite teksta: ");
        x = (long)Convert.ToDouble(Console.ReadLine());
        n = p * q;
        Console.WriteLine("n = " + n);
        Fn = (p-1)*(q-1);
        Console.WriteLine("Fn = " + Fn);
        e=0;
        d=0;
        for (long i = 2; i <= Fn; i++)
        {
            Program1 program1 = new Program1();
            dbd = program1.GCD(i,Fn);
            if (dbd == 1)
            {
                Console.WriteLine("DBD = " + dbd);
                e=i;
                break;
            } 
        }
        for (long y = 1; y <= Fn; y++)
        {
            Program1 program2 = new Program1();
            d = program2.d(e, Fn, y);
            if (d == 1)
            {
                d = y;
                break;
            }  
        }
        Console.WriteLine("e = " + e);
        Console.WriteLine("d = " + d);
        //privatus raktas = d = 7;
        //viesasis raktas = (n, e) == (33, 3);
        Program1 program3 = new Program1();
        long s = program3.s(x, d, n);
        Console.WriteLine("s = " + s); 
    }
}
