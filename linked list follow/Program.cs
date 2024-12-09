namespace linked_list_follow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Add(new House
            {
                HouseId = 1,
                HouseNumber = 101,
                StreetName = "Maple Street",
                City = "Springfield",
                State = "IL",
                Country = "USA",
                ZipCode = "62704",
                HouseStyle = HouseStyle.Colonial
            });

            list.Add(new House
            {
                HouseId = 2,
                HouseNumber = 202,
                StreetName = "Oak Avenue",
                City = "Springfield",
                State = "IL",
                Country = "USA",
                ZipCode = "62705",
                HouseStyle = HouseStyle.Modern
            });

            // Display the list
            Console.WriteLine("All houses in the list:");
            list.Display();

            // Find a specific house
            int searchNumber = 101;
            House foundHouse = list.FindElement(searchNumber);
            if (foundHouse != null)
            {
                Console.WriteLine($"\nFound house: {foundHouse.HouseNumber}, {foundHouse.StreetName}, {foundHouse.City}, {foundHouse.HouseStyle}");
            }
            else
            {
                Console.WriteLine($"\nHouse with number {searchNumber} not found.");
            }
        }
    }
}
    

