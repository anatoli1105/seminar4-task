Console.WriteLine("введите числа");
string strN = Console.ReadLine();
int N =int.Parse(strN);
int Res(int N)
{
    int i = 0;
    while(N > 0)
        {
            i = i + N%10;
            N = N/10;
        }
    return i;
}
Console.WriteLine(Res(N));


