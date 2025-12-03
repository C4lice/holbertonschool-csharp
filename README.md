# holbertonschool-csharp


```
***PLD 03.12.25***
**PLD Questions:**


**What is the purpose of the Main method in a C# program?**
**Quel est le rôle de la méthode Main dans un programme C# ?**

C’est le point d’entrée du programme.

**How do you write a "Hello, World!" program in C#? Provide the code.**
**Comment écrire un programme « Hello, World ! » en C# ? Fournissez le code.**

System.Console.WriteLine(“Hello, World!”);

**What does the using System; directive do in a C# program?**
**Que fait la directive using System; dans un programme C# ?**

Utilise le namespace.

**Why is the Console.WriteLine method used in the "Hello, World!" program?**
**Pourquoi la méthode Console.WriteLine est-elle utilisée dans le programme « Hello, World ! » ?**

Pour imprimer la ligne dans le buffer stdout (dans le terminal).

**What is the significance of the static keyword in the Main method?**
**Quelle est la signification du mot-clé static dans la méthode Main ?**

C’est pour signifier que la donnée ou la méthode appartient à la classe et non à une instance de la classe. 

**How do you execute a C# program that prints "Hello, World!"?**
**Comment exécuter un programme C# qui affiche « Hello, World ! » ?**

dotnet run <nom_dossier_application>

**Can you print "Hello, World!" without using the Console class? If so, how?**
**Pouvez-vous afficher « Hello, World ! » sans utiliser la classe Console ? Si oui, comment ?**

Oui. On peut importer la dll du runtime C et récupérer puis appeler la méthode printf.

using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern int printf(string format);

    static void Main()
    {
        printf("Hello, World!\n");
    }
}

**How would you modify the program to take user input and then greet them by name?**
**Comment modifieriez-vous le programme pour qu'il prenne en compte les informations saisies par l'utilisateur et le salue ensuite par son nom ?**

Il faut appeler Console.ReadLine, puis Console.WriteLine avec le contenu de Console.ReadLine; ou alors utiliser InputBox.

**What happens if you remove the semicolon at the end of the Console.WriteLine statement?**
**Que se passe-t-il si vous supprimez le point-virgule à la fin de l'instruction Console.WriteLine ?**

Ca créer simplement une erreur car le parseur ne sait plus quand termine la méthode.

**How can you include escape sequences (e.g., \n or \t) in the "Hello, World!" message?**
**Comment inclure des séquences d'échappement (par exemple, \n ou \t) dans le message « Hello, World ! » ?**

Il faut rajouter un backslash ‘\’ au caractère et le mettre là où on veut dans le string.

-------------------------------------------------------------------------------------------------------------------------------------------

**What is the syntax for an if statement in C#? Provide an example.**
**Quelle est la syntaxe d'une instruction if en C# ? Donnez un exemple.**

using System;
	int i = 0;
if(i){Console.WriteLine(“Vrai”);}

**How does an if-else statement work? Write a program to check if a number is positive or negative.**
**Comment fonctionne une instruction if-else ? Écrivez un programme permettant de vérifier si un nombre est positif ou négatif.**

using System;
	int i = 0;
if(i){Console.WriteLine(“Vrai”);}
else{}


**What is a nested if statement, and when would you use it? Give an example.**
**Qu'est-ce qu'une instruction if imbriquée, et quand l'utilise-t-on ? Donnez un exemple.**

	C’est quand on doit créer un branchement dans un branchement.
using System;
	int i = 0, j = 0;
	if(i){
		if(j){}
	}


**Can you use a single-line if statement in C#? How? Provide an example.**
**Peut-on utiliser une instruction if sur une seule ligne en C# ? Comment ? Donnez un exemple.**

Oui.
using System;
int i = 0;
if(i) Console.WriteLine(“1 line”);

**What is the difference between if and else if? When should you use else if?**
**Quelle est la différence entre if et else if ? Quand faut-il utiliser else if ?**

La condition est d’office fausse lorsque la condition complémentaire est vraie. On l’utilise lorsque l’on veut qu’une condition invalide une autre.

**How would you use the ternary operator as an alternative to if-else? Provide an example.**
**Comment utiliseriez-vous l'opérateur ternaire comme alternative à if-else ? Donnez un exemple.**

Lorsque l’on a un seul if else qui a pour conséquence une assignation de valeur. C’est pour avoir une syntaxe plus courte.

**Write a program that checks if a number is divisible by both 3 and 5 using an if-else statement.**
**Écrivez un programme qui vérifie si un nombre est divisible à la fois par 3 et par 5 à l'aide d'une instruction if-else.**

using System;
int i = 0;
if(i % 3 == 0 && i % 5 == 0){Console.WriteLine(“Vrai”);}
else{Console.WriteLine(“Faux”);}

**What is a for loop in C#? Write a program to print numbers from 1 to 10 using a for loop.**
**Qu'est-ce qu'une boucle « for » en C# ? Écrivez un programme qui affiche les nombres de 1 à 10 à l'aide d'une boucle « for ».**

	Une boucle for permet d'itérer un nombre défini de fois sur un ensemble    d’instructions.
using System;
for(int i = 1; i < 11; i++){
	Console.WriteLine(i);
}

**How does a while loop differ from a for loop? Provide an example for each.**
**En quoi une boucle while diffère-t-elle d'une boucle for ? Donnez un exemple pour chacune d'elles.**

	Une boucle while s'exécute tant qu’une condition est vraie, le nombre d’itérations n’est donc pas nécessairement défini.
	int i = 1;
	while(i < 11){
		Console.WriteLine(i);
		i++;
}

**What is a do-while loop, and how is it different from a while loop? Provide a code example.**
**Qu'est-ce qu'une boucle do-while et en quoi diffère-t-elle d'une boucle while ? Donnez un exemple de code.**

Le bloc s’exécute au moins une fois, même si la condition est fausse dès le départ
	Une boucle do while permet d'exécuter le code et de passer à l’itération suivante si la condition est vraie, donc ca exécute le code avant de vérifier la condition.
	int i = 1;
	do{
		Console.WriteLine(i);
		i++;
}
	while(i < 10);

**Write a program that calculates the sum of all even numbers from 1 to 50 using a for loop.**
**Écrivez un programme qui calcule la somme de tous les nombres pairs compris entre 1 et 50 à l'aide d'une boucle « for ».**

int j = 0;
	for(int i = 1; i < 51; i++){
		j+= i;
}

**What is the foreach loop used for in C#? Provide an example with an array.**
**À quoi sert la boucle foreach en C# ? Donnez un exemple avec un tableau.**

	Ca boucle le type dans une collection (tableau, …).
	int i[] tab = {1,2,3,4,5}
foreach(int elem in tab){
Console.WriteLine(elem);
}


**How do you break out of a loop prematurely in C#? Provide an example using the break statement.**
**Comment sortir prématurément d'une boucle en C# ? Donnez un exemple utilisant l'instruction break.**

	il faut simplement executer break;
	int i[] tab = {1,2,3,4,5}
foreach(int elem in tab){
	if(elem > 3){
		break;
}
Console.WriteLine(elem);
}


**What is the purpose of the continue statement in loops? Provide an example.**
**Quel est le but de l'instruction continue dans les boucles ? Donnez un exemple.**

	Le statement continue permet de passer à l’itération suivante.
int i[] tab = {1,2,3,4,5}
foreach(int elem in tab){
	if(elem > 3){
		continue;
}
Console.WriteLine(elem);
}

**Can you create an infinite loop in C#? If so, how? When might this be useful?**
**Peut-on créer une boucle infinie en C# ? Si oui, comment ? Dans quels cas cela peut-il être utile ?**

	Oui, on peut écrire while(true);
	C’est utile pour une boucle infinie (boucle principale).


**Write a program to print a multiplication table for a given number using nested loops.**
**Écrivez un programme permettant d'imprimer une table de multiplication pour un nombre donné à l'aide de boucles imbriquées.**

	int tab[10][10];
	for(int i = 0; i < 10; i++){
		for(int j = 0; j < 10; j++){
			tab[i][j] += (i+1) * (j+1); 
}
}

**How do you loop through a dictionary in C#? Provide an example.**
**Comment parcourir un dictionnaire en C# ? Donnez un exemple.**

	using System;
using System.Collections.Generic;
Dictionary<string, int> ages = new Dictionary<string, int>()
        {
            { "Alice", 25 },
            { "Bob", 30 },
            { "Charlie", 20 }
        };
foreach (KeyValuePair<string, int> entry in ages){
	Console.WriteLine($"{entry.Key} is {entry.Value} years old.");
}

**What is the syntax for defining a function in C#? Provide an example of a function that adds two numbers.**
**Quelle est la syntaxe pour définir une fonction en C# ? Donnez un exemple de fonction qui additionne deux nombres.**

**What are the differences between void functions and functions that return a value in C#?**
**Quelles sont les différences entre les fonctions void et les fonctions qui renvoient une valeur en C# ?**

**How do you call a function in C#? Provide an example.**
**Comment appeler une fonction en C# ? Donnez un exemple.**

**What is function overloading, and how does it work in C#? Give an example.**
**Qu'est-ce que la surcharge de fonction et comment fonctionne-t-elle en C# ? Donnez un exemple.**

**How do you pass parameters to a function in C#? Explain with an example of both value and reference types.**
**Comment passer des paramètres à une fonction en C# ? Expliquez à l'aide d'un exemple pour les types de valeur et les types de référence.**

**What are optional parameters in C#, and how do you define them in a function? Provide an example.**
**Que sont les paramètres facultatifs en C# et comment les définir dans une fonction ? Donnez un exemple.**

**What is the difference between ref and out parameters in C#? Explain with examples.**
**Quelle est la différence entre les paramètres ref et out en C# ? Expliquez à l'aide d'exemples.**

**How do you create and use a recursive function in C#? Write an example to calculate the factorial of a number.**
**Comment créer et utiliser une fonction récursive en C# ? Écrivez un exemple pour calculer la factorielle d'un nombre.**

**Can you define a function inside another function in C#? Why or why not?**
**Peut-on définir une fonction à l'intérieur d'une autre fonction en C# ? Pourquoi ou pourquoi pas ?**

**Write a function in C# to check if a given string is a palindrome.**
**Écrivez une fonction en C# pour vérifier si une chaîne donnée est un palindrome.**

-------------------------------------------------------------------------------------------------------------------------------------------

**What is an array in C#, and how is it declared and initialized? Provide an example.**
**Qu'est-ce qu'un tableau en C#, et comment est-il déclaré et initialisé ? Donnez un exemple.**

**How can you access and modify elements in an array in C#?**
**Comment accéder aux éléments d'un tableau et les modifier en C# ?**

**What is a List in C#, and how does it differ from an array?**
**Qu'est-ce qu'une liste en C# et en quoi diffère-t-elle d'un tableau ?**

**How do you add and remove elements in a List in C#? Provide examples.**
**Comment ajouter et supprimer des éléments dans une liste en C# ? Donnez des exemples.**

**How can you iterate through a List or array in C#? Provide an example.**
**Comment parcourir une liste ou un tableau en C# ? Donnez un exemple.**

**What is a Dictionary in C#, and how is it declared and initialized? Provide an example.**
**Qu'est-ce qu'un dictionnaire en C#, et comment est-il déclaré et initialisé ? Donnez un exemple.**

**How do you add, remove, and check if a key exists in a Dictionary? Provide examples.**
**Comment ajouter, supprimer et vérifier si une clé existe dans un dictionnaire ? Donnez des exemples.**

**How do you iterate through a Dictionary to access both keys and values?**
**Comment parcourir un dictionnaire pour accéder à la fois aux clés et aux valeurs ?**

**What happens if you try to add a duplicate key to a Dictionary in C#?**
**Que se passe-t-il si vous essayez d'ajouter une clé en double à un dictionnaire en C# ?**

**Write a program to count the frequency of words in a string using a Dictionary.**
**Écrivez un programme permettant de compter la fréquence des mots dans une chaîne à l'aide d'un dictionnaire.**
```
