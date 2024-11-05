using Libraries;

Library library = new Library();
library.AddBook("wigni pirveli", "aaa", 1111);
library.AddBook("wigni meore", "bbb", 2222);
library.AddBook("wigni mesame", "ccc", 3333);
library.PrintBook();

Console.WriteLine(library.Count());

library.FindBook("wigni meore");
library.RemoveBook();
Console.WriteLine(library.Count());