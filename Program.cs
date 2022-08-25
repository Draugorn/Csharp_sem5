// Task 34
Console.WriteLine("Task 34. Setting the array filled with random positive three-digit numbers & calculating amount of even ones.");
// Creating the array method

Console.WriteLine("Generating an Array.");

int[] NumericalArray = new int [4];
int Amount = NumericalArray.Length;
var RND_NUM = new Random();
for (int i = 0; i < Amount; i++)
{
  NumericalArray[i] = RND_NUM.Next(100,1000);
  Console.WriteLine("{0} element of an array is: {1}", i+1, NumericalArray[i]);
}

int count = 0;
for (int i = 0; i < Amount; i++)
{
   int DIV = NumericalArray[i]%2; 
   if (DIV==0)
   {
    count = count+1;
   } 
}
Console.WriteLine("Amount of even elements of an array is {0}", count);

// Task 34
Console.WriteLine();
Console.WriteLine("Task 34. Specifying a one-dimensional array filled with random numbers & Finding the sum of odd-positioned items.");

Console.WriteLine("Generating an Array.");

int[] NumericalArray2 = new int [5];
int Amount2 = NumericalArray2.Length;
var RND_NUM2 = new Random();
for (int i = 0; i < Amount2; i++)
{
  NumericalArray2[i] = RND_NUM2.Next(100,1000);
  Console.WriteLine("{0} element of an array is: {1}", i+1, NumericalArray2[i]);
}
int result = 0; 

for (int i = 0; i < Amount2; i++)
{
    int DIV2 = (i+1)%2;
// Можно решить чере i=1;i+=2
    if (DIV2!=0)
    {
        result = result+NumericalArray2[i];
    }
}
Console.WriteLine("The sum of odd numbers in an array is: {0}", result);

//Task 38
Console.WriteLine();
Console.WriteLine("Specifying an array of real numbers. Finding the difference between the maximum and minimum elements of an array.");

double[] Realarray = new double [5];
int Length = Realarray.Length;
var RND_REAL = new Random();
for (int i = 0; i < Length; i++)
{Realarray[i] = RND_REAL.NextDouble()*100;
Realarray[i] = Math.Round(Realarray[i],2);
Console.WriteLine("{0} element of an array is: {1}", i+1, Realarray[i]);
};
double max = Realarray[1];
double min = Realarray[1];
for (int i = 0; i < Length; i++)
{
    if (Realarray[i]>max)
    {
        max = Realarray[i];
    }
    else if (Realarray[i]<min)
    {
        min = Realarray[i];
    }
}
Console.WriteLine("Minimal element of an array is: {0}", min);
Console.WriteLine("Maximal element of an array is: {0}", max);

double difference = 0;
difference = max-min;

Console.WriteLine("Difference between aforementioned elements is: {0}", Math.Round(difference,2));