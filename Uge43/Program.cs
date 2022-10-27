using Uge43;

namespace Uge43
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            DataHandler handler = new DataHandler("Måledata-2-år");
            //handler.LoadMåledata();
            //Console.ReadLine();
            menu.Show(0);
            int option = 0;
            bool abort = false;
            do
            {
                Console.CursorVisible = false;
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    option--;
                    
                    if (option < 0)
                    {
                        option = 2;
                    }
                }

                else if (key == ConsoleKey.DownArrow)
                {
                    option++;
                   
                    if (option > 2)
                    {
                        option = 0;
                    }
                }
                        

                if (key == ConsoleKey.Enter)
                {
                    switch(option)
                    {
                        case 0:
                            handler.LoadMeasurements();
                            break;
                        case 1:
                            handler.LoadMeasurements();
                            break;
                        case 2:
                            abort = !abort;
                            Console.Clear();
                            break;
                        default:
                            break;
                    }
                }
                Console.SetCursorPosition(0, 0);
                menu.Show(option);
            } while (!abort);
        }
    }
}