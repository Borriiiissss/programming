// заполнение и вывод массивов с помощью функций
int[] collection = new int[10];
void Fillarray (int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection [index] = new Random().Next(1,1500000);
        index++;
    }
    // System.Console.WriteLine(collection[]);

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

Fillarray (collection);
Printarray (collection);




