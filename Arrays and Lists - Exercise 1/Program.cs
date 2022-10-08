using System;
using System.Collections.Generic;

namespace Arrays_and_Lists___Exercise_1
{
    internal class Program
    {
        /*  INSTRUCTIONS (from source)
          
            1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            If no one likes your post, it doesn't display anything.
            If only one person likes your post, it displays: [Friend's Name] likes your post.
            If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
        
            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
        
            Depending on the number of names provided, display a message based on the above pattern.
        */


        static void Main(string[] args)
        {
            List<string> listOfInputNames = new List<string>();

            while (true)
            {
                Console.WriteLine("Please enter a random name or press ENTER key to escape/finish the program...");
                string userInputName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInputName)) break;                
                
                listOfInputNames.Add(userInputName);
            }

            if (listOfInputNames.Count > 2)
                Console.WriteLine($"{listOfInputNames[0]}, {listOfInputNames[1]} and {listOfInputNames.Count - 2} others liked your post!");
            else if (listOfInputNames.Count == 2)
                Console.WriteLine($"{listOfInputNames[0]} and {listOfInputNames[1]} liked your post!");
            else if (listOfInputNames.Count == 1)
                Console.WriteLine($"{listOfInputNames[0]} liked your post!");
            else if (listOfInputNames.Count < 1) //KISS//
                Console.WriteLine("YOU HAVE NO FRIENDS!");


        }
    }
}
