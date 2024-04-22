// This Program was developed using C# in Visual Studio 2022
// Homework 3 Deck Draw Program
// Teammates are Nicholas/Brett/James/Jeremy/Matthew
// 3/22/24 CS4500
// This Program will allow user to select 4 cards, highlighting red cards and writing selections to a file
// Central Data Structure is Arrays
// This Program used MicroSoft's Tutorial on C# Picture viewer apps

/* 
 * ==================================
 * HOW TO COMPILE, BUILD, AND EXECUTE
 * ==================================
 *  Launch Visual Studio and open the solution file (.sln) of the project.
 
 **  Build the Solution **
    -- In Visual Studio, go to the menu and select Build > Build Solution.

 ** Configure Debugging Options **
    -- Click F5 on the keyboard or go to Debug > Start Debugging 
    -- This Should Also Run the Project and Compile

 ** Documentation **
    -- Consult the Projects other Documentation for more in-depth details about the project
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckDrawHW1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ArtDealer());
        }
    }
}
