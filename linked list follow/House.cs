using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace linked_list_follow
{
    public enum HouseStyle { Colonial, Ranch, Victoria, Modern }

    public class House
    {
        public int HouseId { get; set; }
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public HouseStyle HouseStyle { get; set; }
    }

    public class Node
    {
        internal House Data { get; set; }
        internal Node Next { get; set; }

        public Node(House house)
        {
            Data = house;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node Head { get; set; }
        public int Length { get; private set; } // Automatically track the length

        public LinkedList()
        {
            Head = null;
            Length = 0;
        }

        // Add a new house to the end of the list
        public void Add(House house)
        {
            Node newNode = new Node(house);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            Length++;
        }

        // Find a house by house number
        public House FindElement(int houseNumber)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data.HouseNumber == houseNumber)
                {
                    return current.Data;
                }
                current = current.Next;
            }
            return null; // Not found
        }

        // Display all houses in the list
        public void Display()
        {
            Node current = Head;
            while (current != null)
            {
                Console.WriteLine($"House Number: {current.Data.HouseNumber}, Street: {current.Data.StreetName}, City: {current.Data.City}, Style: {current.Data.HouseStyle}");
                current = current.Next;
            }
        }
    }
}