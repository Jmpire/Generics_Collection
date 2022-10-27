using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array
            int[] ages = {19, 25, 42, 67, 2};

            // For loop, Variable, decision, increment
            Console.WriteLine("Array: ");
            for (int x = 0; x < ages.Length; x++)
            {
                if (ages[x] >= 25)
                {
                    Console.Write(ages[x] + " ");
                }
                
            }

            // List, add, RemoveAt, sort
            List<char> letters = new List<char>();
            letters.Add('A');
            letters.Add('B');
            letters.Add('C');

            // Remove at a position
            letters.RemoveAt(2);
            Console.WriteLine("\n\nList: ");
            foreach (char letter in letters)
            {
                Console.Write(letter + " ");
            }

            // Stack, LIFO Last In, First Out
            // Push, Pop, Peek, Clear, ToArray
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            // Remove top element
            int removed = numbers.Pop();
            Console.WriteLine("\n\nStack: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine($"\nRemoved value: {removed}, Top value: {numbers.Peek()}");

            // Queue, FIFO, First In, First Out
            // Enqueue, dequeue, clear, Peek, ToArray, Contains
            Queue<string> people = new Queue<string>();
            people.Enqueue("Fiina");
            people.Enqueue("Vijanda");
            people.Enqueue("Mekere");

            // Remove person in front
            string removedName = people.Dequeue();
            Console.WriteLine("\nQueue: ");
            foreach (string person in people)
            {
                Console.Write(person + ", ");
            }
            Console.WriteLine($"\nRemoved person: {removedName}, Person in front: {people.Peek()}");
        }
    }
}