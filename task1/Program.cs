int number = Promt("введите число ");
int degree = Promt("введите степень числа ");
Num( number, degree);
void Num(int number,int degree)
{
    int N = number;
    for(int i = 1;i < degree; i++)
    {
       number = number * N; 
    }
    Console.WriteLine($"Число {N} в степени {degree} равно {number}");
}
int Promt(string messege)
{
    Console.Write(messege);
    string strN = Console.ReadLine();
    int N =int.Parse(strN);
    return N;
}

