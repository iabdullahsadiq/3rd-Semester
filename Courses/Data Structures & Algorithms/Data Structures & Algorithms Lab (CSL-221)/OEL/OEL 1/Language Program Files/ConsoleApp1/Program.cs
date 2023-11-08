using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            webbrowse browser = new webbrowse();
            Console.Write("Enter a command:\n Enter NEW+ to Create new Tab\n Enter BACK to go to previous Tab\n Enter VIEW to see the current Tab\n Enter SHOW to see the list of all Tabs\n Enter QUIT to Exit\n");

            while (true)
            {
                Console.Write("Enter a command (NEW+, BACK, VIEW, SHOW, or QUIT):\n");
                string input = Console.ReadLine();

                if (input == "QUIT")
                {
                    break;
                }
                else if (input == "NEW+")
                {
                    Console.Write("Enter URL: ");
                    string url = Console.ReadLine();
                    browser.OpenTab(url);
                }
                else if (input == "BACK")
                {
                    browser.NavigateBack();
                }
                else if (input == "VIEW")
                {
                    browser.ViewCurrentTab();
                }
                else if (input == "SHOW")
                {
                    browser.ShowAllTabsInReverseOrder();
                }
                else
                {
                    Console.WriteLine("Invalid command. Please try again.");
                }
            }
        }
    }
}