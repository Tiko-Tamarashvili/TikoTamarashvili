
int[] MainArr = new int[10];
int index;

Console.WriteLine("shemoitanet masivis elementebi");

for (int i = 0; i < MainArr.Length; i++)
    {
        MainArr[i] = int.Parse(Console.ReadLine());
    }

Console.WriteLine("migebuli masivia:");

for (int i = 0; i < MainArr.Length; i++)
    {
        Console.Write(MainArr[i] +" ");
    }

Console.WriteLine();
Console.WriteLine("shemoitanet indeqsi");
index = int.Parse(Console.ReadLine());
Console.WriteLine();


int result = PintDigitSum(MainArr, index);
Console.WriteLine("Semotanili indexis mqone masivis elementis cifrta jamia: " + result);


static int PintDigitSum(int[] RandomArr, int Index)
{
    int sum = 0;
    int elememt = RandomArr[Index];
   
    while (elememt > 0)
        {
            sum += elememt % 10;
            elememt = elememt / 10;
        }

    return sum;
}