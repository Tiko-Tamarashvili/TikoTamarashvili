
using Counter1;

 
    Counter counter = new Counter();
    Console.WriteLine(Counter.GetCount());

    Counter counter1 = new Counter();
    Console.WriteLine(Counter.GetCount());

    Counter counter2 = new Counter();
    Console.WriteLine(Counter.GetCount());

    Counter counter3 = new Counter();
    Console.WriteLine(Counter.GetCount());


    Counter.ResetCount();
    Console.WriteLine(Counter.GetCount());
