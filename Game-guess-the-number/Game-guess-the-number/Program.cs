using Game_guess_the_number;
using Game_guess_the_number.Implementations;

class Program
{
    static void Main(string[] args)
    {
        // Настройка зависимостей
        var settingsProvider = new DefaultSettingsProvider();
        var settings = settingsProvider.GetSettings();

        var output = new ConsoleOutput();
        var generator = new RandomNumberGenerator(settings);
        var input = new ConsoleUserInput(output);

        var gameLogic = new GameLogic(settings, generator, input, output);
        var game = new GuessNumberGame(gameLogic, input, output);

        // Запуск игры
        game.Play();

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}