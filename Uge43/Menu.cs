using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge43
{
    public class Menu
    {
        MenuItem[] menuItems = new MenuItem[3];

        
        // Show method for menu
        public void Show(int option)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("──────────────────────────────────────────────────── Measurement Viewer ────────────────────────────────────────────────────");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                     Made by team 9 for the project Energy Week 43 of Computer Science at UCL ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Select an option from the menu");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" (Use arrow keys to navigate)\n\n");

            Console.SetWindowSize(130, 30);

            menuItems[0] = new MenuItem("Read All Measurements");
            menuItems[1] = new MenuItem("Read Measurements by Date");
            menuItems[2] = new MenuItem("Quit");

            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < menuItems.Length; i++)
            { 
                if (i == option)
                {
                    Console.WriteLine(">  " + menuItems[i].Title);
                    continue;
                }
                    Console.WriteLine("   " + menuItems[i].Title);               
                //Console.WriteLine("     " + menuItems[i].Title);
            }
            Console.ResetColor();
        }
    }
}