using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class webbrowse
    {
        private List<string> tabs = new List<string>();
        private int currentTab = -1;
        private const int maxTabs = 4;

        public void OpenTab(string url)
        {
            if (tabs.Count >= maxTabs)
            {
                Console.WriteLine("Tabs limit exceeded. Please close some tabs.");
                return;
            }

            tabs.Add(url);
            currentTab = tabs.Count - 1;
            Console.WriteLine($"Opened tab {tabs.Count}: {url}");
        }

        public void NavigateBack()
        {
            if (currentTab > 0)
            {
                currentTab--;
                Console.WriteLine($"Navigated to tab {currentTab + 1}: {tabs[currentTab]}");
            }
            else
            {
                Console.WriteLine("You are already on the first tab. BACK is disabled.");
            }
        }

        public void ViewCurrentTab()
        {
            if (currentTab >= 0)
            {
                Console.WriteLine($"Current tab: {tabs[currentTab]}");
            }
            else
            {
                Console.WriteLine("No tab is open.");
            }
        }

        public void ShowAllTabsInReverseOrder()
        {
            if (tabs.Count == 0)
            {
                Console.WriteLine("No tabs are open.");
                return;
            }

            for (int i = tabs.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"Tab {i + 1}: {tabs[i]}");
            }
        }
    }
}