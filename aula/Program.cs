﻿namespace aula;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        // Console. ReadKey();

        Exemplo exe01 = new Exemplo ();

        exe01.mostramsg();

        exe01.mostranome("primo");

        Console.WriteLine(exe01.msg());
        
        Console.WriteLine("A soma é:" + exe01.somar(10,20));
    }
}
