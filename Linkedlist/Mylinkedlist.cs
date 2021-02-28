using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist
{
   public class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
        }
        public void AddNode(Node node)
        {
            //Check wheather the list is empty then creates node as head
            if (head == null && tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                //If node than add new node as head 
                node.next = head;
                head = node;
            }
        }

        public void Append(int data)
        {
            //Create new node 
            Node node = new Node(data);
            //Check if list is empty then node becomes as head
            if(this.head  == null)
            {
                this.head = node;
            }
           
            else
            {
                //If not then put head in temp variable
                Node temp = head;
                
                while(temp.next != null)
                    //Check until node next location is null so all node can added
                {
                    //Temp variable changed so next node can add
                    temp = temp.next;
                }
                temp.next = node;
            }

            Console.WriteLine("Added  at start of the linkedlist is :" +data);
        }
        public void AddNodeAtStart(int data)
        {
            //Create node to add in linked list
            Node node = new Node(data);
            //Check if list is empty then new node become head node
            if (this.head == null)
            {
                this.head = node;
            }
            if (this.tail == null)
            {
                this.tail = node;

            }
            else
            {
                //New node loction will stores the address of previous node
                node.next = head;
                //Node become head
                head = node;
            }
            Console.WriteLine("Added at start of the linkedlist is:"+ data);
        }
        public void DeleteNodeAtFirst()
        {
            //Check list is empty or not
            if (this.head == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
                
            }
            //Put temp variable become head in list
            Node temp = this.head;
            //Change head to next node to delete the previous node
            this.head = this.head.next;

            Console.WriteLine("Removed from linkedlist :" + temp.data);
        }
        public void DeleteNodeAtLast()
        {
            //Checked the list is empty or not
            if (this.head == null)
            {
                Console.WriteLine("Nothing To Delete");
                
            }
            //Temp variable will become head of the list now
            Node temp = this.head;
            //Check until the temp next nodes's next loction is null
            while (temp.next.next != null)
            {
                //For traversing through the list
                temp = temp.next;
            }
            //After getting this node change its location to null
            temp.next = null;
        }
        public bool Search(int data)
        {
            //Temp variable is head now
            Node temp = this.head;
            //Check until temp location will null
            while (temp != null)
            {
                //If temp node data is equal to value to be searched
                if (temp.data == data)
                {
                    
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void AddNodeAfterNode(int nodedata, int addAfterthatValue)
        {
            //Create new node which are going to add
            Node newNode = new Node(nodedata);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                //Checking until temp variable data equal to the previous value of value to be added
                while (temp.data != addAfterthatValue)
                {
                    //For traversing through list
                    temp = temp.next;
                }
                //new node stores  next node position
                newNode.next = temp.next;
                //new node location will be previous node next position
                temp.next = newNode;

            }
            Console.WriteLine($"Added {nodedata} at in between");
        }


        public void Display()
        {
            //temp variable will head
            Node temp = head;
            //Check wheather list is empty or not 
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                
            }
            while(temp!=null)
            {
                //Check until temp will null
                Console.Write(temp.data + " ");
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                //for traversing the node
                temp = temp.next;
            }
            Console.WriteLine();
           
            
        }
        public void DeleteNodeWithdata(int data)
        {
            //Check wheather list is empty or not
            if (head == null)
            {
                Console.WriteLine("No data to delete");
            }
            
            Node prev = this.head;
            // pointsTovalue variable is head 
            Node pointsToValue = this.head;
            //Check until it reach to the value to be deleted
            while (pointsToValue.data != data)
            {
                
                if (pointsToValue == null)
                {
                    break;
                }
                //For traversing through the list
                pointsToValue = pointsToValue.next;
            }
            //Check until we get the previous node of node to be deleted
            while (prev.next.data != data)
            {
                if (prev == null)
                {
                    break;
                }
                //For traversing through the list
                prev = prev.next;
            }
            //Change location of previous node to node to be deleted location
            prev.next = pointsToValue.next;

        }
      
    }
}

