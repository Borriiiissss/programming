// заполнение и вывод массивов с помощью функций
int[] collection = new int[10];

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
        
        if (collection [index] == find)
            {
            System.Console.WriteLine($"we are looking for {find}");
            pos = index;
            System.Console.WriteLine($"index of element = {pos} ");
            
            break;
            }
            
        index++;
    } 
    return pos;
}
Fillarray (collection);
Printarray (collection);

System.Console.WriteLine("input number");
int number = int.Parse( Console.ReadLine());

IndexOf (collection, number);



