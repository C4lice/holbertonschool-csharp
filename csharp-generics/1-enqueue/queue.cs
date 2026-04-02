using System;

/// <summary>
/// Implémentation simple d'une file (Queue) générique en C#
/// Fonctionne selon le principe FIFO (First In, First Out)
/// </summary>
class Queue<T>
{
    // Premier élément de la file
    Node head;

    // Dernier élément de la file
    Node tail;

    // Nombre d'éléments dans la file
    int count;

    /// <summary>
    /// Retourne le type générique utilisé (T)
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Classe interne représentant un nœud de la file
    /// </summary>
    public class Node
    {
        // Valeur stockée dans le nœud
        public object value = null;

        // Référence vers le nœud suivant
        public Node next = null;

        /// <summary>
        /// Constructeur du nœud
        /// </summary>
        /// <param name="value">Valeur à stocker</param>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    /// <summary>
    /// Ajoute un élément à la fin de la file (enqueue)
    /// </summary>
    /// <param name="value">Valeur à ajouter</param>
    public void Enqueue(T value)
    {
        // Création d'un nouveau nœud
        Node newNode = new Node(value);

        // Si la file est vide
        if (head == null)
        {
            // Le nouvel élément devient le premier et le dernier
            head = newNode;
            tail = newNode;
        }
        else
        {
            // Sinon, on l'ajoute à la fin
            tail.next = newNode;
            tail = newNode;
        }

        // Incrémentation du compteur
        count++;
    }

    /// <summary>
    /// Retourne le nombre d'éléments dans la file
    /// </summary>
    public int Count()
    {
        return count;
    }
}
