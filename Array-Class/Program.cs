// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int [] arrayIntegers = new int [6];

bool isSymmetric = true;

for(int i = 0; i < arrayIntegers.Length; i++)
{
    Console.Write($"Enter integer {i + 1}: ");
    arrayIntegers[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i < arrayIntegers.Length / 2 ; i++)
{
    if(arrayIntegers[i] != arrayIntegers[arrayIntegers.Length- i- 1])
    {
        isSymmetric = false;
        break;
    }
    
}

if(isSymmetric)
{
    Console.Write("It's SymSmetric");
}
else
{
    Console.WriteLine("It's not Symmetric");
}

