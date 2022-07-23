// заполнение и вывод массивов с помощью функций
int[] collection = new int[10];
int f;

void Fillarray (int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection [index] = new Random().Next(1,5);
        index++;
    }
}

void Printarray (int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        System.Console.WriteLine(collection [index]);
        index++;
    }
}

int IndexOf (int[] collection, int find)
{
    int lenght = collection.Length;
    int index = 0;
    int pos = -1;
    while (index < lenght)
    {
        System.Console.WriteLine($"we are looking for {find}");
        if (collection [index] == find)
            
            System.Console.WriteLine($"index of element = {index} ");
            pos = index;
            
            
        index++;
    } 
    return pos;
}
Fillarray (collection);
Printarray (collection);

System.Console.WriteLine("input number");
string num = Console.ReadLine();
int number = int.Parse(num);
IndexOf (collection, number);



