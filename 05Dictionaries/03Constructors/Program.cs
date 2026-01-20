namespace _03Constructors;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();

        program.Run();
    }

    private void Run()
    {
        QuizVraag quizVraag = new QuizVraag("Hier komt de vraag", "Hier komt het antwoord");
    }

}
