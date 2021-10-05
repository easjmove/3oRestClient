using _3oRestClient.Models;
using System;
using System.Collections.Generic;

namespace _3oRestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            Worker _worker = new Worker();

            Item newItem = new Item 
            { Id = 1, ItemQuality = 6, Quantity = 7, Name = "Test item" };

            Item responseItem = _worker.PostItem(newItem).Result;
            Console.WriteLine($"{responseItem.Name} - {responseItem.Id}");
            Console.WriteLine();

            IEnumerable<Item> items = _worker.GetAllItems().Result;
            foreach (Item _item in items)
            {
                Console.WriteLine($"{_item.Name} - {_item.Id}");
            }
        }
    }
}
