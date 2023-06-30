internal class Program
{
    private static void Main(string[] args)
    {
        static string FormatTime(int seconds)
        {
            // Utwórz obiekt DateTime z podaną liczbą sekund
            DateTime time = new DateTime().AddSeconds(seconds);
            // Zwróć sformatowany czas w formacie HH:mm:ss
            return time.ToString("HH:mm:ss");
        }
}
}
}