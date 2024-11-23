using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;



// ArrayList

var names = new ArrayList();

names.Add("tiko");
names.Add("nino");
names.Add("maka");
names.Add("gio");


foreach (var i in names)
{
    Console.WriteLine(i);
}

Console.WriteLine(names.Count);
Console.WriteLine(names.Capacity);

names.Remove("tiko");
names.RemoveAt(2);


names.Insert(0, "mari");


foreach (var i in names)
{
    Console.WriteLine(i);
}




// list

List<string> subject = new List<string>() { "qarTuli", "matematika", "fizika" };


subject.Add("qimia");
subject.Remove("qarTuli");


foreach (var i in subject)
{
    Console.WriteLine(i);
}


subject.Sort();
foreach (var i in subject)
{
    Console.WriteLine(i);
}


subject.AddRange(subject);


foreach (var i in subject)
{
    Console.WriteLine(i);
}



//Dictionary

Dictionary<int, string> students = new Dictionary<int, string>();
students.Add(1, "mari");
students.Add(3, "nana");
students.Add(2, "gio");
students.Add(4, "niko");


students.Remove(1);

foreach (var i in students)
{
    Console.WriteLine(i);
    Console.WriteLine(students.ContainsKey(3));
    Console.WriteLine(students.ContainsValue("beka"));
}

var first = students.ElementAt(0);
Console.WriteLine(first.Key);
Console.WriteLine(first.Value);



//SortedDictionary

SortedDictionary<int, string> myDictionary = new SortedDictionary<int, string>();

myDictionary.Add(1, "mari");
myDictionary.Add(3, "nana");
myDictionary.Add(2, "gio");
myDictionary.Add(4, "niko");


myDictionary.Remove(1);


foreach (var i in myDictionary)
{
    Console.WriteLine(i);
}



//SortedList

SortedList<int, string> teachers = new SortedList<int, string>();


teachers.Add(1, "Lasha");
teachers.Add(5, "nika");
teachers.Add(2, "beka");
teachers.Add(4, "lika");
teachers.Add(3, "mari");


teachers.Remove(1);
teachers.RemoveAt(3);


foreach (var i in teachers)
{
    Console.WriteLine(i);
}


var elm = teachers.ElementAt(0);

Console.WriteLine(elm.Value);




//Stack

Stack<int> num = new Stack<int>();

num.Push(1);
num.Push(12);
num.Push(23);
num.Push(34);

Console.WriteLine(num.Peek());



//Queue

Queue<int> sia = new Queue<int>();
sia.Enqueue(1);
sia.Enqueue(100);
sia.Enqueue(200);

sia.Dequeue();


Console.WriteLine(sia.Peek());




//HashSet

HashSet<int> myList = new HashSet<int>();

myList.Add(0);
myList.Add(11);
myList.Add(21);
myList.Add(31);
myList.Add(21);


myList.Remove(11);


foreach (int i in myList)
{
    Console.WriteLine(i);
}


HashSet<int> yourList = new HashSet<int>();

yourList.Add(2);
yourList.Add(34);
yourList.Add(5);
yourList.Add(3);


myList.UnionWith(yourList);


foreach (int i in myList)
{
    Console.WriteLine(i);
}


// Create a list that holds IEnumerable to store different collection types
List<IEnumerable> myCollection = new List<IEnumerable>();

myCollection.Add(names);
myCollection.Add(students);
myCollection.Add(subject);
myCollection.Add(teachers);
myCollection.Add(myDictionary);
myCollection.Add(num);
myCollection.Add(sia);
myCollection.Add(myList);
myCollection.Add(yourList);

// Iterate over collectionsList and print elements
foreach (var collection in myCollection)
{
    foreach (var item in collection)
    {
        //Console.WriteLine(item);
    }
}