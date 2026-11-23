namespace ProjestosC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione: ");
            var switch_on = Console.ReadLine(); 

            switch (switch_on)
            {
                case "1":
                    Console.WriteLine("Atividade 1");
                    new atividade_1.Atividade_1().CalcularTriangulo();
                    break;
                case "2":
                    Console.WriteLine("Atividade 2");
                    new atividade_2.Atividade_2().Media();
                    break;
                case "3":
                    Console.WriteLine("Atividade 3");
                    new atividade_3.Atividade_3().Renda();
                    break;
                case "4":
                    Console.WriteLine("Atividade 4");
                    new atividade_4.Atividade_4().NotaAluno();
                    break;
                case "5":
                    Console.WriteLine("Atividade 5");
                    new atividade_5.Atividade_5().Tabuada();
                    break;
            }
        }
    }
}
