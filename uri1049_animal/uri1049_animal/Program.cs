using System;

namespace uri1049_animal
    {
    class Program
        {
        static void Main(string[] args)
            {
            string camada1, camada2, camada3;

            camada1 = Console.ReadLine();
            camada2 = Console.ReadLine();
            camada3 = Console.ReadLine();

            if (camada1 == "vertebrado")
                {
                if (camada2 == "ave")
                    {
                    if (camada3 == "carnivoro")
                        {
                        Console.WriteLine("aguia");
                        }
                    else
                        {
                        Console.WriteLine("pomba");
                        }
                    }
                if (camada2 == "mamifero")
                    {
                    if (camada3 == "onivoro")
                        {
                        Console.WriteLine("homem");
                        }
                    else
                        {
                        Console.WriteLine("vaca");
                        }
                    }
                }
            if (camada1 == "invertebrado")
                {
                if (camada2 == "inseto")
                    {
                    if (camada3 == "hematofago")
                        {
                        Console.WriteLine("pulga");
                        }
                    else
                        {
                        Console.WriteLine("lagarta");
                        }
                    }
                if (camada2 == "anelideo")
                    {
                    if (camada3 == "hematofago")
                        {
                        Console.WriteLine("sanguessuga");
                        }
                    else
                        {
                        Console.WriteLine("minhoca");
                        }
                    }
                }
            //Console.ReadKey();
            }
        }
    }








