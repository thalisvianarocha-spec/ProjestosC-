namespace atividade_4
{
    class Atividade_4
    {
        public void NotaAluno()
        {
            Console.WriteLine(" Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());
            if(nota >= 9)
            {
                Console.WriteLine("A");
            }
            else if(nota >= 7)
            {
                Console.WriteLine("B");
            }
            else if(nota >= 5)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("D");
            }
            
            Console.WriteLine("===== Sugunda parte =====");



            Console.WriteLine("Digite o Primeiro Número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" opperaçoes: 1 - Soma, 2 - Subtração, 3 - Multiplicação");

            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("A soma é: " + (n1 + n2));
                    break;
                case 2:
                    Console.WriteLine("A subtração é: " + (n1 - n2));
                    break;
                case 3:
                    Console.WriteLine("A multiplicação é: " + (n1 * n2));
                    break;
                
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}