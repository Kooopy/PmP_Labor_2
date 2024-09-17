using System;

namespace PmP_Labor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Feladat 1:
            //Console.WriteLine("Adj meg egy pozítiv egész számot!");
            //int n = int.Parse(Console.ReadLine());
            //int counter = 0;
            //while (counter<n)
            //{
            //    if (counter % 2 == 0)
            //    {
            //        Console.WriteLine(counter);
            //    }
            //    counter++;
            //}

            //Feladat 2:

            //string correctPassword = "alma";
            //string enteredPassword = "";
            //int wrongPasswordCounter = 0;

            //do 
            //{
            //    Console.WriteLine("Add meg a jelszavad!");
            //    enteredPassword = Console.ReadLine();
            //    wrongPasswordCounter++;
            //} 
            //while (enteredPassword != correctPassword && wrongPasswordCounter<3);
            //if (wrongPasswordCounter <= 3)
            //{
            //    Console.WriteLine("Jó jelszó!");
            //}
            //else 
            //{
            //    Console.WriteLine("Túl sok rossz próbálkozás!");
            //}

            //Feladat 3:

            //Random random = new Random();
            //Console.WriteLine("Add meg az egész számot 0 és 1000 között: ");
            //int numberToGuess = int.Parse(Console.ReadLine());
            //int guessCounter = 0;
            //int randomNumber = 0;
            //do
            //{
            //    randomNumber = random.Next(1, 1001);
            //    guessCounter++;
            //    Console.WriteLine($"Guessed number: {randomNumber}");
            //} while (true);
            //Console.WriteLine($"Megtaláltam a számot, próbálkozások száma: {guessCounter}");

            //Feladat 4:
            //Random randomDice = new Random();

            //Console.Write("Hány játékos van? ");
            //int numPlayers= int.Parse(Console.ReadLine());
            //int roll;

            //int i = 0;
            //do
            //{
            //    i = i + 1;
            //    Console.ReadLine();
            //    roll = randomDice.Next(1, 7);
            //    Console.WriteLine($"Játékos  {i} dobása: {roll}");
            //    if (i == numPlayers)
            //    {
            //        i = 0;
            //    }
            //} 
            //while (i <= numPlayers && roll != 6);

            //Feladat 5:

            //Random r = new Random();
            //int numberToFind = r.Next(1, 1001);
            //int actualGuess = 0;
            //int guessCounter = 0;

            //do 
            //{
            //    Console.WriteLine("Add meg a tippedet: (1 és 1000 között)");
            //    actualGuess = int.Parse(Console.ReadLine());
            //    guessCounter++;
            //    if (actualGuess < numberToFind)
            //    {
            //        Console.WriteLine("Nagyobb számra gondoltam!");
            //    }
            //    else if (actualGuess > numberToFind)
            //    {
            //        Console.WriteLine("Kisebb számra gondoltam!");
            //    }
            //} 
            //while (actualGuess != numberToFind);
            //Console.WriteLine($"Gratulálok kitaláltad! Próbák száma: {guessCounter}");

            //Feladat 6:

            //Console.WriteLine("Add meg az N pozítiv számot!");
            //int number = int.Parse(Console.ReadLine());
            //Páros vagy páratlan?
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Páros");
            //}
            //else 
            //{
            //    Console.WriteLine("Páratlan");
            //}
            //Hány valódi osztója van?
            //int counter =0;
            //for (int i = 2; i < number; i++) 
            //{
            //    if (number % i == 0) 
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine($"Valódi osztóinak száma : {counter}");
            //Prím szám?
            //if (number == 0 || number == 1)
            //{
            //    Console.WriteLine("0 és az 1 nem prím");
            //}
            //else if (number == 2 || counter == 0)
            //{
            //    Console.WriteLine("Prím szám");
            //}
            //else
            //{
            //    Console.WriteLine("Nem prím szám");
            //}

            //Feladat 7:
            //Console.WriteLine("Melyik szám faktoriálisát keresed?");
            //int numFakt = int.Parse(Console.ReadLine());
            //int fakt = 1;

            //for (int i = 1; i <= numFakt; i++)
            //{
            //    fakt = fakt * i;
            //}
            //Console.WriteLine($"{numFakt}! = {fakt}");

            //Feladat 8:

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write(i*j + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Feladat 9:

            //Console.Write("Add meg a hátralévő időt (sec) ");
            //int totalSeconds = int.Parse(Console.ReadLine());
            //int minutes;
            //int seconds;
            //while (totalSeconds > 0)
            //{
            //    Console.Clear();
            //    minutes = totalSeconds / 60;
            //    seconds = totalSeconds % 60;
            //    Console.WriteLine($"{minutes}:{seconds}");
            //    System.Threading.Thread.Sleep(1000);
            //    totalSeconds = totalSeconds - 1;
            //}
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.Clear();
            //Console.Beep(500,1000);

            //Feladat 10:

            //const int BITS = 32;
            //Console.Write("Decimális szám: ");
            //uint decimalNum = uint.Parse(Console.ReadLine());
            //uint remainder = decimalNum;
            //Console.Write($"{decimalNum} (10) = ");
            //for (int e = BITS - 1; e >= 0; e--)
            //{
            //    uint currentPower = (uint)Math.Pow(2, e);
            //    uint digit = remainder / currentPower;
            //    remainder = remainder - digit * currentPower;
            //    Console.Write(digit);
            //    if (e % 8 == 0) 
            //    {
            //        Console.Write(" ");
            //    }
            //}
            //Console.Write("(2)");

            //Feladat 11:

            Random randomSpin = new Random();
            int credits = 100;
            int stake = 1;
            ConsoleKey keyPressed;

            do
            {
                Console.Clear();
                Console.WriteLine($"Jelenlegi kreditek: {credits}");
                Console.WriteLine($"Jelenlegi tét: {stake}");
                keyPressed = Console.ReadKey().Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    if (stake < credits)
                    {
                        stake = stake + 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    if (stake > 1)
                    {
                        stake = stake - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.Spacebar)
                {
                    if (stake <= credits)
                    {
                        credits = credits - stake;
                        int firstDigit = randomSpin.Next(1, 6);
                        int secondDigit = randomSpin.Next(1, 6);
                        int thirdDigit = randomSpin.Next(1, 6);
                        Console.WriteLine($"{firstDigit} {secondDigit} {thirdDigit}");
                        if (firstDigit == secondDigit && secondDigit == thirdDigit)
                        {
                            credits = credits + stake * 50;
                        }
                        else if (firstDigit == secondDigit || firstDigit == thirdDigit || secondDigit == thirdDigit)
                        {
                            credits = credits + stake * 10;
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("Nincs elég kredtited");
                }
                Console.ReadKey();

            } while (keyPressed != ConsoleKey.Escape && 0 < credits);



            Console.WriteLine("THE END!");
            Console.ReadLine();
        }
    }
}
