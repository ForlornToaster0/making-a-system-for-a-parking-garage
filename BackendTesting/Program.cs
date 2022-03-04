// See https://aka.ms/new-console-template for more information
object[,] map = new object[25, 4];
int l = 0;
for (int i = 0; i < 25; i++)
{
    for (int j = 0; j < 4; j++)
    {

        map[i, j] = l;
        l++;
        
    }
}
foreach(object obj in map)
{
    Console.WriteLine(obj);
}