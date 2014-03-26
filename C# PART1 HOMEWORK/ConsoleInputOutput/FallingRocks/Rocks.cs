/*Implement the "Falling Rocks" game in the text console.
 A small dwarf stays at the bottom of the screen and 
 can move left and right (by the arrows keys). 
 A number of rocks of different sizes and forms constantly 
 fall down and you need to avoid a crash.
Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
Implement collision detection and scoring system.
*/

/*FallingRocks
 '#, $, %' = death and less points
 '*' = more slow speed
 '+' = new lives and more points
 
If you can earn 10000 points, view the code down and see what happens ;)
And if you really manage to earn 10000 points, will buy you a beer ;)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


struct Object
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}

class Rocks
{
    static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    static void Main(string[] args)
    {
        int points = 0;
        int speed = 5;
        int playfieldWidth = 39;
        int livesCount = 5;
        Console.BufferHeight = Console.WindowHeight = 40;
        Console.BufferWidth = Console.WindowWidth = 40;
        Object user = new Object();
        user.x = 20;
        user.y = 39;
        user.c = '@';
        user.color = ConsoleColor.White;
        Random randomGenerator = new Random();
        List<Object> objects = new List<Object>();

        while (true)
        {
            points++;
            speed++;
            if (speed > 470)
            {
                speed = 470;
            }
            if (points >= 10000)
            {
                PrintStringOnPosition(8, 8, "Congratulation, You Are Jedy Master Gamer", ConsoleColor.Blue);
                PrintStringOnPosition(8, 10, "Your points are: " + points, ConsoleColor.Red);
                Console.ReadLine();
                return;
            }
            bool hitted = false;
            {
                int chance = randomGenerator.Next(0, 100);
                if (chance < 5)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Magenta;
                    newObject.c = '+';
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }
                else if (chance < 10)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Cyan;
                    newObject.c = '*';
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }
                else if (chance < 30)
                {
                    Object newRocks = new Object();
                    newRocks.color = ConsoleColor.Red;
                    newRocks.x = randomGenerator.Next(0, playfieldWidth);
                    newRocks.y = 0;
                    newRocks.c = '$';
                    objects.Add(newRocks);
                }
                else if (chance < 40)
                {
                    Object newRocks = new Object();
                    newRocks.color = ConsoleColor.Yellow;
                    newRocks.x = randomGenerator.Next(0, playfieldWidth);
                    newRocks.y = 0;
                    newRocks.c = '%';
                    objects.Add(newRocks);
                }
                else
                {
                    Object newRocks = new Object();
                    newRocks.color = ConsoleColor.Green;
                    newRocks.x = randomGenerator.Next(0, playfieldWidth);
                    newRocks.y = 0;
                    newRocks.c = '#';
                    objects.Add(newRocks);
                }

            }
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (user.x - 1 >= 0)
                    {
                        user.x = user.x - 1;
                    }
                }
                if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (user.x + 1 < playfieldWidth)
                    {
                        user.x = user.x + 1;
                    }
                }
            }
            List<Object> newList = new List<Object>();
            for (int i = 0; i < objects.Count; i++)
            {
                Object oldObject = objects[i];
                Object newObject = new Object();
                newObject.x = oldObject.x;
                newObject.y = oldObject.y + 1;
                newObject.c = oldObject.c;
                newObject.color = oldObject.color;
                if (newObject.c == '*' && newObject.y == user.y && newObject.x == user.x)
                {
                    speed -= 20;
                }
                if (newObject.c == '+' && newObject.y == user.y && newObject.x == user.x)
                {
                    livesCount++;
                    points += 50;
                }
                if ((newObject.c == '#' || newObject.c == '$' || newObject.c == '%') && (newObject.y == user.y && newObject.x == user.x))
                {
                    speed -= 50;
                    points -= 50;
                    livesCount--;
                    if (speed > 470)
                    {
                        speed = 470;
                    }
                    if (points >= 10000)
                    {
                        PrintStringOnPosition(8, 8, "Congratulation, You Are Jedy Master Gamer", ConsoleColor.Red);
                        PrintStringOnPosition(8, 10, "Your points are: " + points, ConsoleColor.Red);
                        Console.ReadLine();
                        return;
                    }
                    hitted = true;
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(8, 10, "Game Over!!!", ConsoleColor.Red);
                        PrintStringOnPosition(8, 14, "Your points are: " + points, ConsoleColor.Red);
                        PrintStringOnPosition(8, 12, "Press Enter to exit!", ConsoleColor.Red);
                        Console.ReadLine();
                        return;
                    }
                }
                if (newObject.y < Console.WindowHeight)
                {
                    newList.Add(newObject);
                }
            }
            objects = newList;
            Console.Clear();
            if (hitted)
            {
                objects.Clear();
                PrintOnPosition(user.x, user.y, 'X', ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(user.x, user.y, user.c, user.color);
            }
            foreach (Object car in objects)
            {
                PrintOnPosition(car.x, car.y, car.c, car.color);
            }
            if (hitted)
            {
                PrintOnPosition(user.x, user.y, 'X', ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(user.x, user.y, user.c, user.color);
            }

            PrintStringOnPosition(8, 4, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(8, 5, "Points: " + points, ConsoleColor.White);

            Thread.Sleep(500 - speed);
        }
    }

}

