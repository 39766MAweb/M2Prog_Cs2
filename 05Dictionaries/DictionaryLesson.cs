namespace _05Dictionary;

public static class DictionaryLesson
{
    public static void DictionaryExercise()
    {
        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

        personeelOpNummer.Add(382942, "Jim");
        personeelOpNummer.Add(789432, "Tim");

        string jim = personeelOpNummer[382942];
        string tim = personeelOpNummer[789432];

        Console.WriteLine(jim + " " + tim);
    }
}
