using System;

// <summary>Generic Queue class</summary>
class Queue<T>
{
    Node head;
    Node tail;
    int count;

// Returns the type of the generic parameter T
    public Type CheckType()
    {
        return typeof(T);
    }

// Classe interne représentant un nœud de la file
    public class Node
    {
        public object value = null;
        public Node next = null;

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

// Adds a new node with the given value to the end of the queue
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

// Returns the value of the first node and removes it from the queue
    public object Dequeue()
    {
        if (head == null)
        {
           Console.WriteLine("Queue is empty");
           return default(T);
        }
        else
        {
            Node tmp = head;
            head = tmp.next;
            count--;
            return tmp.value;
        }
    }

// Returns the value of the first node without removing it from the queue
    public object Peek()
    {
        if (head == null)
        {
           Console.WriteLine("Queue is empty");
           return default(T);
        }
        else
        {
            return head.value;
        }
    }

//  Returns the number of nodes currently in the queue
    public void Print()
    {
        if (head == null)
        {
           Console.WriteLine("Queue is empty");
        }
        else
        {
            Node tmp = head;
            while (tmp.next != null)
            {
                Console.WriteLine(tmp.value);
                tmp = tmp.next;
            }
            Console.WriteLine(tmp.value);
        }
    }

// Concatenates all the values in the queue into a single string, separated by spaces if T is string
    public string Concatenate()
    {
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
           Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
           return null;
        }

        if (head == null)
        {
           Console.WriteLine("Queue is empty");
           return null;
        }
        else
        {
            string result ="";
            Node tmp = head;
            while (tmp.next != null)
            {
                result += tmp.value;
                if (typeof(T) == typeof(string))
                {
                    result += " ";
                }
                tmp = tmp.next;
            }
            result += tmp.value;
            return result;
        }
    }

// Returns the number of nodes currently in the queue
    public int Count()
    {
        return count;
    }
}
