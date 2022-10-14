/*
Из имеющегося массива строк создать массив из элементов 1-го массива, длина которых меньше, либо равна 3-м символам
*/
//------------------------------------------------------------------

void console_write (string[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        Console.Write (A[i] + ",");
    }
    //Console.WriteLine();
}

//------------------------------------------------------------------
Consol.WriteLine ("Введите кол-во элементов:");
int N = Convert.ToInt32 (Consol.ReadLine ());

string [] A = new string [N];

for (int i = 0; i < N; i++)
{
    A[i] = Convert.ToString(Console.ReadLine());
}

int sim = 3;
int ch = 0;
string [] B = new string[N];

for (int j = 0; j < N; j++)
{
    if (A[j].Length <= sim)
    {
        B[ch] = A[j];
        ch ++;
    }
}

//Console.WriteLine();
PrintArray (B);