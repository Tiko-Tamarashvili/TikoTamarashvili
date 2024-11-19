using box1;
using System.Collections.Generic;
using utility;

var box = new Box <int>();

box.SetValue(58);
Console.WriteLine(box.GetValue());

var box1 = new Box<string>();

box1.SetValue("Tiko");
Console.WriteLine(box1.GetValue());


List<int> myValues = new List<int>(new int[] { 1, 2, 3 });
Console.WriteLine(Utility.SetValue(myValues));


List<string> myValues1 = new List<string>(new string[] { "Tiko", "niko", "gio", "nino" });
Console.WriteLine(Utility.SetValue(myValues1));
