using System;

namespace HexCodeChooser
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = "";
            string choice;

            Console.WriteLine("-----     Hex Code Picker v1.04     -----");
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
                else if (choice == "light grey" || choice == "Light Grey" || choice == "light gray" || choice == "Light Gray")
                {
                    code = "#C3C3C3";
                }
                else if (choice == "dark grey" || choice == "Dark Grey" || choice == "dark gray" || choice == "Dark Gray")
                {
                     code = "#2F2F2F";
                }
                else if (choice == "orange" || choice == "Orange")
                {
                     code = "#FF7400";
                }
                else if (choice == "purple" || choice == "Purple")
                {
                     code = "#9700FF";
                }
                else if(choice == "light red" || choice == "Light Red")
                {
                     code = "#FF6767";
                }
                else if(choice == "dark red" || choice == "Dark Red")
                {
                     code = "#7E0000";
                }
                else if(choice == "light blue" || choice == "Light Blue")
                {
                     code = "#79A7FF";
                }
                else if(choice == "dark blue" || choice == "Dark Blue")
                {
                     code = "#00205C";
                }
                else if(choice == "light green" || choice == "Light Green")
                {
                     code = "#A1FFA1";
                }
                else if(choice == "dark green" || choice == "Dark Green")
                {
                     code = "#003B00";
                }
                else
                {
                    Console.WriteLine("---- ERROR: Invalid Colour. -----");
                }
            }
        }
    }
}