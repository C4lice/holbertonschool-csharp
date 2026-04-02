***C# - Generics***
 Master
 By: Carrie Ybay, Software Engineer at Holberton School
 Weight: 1
 Your score will be updated as you progress.
Description
Quiz
Background Context
In this project, you will implement a Queue in C# with a singly linked list and generics. You are not allowed to use System.Collections or System.Collections.Generic for this project.

**Resources**
Read or watch:

Generics (C# Programming Guide) (Read sections "Introduction to Generics" up to and including "Generics and Arrays")
Generics in .NET
C# Generics Tutorial: Whats and Whys
Access Modifiers (C# Programming Guide)
Covariance and Contravariance in Generics
Covariance and Contravariance with C#

---
***Learning Objectives***
At the end of this project, you are expected to be able to explain to anyone, without the help of Google:
**General**
What are generics and what are their purpose
What common generic classes and interfaces are provided in the .NET class **library**
When and how to create generic classes
When and how to create generic methods
How access modifiers affect a class and its members
What is the default(T) expression used for
What is covariance and contravariance

---
***Requirements***
**General**
Allowed editors: Visual Studio Code
All files will be compiled on Ubuntu 20.04 LTS using dotnet
A README.md file, at the root of the folder of the project, is mandatory
All default C# files named Program.cs should be renamed to the name given in each task.
Each C# task requires its own folder and .csproj file. Push all task folders to your GitHub and ensure the task names on the folders are correct
You do not need to push your obj/ or bin/ folders
In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
All your public classes and their members should have XML documentation tags
All your private classes and members should be documented but without XML documentation tags

---
[🔗](https://github.com/C4lice/holbertonschool-csharp/blob/main/csharp-generics/0-queue/queue.cs)0. Queue
Create a new class called Queue<T>.

Queue<T> should not inherit from other classes or interfaces.
Within Queue<T>, create a new method CheckType() that returns the Queue's type.
You are not allowed to use System.Collections or System.Collections.Generic for this project.
NOTE: Your file name for this task will be queue.cs not 0-queue.cs because we will be using this file in subsequent tasks.

---
[🔗](https://github.com/C4lice/holbertonschool-csharp/blob/main/csharp-generics/1-enqueue/queue.cs)1. Enqueue
Based on 0-queue, within Queue<T>, create a public class called Node with the following properties:

value: can be of any type, set its initial value to null
next: must be an object of type Node, set its initial value to null
Define a constructor that takes a value for a new Node as its only parameter and sets it
Within Queue<T>, add the following properties:

head: must be an object of type Node
tail: must be an object of type Node
count: type int
Add a new method Enqueue() to the class Queue that creates a new Node and adds it to the end of the queue.

If the queue is empty, the method should make the new node the head of the queue
count should update every time a new node is added
Add a new method Count() to the class that returns the number of nodes in the Queue.

---
[🔗](https://github.com/C4lice/holbertonschool-csharp/blob/main/csharp-generics/2-dequeue/queue.cs)2. Dequeue
Based on 1-enqueue, add a new method Dequeue() to the class Queue<T> that removes the first node in the queue and returns its value.

If the queue is empty, the method should write Queue is empty to the console and return the default value of the parameter's type

---
[🔗](https://github.com/C4lice/holbertonschool-csharp/blob/main/csharp-generics/3-peek/queue.cs)3. Peek
Based on 2-dequeue, add a new method Peek() to the class Queue<T> that returns the value of the first node of the queue without removing the node.

If the queue is empty, the method should write Queue is empty to the console and return the default value of the parameter's type

---
