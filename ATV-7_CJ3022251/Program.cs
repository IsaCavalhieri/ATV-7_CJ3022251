﻿using System.Net.Sockets;

namespace ATV_7_CJ3022251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            do
            {

                do
                {

                    Console.WriteLine("=========MENU=========");
                    Console.WriteLine("0 - SAIR");
                    Console.WriteLine("1 - Ex1");
                    Console.WriteLine("2 - Ex2");
                    Console.WriteLine("3 - Ex3");
                    Console.WriteLine("4 - Ex4");
                    Console.WriteLine("5 - Ex5");
                    Console.WriteLine("6 - Ex6");
                    Console.WriteLine("7 - Ex7");

                    option = int.Parse(Console.ReadLine());
                } while (option < 0 || option > 7);
                //Exercício 1
                switch (option)
                {
                    case 1:

                        int n = 1, i;

                        Console.WriteLine("Digite um valor");
                        i = int.Parse(Console.ReadLine());

                        do
                        {

                            Console.WriteLine(n);
                            n++;
                        } while (n < 1);
                        break;

                    //Exercício 2

                    case 2:

                        int n1 = 1, i1;

                        Console.WriteLine("Digite um valor");
                        i1 = int.Parse(Console.ReadLine());

                        do

                        {

                            if (n1 % 2 == 0)
                            {

                                Console.WriteLine(n1);
                                
                            }
                            n1++;
                        } while (n1 < i1);
                        break;

                    case 3:

                        int d = 1000, c;

                        Console.WriteLine("Digite um valor");
                        c = int.Parse(Console.ReadLine());

                        do
                        {

                            if (d % 2 == 0)
                            {

                                Console.WriteLine(d);
                                d--;
                            }
                        } while (d > c);

                        break;


                    case 4:

                        int k;
                        int s = 0;



                        do
                        {
                            Console.WriteLine("digite um número");
                            k = int.Parse(Console.ReadLine());
                            if (k > 0)
                            {
                                s = s + k;
                                Console.WriteLine("s");
                            }

                        } while (s < 200);

                        break;

                    case 5:

                        int a1 = 0, div;

                        Console.WriteLine("Digite um número inteiro: ");
                        div = int.Parse(Console.ReadLine());

                        do
                        {
                            if (div % a1 == 0)
                            {
                                Console.WriteLine(a1);
                                a1++;
                            }
                        } while (a1 <= div);


                        break;


                    case 6:


                        int j = 0, v;

                        do
                        {
                            Console.WriteLine("Digite um valor");
                            v = int.Parse(Console.ReadLine());
                            j++;
                            if (v < v)
                            {
                                Console.WriteLine("Número maior= {0}", v);
                            }
                            if (v > v)
                            {
                                Console.WriteLine("Número menor= {0}", v);
                            }


                        } while (j > 11);

                        break;
                    case 7:

                        int u;
                        int si = 0;
                        int sp = 0;
                        Console.WriteLine("Digite um valor");
                        u = int.Parse(Console.ReadLine());


                        do
                        {
                            Console.WriteLine("Digite um valor");

                            u = int.Parse(Console.ReadLine());



                            if (u % 2 != 0)
                            {
                                si = si + u;
                            }
                            if (u % 2 == 0)
                            {
                                sp = sp + u;
                            }

                            Console.WriteLine("Soma dos números Ímpares= {0}, ", si, "Soma dos números Pares= {1} ", sp);
                        } while (u != 0);



                        break;
                }





            } while (option != 0);

        }
    }
}

