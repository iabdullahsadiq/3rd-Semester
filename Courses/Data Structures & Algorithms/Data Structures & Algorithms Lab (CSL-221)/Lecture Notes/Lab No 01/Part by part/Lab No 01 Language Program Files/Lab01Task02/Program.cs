using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Task02
{
    class Program
    {
        static string[] inventory = new string[50]; // Max inventory size of 50
        static int itemCount = 0;
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Inventory Management System");
                Console.WriteLine("1: Add Item");
                Console.WriteLine("2: Remove Item");
                Console.WriteLine("3: Search Item");
                Console.WriteLine("4: Display Inventory");
                Console.WriteLine("5: Exit");
                Console.Write("Select an option (1-5): ");
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddItem();
                            break;
                        case 2:
                            RemoveItem();
                            break;
                        case 3:
                            SearchItem();
                            break;
                        case 4:
                            DisplayInventory();
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please choose a valid option (1-5).");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number (1-5).");
                }
                Console.WriteLine();
            }
        }
        static void AddItem()
        {
            if (itemCount < inventory.Length)
            {
                Console.Write("Enter the name of the item to add: ");
                string newItem = Console.ReadLine();
                inventory[itemCount] = newItem;
                itemCount++;
                Console.WriteLine($"Item '{newItem}' added to inventory.");
            }
            else
            {
                Console.WriteLine("Inventory is full. Cannot add more items.");
            }
        }
        static void RemoveItem()
        {
            Console.Write("Enter the name of the item to remove: ");
            string itemToRemove = Console.ReadLine();
            bool itemFound = false;
            for (int i = 0; i < itemCount; i++)
            {
                if (inventory[i] == itemToRemove)
                {
                    // Shift items to fill the gap
                    for (int j = i; j < itemCount - 1; j++)
                    {
                        inventory[j] = inventory[j + 1];
                    }
                    itemCount--;
                    itemFound = true;
                    Console.WriteLine($"Item '{itemToRemove}' removed from inventory.");
                    break;
                }
            }
            if (!itemFound)
            {
                Console.WriteLine($"Item '{itemToRemove}' not found in inventory.");
            }
        }
        static void SearchItem()
        {
            Console.Write("Enter the name of the item to search for: ");
            string itemToSearch = Console.ReadLine();
            bool itemFound = false;
            for (int i = 0; i < itemCount; i++)
            {
                if (inventory[i] == itemToSearch)
                {
                    Console.WriteLine($"Item '{itemToSearch}' found in inventory.");
                    itemFound = true;
                    break;
                }
            }
            if (!itemFound)
            {
                Console.WriteLine($"Item '{itemToSearch}' not found in inventory.");
            }
        }
        static void DisplayInventory()
        {
            if (itemCount > 0)
            {
                Console.WriteLine("Inventory:");
                for (int i = 0; i < itemCount; i++)
                {
                    Console.WriteLine($"{i + 1}: {inventory[i]}");
                }
            }
            else
            {
                Console.WriteLine("Inventory is empty.");
            }
        }
    }
}
