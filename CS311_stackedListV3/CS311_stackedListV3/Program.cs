using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//   T RemoveHeadNode() (remove the first Node and return its value)
//   T RemoveTailNode() (remove the last Node and return its value)
//   void InsertAfter(Node p, T newvalue) (insert a new node with value newvalue  after node p )
//   void RemoveAfter(Node p) (remove the node after node p )

namespace CS311_stackedListV3
{
    public class Node
    {
        public Node Next;
        public object Value;
    }

    public class LinkedList
    {
        private Node head;
        private Node current;//This will have latest node
        public int Count;
        //Constructor
        public LinkedList()
        {
            head = new Node();
            current = head;
        }
        //Methods
        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Count++;
        }
        public bool isEmpty()        
        {
            if (head == null)
                return true;       
            else
                return false;       
        }
        public void RemoveFromEnd()
        {
            Node curr = head;
            while (curr.Next.Next != null)
            {
                curr = curr.Next;
            }
            curr.Next = null;
        }
        public void AddAtStart(object data)
        {

        }
        public void RemoveFromStart()
        {

        }
        public int RemoveHeadNode()
        {
            Node newNode = new Node();
            if (head == null)
            {
                return 0;           
            }
            else
            {
                Node current = head;
                newNode.Value = current.Value;
                head = head.Next;
                current = null;          
                return Convert.ToInt32(newNode.Value);
            }
        }
        public int RemoveTailNode()
        {
            if (head == null)
            {
                return 0;             
            }
            else
            {
                Node newNode = new Node();
                Node current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;       
                }
                newNode.Value = current.Next.Value;

                current.Next = null;            
                return Convert.ToInt32(newNode.Value);
            }
        }

        // Add more methods here, as required in your assignment

        /// Traverse from head and print all nodes value
        public void InsertHeadNode(Object data)
        {
            Node newNode = new Node();

            newNode.Value = data;        
            newNode.Next = head;
            head = newNode;
        }
        public void InsertAfterNode(Object data, int node)
        {
            if (head == null)
            {
                Console.WriteLine("empty..");
            }
            else
            {
                Node newNode = new Node();
                Node temp = new Node();
                newNode.Value = data;
                Node current = head;
                int nodeCount = 1;        
                while (current.Next != null)
                {
                    if (nodeCount == node)
                    {           
                        temp = current.Next;
                        current.Next = newNode;
                        newNode.Next = temp;        
                        break;
                    }
                    else
                    {
                        current = current.Next;
                        nodeCount++;
                    }
                }
                if (node > nodeCount)
                    Console.WriteLine("out of range..");
            }
        }

        public void RemoveAfterNode(int node)
        {
            if (head == null)
            {
                Console.WriteLine("empty..");
            }
            else
            {
                Node temp = new Node();
                Node current = head;
                int nodeCount = 1;        //To traverse from first
                while (current.Next != null)
                {
                    if (nodeCount == node)
                    {
                        temp = current.Next;
                        current.Next = temp.Next;
                        temp = null;        //Deleting after node..
                        break;
                    }
                    else
                    {
                        current = current.Next;
                        nodeCount++;
                    }
                }
                if (node > nodeCount)
                    Console.WriteLine("out of range..");
            }
        }
        public void InsertTailNode(Object data)
        {
            if (head == null)
            {
                head = new Node();    //Inserting at end...
                head.Value = data;
                head.Next = null;
            }
            else
            {
                Node newNode = new Node();
                newNode.Value = data;
                Node current = head;
                while (current.Next != null)    //Traversing the list
                {
                    current = current.Next;
                }
                current.Next = newNode;    //Inserting at end...
            }
        }
        public void PrintList()
        {
            Node current = head;    

            while (current != null)   
            {
                Console.Write(current.Value + " ");    
                current = current.Next;
            }
            Console.WriteLine();
        }
        public void PrintAllNodes()
        {
            //Traverse from head
            Console.Write("Head ->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.Write("NULL");
        }
        public int findNode(int node)
        {                                   
            if (head == null)
            {
                Console.WriteLine("empty..");
                return 0;
            }
            else
            {
                Node current = head;
                int nodeCount = 1;
                while (current.Next != null)
                {                                           
                    if (Convert.ToInt32(current.Value) == node)
                    {
                        return nodeCount;
                    }
                    current = current.Next;
                    nodeCount++;
                }
                Console.WriteLine("value not present in the list..");
            }
            return 0;
        }
    }

    //To test our code, we will write main method and call linked list and its operations in that. Add your testing method calls here to test all your methods.

    class Program
    {
        static void Main(string[] args)
        {

            string data;
            int intData = 0;
            int choice = 1;
            LinkedList list = new LinkedList();

            while (choice != 0)
            {

                int ch;

                Console.Write("\nMenu list:\n");
                Console.Write("\t1. To check list is Empty\n");
                Console.Write("\t2. To Insert at HeadNode\n");
                Console.Write("\t3. To Insert at TailNode\n");
                Console.Write("\t4. To Remove Head Node\n");
                Console.Write("\t5. To Remove Tail Node\n");
                Console.Write("\t6. To Insert after Node\n");
                Console.Write("\t7. To Remove after Node\n");
                Console.Write("\t8. To find the Node\n");
                Console.Write("\t9. To Print list elements\n");

                Console.Write("Enter the choice : ");
                data = Console.ReadLine();
                ch = Convert.ToInt32(data);

                switch (ch)
                {
                    case 1:
                        if (list.isEmpty())
                            Console.WriteLine("List is empty");
                        else
                            Console.WriteLine("List is not empty");
                        break;
                    case 2:
                        Console.WriteLine("\nInsert at HeadNode:\n");
                        Console.Write("Enter any value: ");
                        data = Console.ReadLine();
                        intData = Convert.ToInt32(data);
                        list.InsertHeadNode(intData);
                        break;

                    case 3:
                        Console.WriteLine("\nInsert at TailNode:\n");
                        Console.Write("Enter any value: ");
                        data = Console.ReadLine();
                        intData = Convert.ToInt32(data);
                        list.InsertTailNode(intData);
                        break;

                    case 4:
                        Console.WriteLine("\nRemove HeadNode:\n");
                        intData = list.RemoveHeadNode();
                        Console.WriteLine("\nRemoved data : " + intData);
                        break;

                    case 5:
                        Console.WriteLine("\nRemove TailNode:\n");
                        intData = list.RemoveTailNode();
                        Console.WriteLine("\nRemoved data : " + intData);
                        break;

                    case 6:
                        Console.WriteLine("\nInsert after at HeadNode:\n");
                        Console.Write("Enter the node after the value to be inserted: ");
                        data = Console.ReadLine();
                        ch = Convert.ToInt32(data);
                        Console.Write("Enter the any value: ");
                        data = Console.ReadLine();
                        intData = Convert.ToInt32(data);
                        list.InsertAfterNode(intData, ch);
                        break;
                    case 7:
                        Console.WriteLine("\nRemove after at HeadNode:\n");
                        Console.Write("Enter the node after the value to be inserted: ");
                        data = Console.ReadLine();
                        ch = Convert.ToInt32(data);
                        list.RemoveAfterNode(ch);
                        break;

                    case 8:
                        Console.WriteLine("\nFind the node:\n");
                        Console.Write("Enter the value of node to be found: ");
                        data = Console.ReadLine();
                        ch = Convert.ToInt32(data);
                        ch = list.findNode(ch);
                        Console.WriteLine("\nNode found at location [" + ch + "]");
                        break;

                    case 9:
                        Console.WriteLine("\nPrint List:\n");
                        list.PrintList();
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;

                }
            }
        }
    }
}
