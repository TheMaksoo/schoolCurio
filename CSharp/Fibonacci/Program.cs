int a = 1;
int b = 0;
int c = 0;
for (int i = 0; i < 25; i++)
{
    c = a + b;
    Console.WriteLine(c);
    a = b;
    b = c;
}