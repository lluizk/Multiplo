System.Console.WriteLine(" ~~~~ Múltiplo ~~~~ ");

System.Console.Write("Digite o número que deseja encontrar o multiplo: ");

int n1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Digite o número que deseja avaliar se é multiplo: ");

int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 % n2 == 0)
{
     
     System.Console.WriteLine($"\n{n1} é multiplo de {n2}");
}
 else
 { 
    System.Console.WriteLine($"\n{n1} não é multiplo de {n2}");
 }
 