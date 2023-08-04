Console.Write("Введите число N  = ");
int N = Convert.ToInt32(Console.ReadLine());
int Q = 2;
for (int i = 1; i < N; i++)
{
int result = Q % 2;
if (result == 0)
{
Console.Write(Q);
Q++;
}
else
{
Q++;
}}