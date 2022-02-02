using System;

namespace ConsoleAppNevmira
{
    class Program
    {
        int s;
        static string name;
        int golod = 60, money = 1500, dream = 10;
        void Begin()
        {
            Console.WriteLine("Wake up, samurai");
            Console.WriteLine("\t1.No, I wanna sleep\n\t2.OK, what's happened?");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                Continue1();
            }
            if (s == 2)
            {
                Continue2();
            }
        }

        void Continue1()
        {
            Console.Clear();
            Console.WriteLine("It'a not a request. WAKE UP, NOW!!!");
            Console.WriteLine("\t1.OK, OK, man, I'm wake\n\t2.Shut up and go away!\n\t3.Profile");
            s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                Console.Write("We can make money, bro. ");
                Continue2();
            }
            if (s == 2)
            {
                Lose();
            }

            if (s == 3)
            {
                Console.Clear();
                Console.WriteLine("Profile {0}: hunger {1},dream {2}, money {3}", name, golod, dream, money);
                Console.ReadLine();
                Console.Clear();
                Continue1();
            }
        }

        void Continue2()
        {
            Console.Clear();
            Console.WriteLine("J:I get a massage from Tobi and we should kill a president");
            Console.WriteLine("\t1.WTF, Jonny?! Why are you accept this?!\n\t2.Hm...I'm gonna think about it\n\t3.Wow, Jonny, I'm in\n\n\t4.Profile");
            s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                Continue3();
            }
            if (s == 2)
            {
                Console.WriteLine("Ok, I'm getting you 5 minutes");
                Victory();

            }
            if (s == 3)
            {

                Console.WriteLine("OK, let's do this");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Then you killed the president and was killed. because Jonny isn't Jonny....");
                Console.ForegroundColor = ConsoleColor.White;
                Lose();
            }
            if (s == 4)
            {
                Console.Clear();
                Console.WriteLine("Profile {0}: hunger {1},dream {2}, money {3}", name, golod, dream, money);
                Console.ReadLine();
                Console.Clear();
                Continue2();
            }
        }

        void Continue3()
        {
            Console.Clear();
            Console.WriteLine("J:Because we haven't money");
            Console.WriteLine("\t1.But we can get money another way!\n\t2.Ah, man, you're right\n\n\t3.Profile");
            s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                Console.Clear();
                Console.WriteLine("J:I don't wanna dry the toilet, man. And I don't wanna die in a poverty!");
                Console.WriteLine("\t1.Bro, we can make money another way and I know how\n\t2.You're right, let's go");
                s = Convert.ToInt32(Console.ReadLine());
                if (s == 1)
                {
                    Console.WriteLine("Blablabla");
                    Console.ReadLine();
                    Victory();
                }
                if (s == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You and Jonny go to the GunShop");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Victory();
                }
            }
            if (s == 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You and Jonny go to the GunShop");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                Victory();
            }
            if (s == 3)
            {
                Console.Clear();
                Console.WriteLine("Profile {0}: hunger {1},dream {2}, money {3}", name, golod, dream, money);
                Console.ReadLine();
                Console.Clear();
                Continue3();
            }
        }

        void Lose()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Congratulations, you loser");
            Console.WriteLine("\t* ******* ****** *******\n\t* * * * * \n\t* * * ****** *******\n\t* * * * * \n\t****** ******* ****** *******");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press 1 to restart");
            s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Begin();
            }
        }

        void Victory()
        {
            Console.Clear();
            Console.WriteLine("YOU WIN");
            Console.WriteLine("{0}: hunger {1},dream {2}, money {3}", name, golod, dream, money);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Your name: ");
            name = Console.ReadLine();
            Console.Clear();
            program.Begin();
        }
    }
}