

namespace Wittcher_arena_OOP
{
    public class Inventory1
    {
        private List<string> items = new List<string>();


        public void AddItem(string item)
        {
            if (!items.Contains(item))

                items.Add(item);

        }
        public bool Contains(string item)
        {
            return items.Contains(item);
        }
        public bool RemoveItem(string item)
        {
            return items.Remove(item);
        }
        public void Print()
        {
            Console.WriteLine("INVENTAR");
            if (items.Count == 0)
                Console.WriteLine("Inventar je prazdny");
            else
            {
                foreach (string item in items)
                    Console.WriteLine($"{item}");
            }
        }
    }
}















