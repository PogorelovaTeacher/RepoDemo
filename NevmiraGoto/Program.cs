using System;

namespace ratatata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name: ");
            string name = Console.ReadLine();
            Console.Clear();
            int golod = 60, money = 1500, dream = 10;
            begin:
            Console.WriteLine("Wake up, samurai");
            Console.WriteLine("\t1.No, I wanna sleep\n\t2.OK, what's happened?");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                goto continue1;
            }
            if (s == 2)
            {
                goto continue2;
            }
            continue1:
            Console.Clear();
            Console.WriteLine("It'a not a request. WAKE UP, NOW!!!");
            Console.WriteLine("\t1.OK, OK, man, I'm wake\n\t2.Shut up and go away!\n\t3.Profile");
            s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                Console.Write("We can make money, bro. ");
                goto continue2;
            }
            if (s == 2)
            {
                goto lose;
            }

            if (s == 3)
            {
                Console.Clear();
                Console.WriteLine("Profile {0}: hunger {1},dream {2}, money {3}", name, golod, dream, money);
                Console.ReadLine();
                Console.Clear();
                goto continue1;
            }

            continue2:
            Console.Clear();
            Console.WriteLine("J:I get a massage from Tobi and we should kill a president");
            Console.WriteLine("\t1.WTF, Jonny?! Why are you accept this?!\n\t2.Hm...I'm gonna think about it\n\t3.Wow, Jonny, I'm in\n\n\t4.Profile");
            s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                goto continue3;
            }
            if (s == 2)
            {
                Console.WriteLine("Ok, I'm getting you 5 minutes");
                goto victory;

            }
            if (s == 3)
            {

                Console.WriteLine("OK, let's do this");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Then you killed the president and was killed. because Jonny isn't Jonny....");
                Console.ForegroundColor = ConsoleColor.White;
                goto lose;
            }
            if (s == 4)
            {
                Console.Clear();
                Console.WriteLine("Profile {0}: hunger {1},dream {2}, money {3}", name, golod, dream, money);
                Console.ReadLine();
                Console.Clear();
                goto continue2;
            }
            continue3:
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
                    goto victory;
                }
                if (s == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You and Jonny go to the GunShop");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    goto victory;
                }
            }
            if (s == 2)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You and Jonny go to the GunShop");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                goto victory;
            }
            if (s == 3)
            {
                Console.Clear();
                Console.WriteLine("Profile {0}: hunger {1},dream {2}, money {3}", name, golod, dream, money);
                Console.ReadLine();
                Console.Clear();
                goto continue3;
            }
            lose:
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
                goto begin;
            }
            victory:
            Console.Clear();
            Console.WriteLine("YOU WIN");
            Console.WriteLine("{0}: hunger {1},dream {2}, money {3}", name, golod, dream, money);
        }
    }
}