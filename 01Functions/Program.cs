namespace _01Functions
{
    internal class Rekenmachine
    {
        public static int TelOp()
        {
            
        }
    }
    internal class Program
    {

    static void Main(string[] args)
    {
        Monster orge  =new Monster();
        Monster draak = new Monster();
        draak.GetHp();

        orge.GetHp();
        Program program = new Program();
        program.Run();

      
        Console.WriteLine("Everything works!");
    }

    internal void Run()
    {
            
    }


    }

    internal class Monster
    {
        int hp = 10;

        public int GetHp()
        {
            
        }
    }

}