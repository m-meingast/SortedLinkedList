# SortedLinkedList

Implement a sorted linked list in C# according to the Java example shown in the course. An Interface **IMyList** is already given, which you have to implement.
You will need to implement a **Person** class. You can use the example, but of course, it is allowed to extend your class.
Test your application in the **Main** method with the statements from the Java example. Add additional test cases if you want.


Structure your application carefully and pay attention to a clean programming style.

## Differences to Java
There are some differences to Java in this task. They are described below.

### Comparable Interface
For Person you have to implement the Comparable interface in order to get a sorted list. This interface is called **IComparable<T>** in C#

~~~C#
public class Person : IComparable<Person>
~~~ 

### Nullable Types
If you want to assign **null** to a variable, consider using a nullable type(i.e. a type with a **?**).

~~~C#
Node? previous = null;
~~~


### Foreach Loop
The **Foreach** loop is written together with the **in** keyword

~~~C#
foreach (Person p in persons) {...}
~~~

### Method Signatures
Method names are declared with an uppercase first letter.

~~~C#
public bool IsEmpty(){...}
~~~
