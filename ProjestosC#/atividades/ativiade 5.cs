namespace atividade_5
{
    class Atividade_5
    {
        public static void Tabuada()
        {
            Console.WriteLine("tabuada de : ");
            int nu = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                int resultado = nu * i;
                Console.WriteLine(nu + " x " + i + " = " + resultado);
            }




        }
    }
}