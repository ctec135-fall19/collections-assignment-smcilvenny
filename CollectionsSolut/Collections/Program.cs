using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections

    //Sean McIlvenny
    // 10/28/19
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Arrays and Lists

            int[] myArray = new int[6]; //Initialize array  
            for (int i = 1; i < myArray.Length; i++) //For loop to traverse through array and add values
            {
                myArray[i] = i + 10;
                Console.WriteLine(myArray[i]); //print out values
            }
            Console.WriteLine();



            List<int> myList = new List<int>(); //Initialize list
            for (int i = 0; i < 5; i++) // for loop to add values to list
            {
                myList.Add(i + 21);
            }
            foreach (int element in myList)
            {
                Console.WriteLine(element); //print out the values in the list
            }
            Console.WriteLine();

            myList[0] = 31;  // adding values using index notation
            myList[1] = 32;
            myList[2] = 33;
            myList[3] = 34;
            myList[4] = 35;
        
            for (int i = 0; i < myList.Count; i++) //for loop to traverse thru list
            {
                Console.WriteLine(myList[i]); //and print out values
            }
            Console.WriteLine();

            #endregion

            #region STacks and Queues

            Stack<int> myStack = new Stack<int>(); //Initialize stack and add elements to it
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            foreach (int number in myStack) //foreach loop to go through and print the elements 
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            Console.WriteLine("Peeking at: {0}",myStack.Peek()); //Peeking at the last number

            int cnt = myStack.Count; //initializing the count to a variable for laziness
            for (int i = 0; i<cnt; i++)//loop to traverse thru the stack and pop off elements
            {
                Console.WriteLine(myStack.Pop());
            }
            Console.WriteLine();
            Console.WriteLine("New Count of stack: {0}",myStack.Count); //After going thru the loop popping the elements off count goes to 0
            Console.WriteLine();


            Queue<int> myQ = new Queue<int>(); //Initialize new queue and add values
            myQ.Enqueue(1);
            myQ.Enqueue(2);
            myQ.Enqueue(3);
            myQ.Enqueue(4);
            myQ.Enqueue(5);
            foreach(int element in myQ) // foreach loop to print values
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            Console.WriteLine("Peek at top: {0}",myQ.Peek()); // peek within the queue
            Console.WriteLine();

            for (int i=0; i < myQ.Count; i++ ) // for loop to go thru and dequeue values thru out the queue
            {
                Console.WriteLine(myQ.Dequeue());
            }
            Console.WriteLine();
           


            #endregion

            #region Dictionary
            Dictionary<int, string> myDict = new Dictionary<int, string>(); //initialize dictionary and add keys/values
            myDict.Add(1, "one");
            myDict.Add(2, "two");
            myDict.Add(3, "three");

            myDict.Add(99, "ninety-nine"); // add another key/value

            foreach (KeyValuePair<int,string> element in myDict) //foreach loop to print out keys and values
            {
                Console.WriteLine("key: {0}, Value: {1}", element.Key, element.Value);
            }

            myDict[99] = "99"; //changing values with index notation

            Console.WriteLine(myDict[99]); //print out change

            myDict.Remove(99); //remove the change
            myDict.Remove(3); //remove index 3

            foreach (KeyValuePair<int, string> element in myDict) //reprint out keys and value to see difference
            {
                Console.WriteLine("key: {0}, Value: {1}", element.Key, element.Value);
            }
            Console.WriteLine();

            #endregion

            #region Linked Lists
            //everything ive tried here i cant get to work and just get errors or it wont even run!

            string[] lyrics;
            lyrics = new string[6] { "Im", "having", "trouble", "trying", "to", "sleep" };

            LinkedList<string[]> myLinked = new LinkedList<string[]>(lyrics);


            
            
            





            #endregion



        }
    }
}
