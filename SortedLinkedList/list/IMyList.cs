using SortedLinkedList.person;

namespace SortedLinkedList.list;

public interface IMyList
{
    /// <summary>
    /// Inserts an element at the end of the list.
    /// </summary>
    /// <param name="element">Element to store</param>
    void Insert(Person? element);

    /// <summary>
    /// Finds the element in the list according to the index.
    /// </summary>
    /// <param name="index">The index of the entry</param>
    /// <returns>The element at the index, null if index is out of bounds</returns>
    Person? GetEntry(int index);

    /// <summary>
    /// Remove element from the list.
    /// </summary>
    /// <param name="element">The element to be removed</param>
    /// <returns>True if removing was successful, false otherwise</returns>
    bool RemoveEntry(Person? element);

    /// <summary>
    /// Return the list content as an array.
    /// </summary>
    /// <returns>The array with all list entries</returns>
    Person[]? GetEntries();

    /// <summary>
    /// Return the number of list entries.
    /// </summary>
    /// <returns>The size of the list</returns>
    public int Size();
    
    /// <summary>
    /// Check if list is empty
    /// </summary>
    /// <returns></returns>
    bool IsEmpty();
}