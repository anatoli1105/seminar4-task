int Promt(string messege)
{
    Console.WriteLine(messege);
    string strN = Console.ReadLine();
    int N =int.Parse(strN);
    return N;
}
int number = Promt("введите число ");
int degree = Promt("введите второе число ");
int i = 1;
int N = number;
while(  i < degree)
{
     number = number * N;
     i++;
}
Console.WriteLine(number);

//or (int d = 1;d <= N;d++)
