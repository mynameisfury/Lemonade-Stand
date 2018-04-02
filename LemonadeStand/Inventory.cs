using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //Item item = new Item();
        Lemon lemon = new Lemon();
        Ice ice = new Ice();
        Sugar sugar = new Sugar();
        Cup cup = new Cup();
        List<Item> numberOfLemons = new List<Item>();
        List<Item> numberOfSugar = new List<Item>();
        List<Item> numberOfCups = new List<Item>();
        List<Item> numberOfIceCubes = new List<Item>();

        //public int NumberToAdd;
        //public Item itemsToAdd;


        //public void AddItem(Item itemsToAdd, int NumberToAdd)
        //{
        //    for (int i = 0; i < NumberToAdd; i++) 
        //    items.Add();
        //}
        public void AddLemons(int NumberToAdd)
        {
            for (int i = 0; i < NumberToAdd; i++)
            {
                numberOfLemons.Add(lemon);
            }
        }
        public void AddIce(int NumberToAdd)
        {
            for (int i = 0; i < NumberToAdd; i++)
            {
                numberOfIceCubes.Add(ice);
            }
        }
        public void AddCups(int NumberToAdd)
        {
            for (int i = 0; i < NumberToAdd; i++)
            {
                numberOfCups.Add(cup);
            }
        }
        public void AddSugar(int NumberToAdd)
        {
            for (int i = 0; i < NumberToAdd; i++)
            {
                numberOfSugar.Add(sugar);
            }
        }
        public void DisplayItems()
        {
            Console.WriteLine("You have: " + numberOfCups.Count + " cups");
            Console.WriteLine("You have: " + numberOfSugar.Count + " cups of sugar");
            Console.WriteLine("You have: " + numberOfLemons.Count + " lemons");
            Console.WriteLine("You have: " + numberOfIceCubes.Count + " ice cubes");
        }
    }
}
