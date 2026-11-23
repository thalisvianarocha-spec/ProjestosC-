namespace ativiade_2
{
    class Atividade_2
    {
        public static void Media()
        {
            Console.Write(" Digite o Primeiro Número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write(" Digite o Segundo Número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A soma dos números é: {n1 + n2}");
            Console.WriteLine($"O resto é: {n1 % n2}");
            Console.WriteLine($" A media dos números é: {(n1 + n2) / 2}");
        }
    }
}