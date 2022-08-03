// Exercício do site URI "Fatorial Simples"
// Nesse programa vamos calcular o fatorial do número inteiro "N" digitado.


int N = int.Parse(Console.ReadLine());
int F = 1;
for (int i = 1; i <= N; i ++)
{
    F = F * i;
}
Console.WriteLine(F);