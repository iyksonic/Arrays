using System;
using System.Collections.Generic;

//Create a class that implements an integer list class, has an add method and uses an internal integer array to store data

//Create an array class that adds strings and retrieves the string at a particular index.
//use a get method and a remove method from the index

namespace Data_Structures
{
    class Program
    {
        public static void Main(string[] args)
        {
            //string[] letters = new string[3] {"one", "two", "three"};
            //string[,] names = new string[2, 2] { { "mike", "jone" }, {"mark", "paul"} };
            //string[] team = new string[] { "uk", "sci" };

            string[] message = new string[6];
            message[0]="You";
            message[1]="are";
            message[2]="Welcome";
            message[3]="to";
            message[4]="Sci";
          
            myArray ma = new myArray();
            ma.addString(message, 5, "idea");
            ma.retrieveString(message, 5);
         
         


            foreach(string s in message)
            {
                Console.WriteLine(s);
            }
            
            Console.Write("Press any key to continue . . . ");            
          
            Console.ReadLine();
        }      
        
    }
    
    
    public class myArray
    {
        public void addString(string[] value, int index, string values)
        {
            value[index] = values;
            
        }

        public void retrieveString(string[] value, int index)
        {
            Console.WriteLine(value[index]);
        }
    }
}