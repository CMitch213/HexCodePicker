using System;

namespace HexCodeChooser
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = "";
            string choice;

            Console.WriteLine("-----     Hex Code Picker v1.03     -----");
            Console.WriteLine("-----                              -----");
            Console.WriteLine("-----     Type your colour here    -----");
            Console.WriteLine("");
            choice = Console.ReadLine();
            colour();
            Console.WriteLine("The hex code is " + code);



            void colour()
            {
                if (choice == "red" || choice == "Red")
                {
                    code = "#FF0000";
                }
                else if (choice == "green" || choice == "Green")
                {
                    code = "#00FF00";
                }
                else if (choice == "blue" || choice == "Blue")
                {
                    code = "#0000FF";
                }
                else if (choice == "yellow" || choice == "Yellow")
                {
                    code = "#FFFF00";
                }
                else if (choice == "pink" || choice == "Pink" || choice == "magenta" || choice == "Magenta")
                {
                    code = "#FF00FF";
                }
                else if (choice == "cyan" || choice == "Cyan" || choice == "light blue" || choice == "Light blue" || choice == "Light Blue")
                {
                    code = "#00FFFF";
                }
                else if (choice == "white" || choice == "White")
                {
                    code = "#FFFFFF";
                }
                else if (choice == "black" || choice == "Black")
                {
                    code = "#000000";
                }
                else if (choice == "grey" || choice == "Grey" || choice == "gray" || choice == "Gray")
                {
                    code = "#5A5A5A";
                }
                else
                {
                    Console.WriteLine("---- ERROR: Invalid Colour. -----");
                }
            }
        }
    }
}