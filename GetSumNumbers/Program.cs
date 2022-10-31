
/* Sum numbers*/

/*
Console.Write("Enter Number:");
int GetNumber = int.Parse(Console.ReadLine());
if(GetNumber < 0)
{
    GetNumber *= -1;
}
int sum = 0;
int i;
for(i = 1; i <= GetNumber; i++)
{
    sum = sum + i;
}
Console.WriteLine("Answer:" + sum);
*/
/* Taken Number of elementsin loop */
int i;
for (i = 1; i < 100; i++)
{
  if (i % 3 == 0 || i % 5 == 0)
    {

    Console.WriteLine(i);
    }
}
