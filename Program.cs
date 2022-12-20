// Напишите программубкоторая выводит третью цифру числа или сообщает ,что ее нет
int N = int.Parse(Console.ReadLine());
if (N / 100 <1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int k = 1;
    int N1 = N/10;
    while (N1>0)
        {
            N1=N1/10;
            k=k+1;
        }
    Console.WriteLine((N-N%Math.Pow(10,(k-3)))/Math.Pow(10,(k-3))%10);
}

