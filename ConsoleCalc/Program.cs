using CalcEngineNet;

var engine = new CalcEngine();
var keysMapping = new Dictionary<ConsoleKey, CalcKey>()
{
    { ConsoleKey.D0, CalcKey.Zero },
    { ConsoleKey.D1, CalcKey.One },
    { ConsoleKey.D2, CalcKey.Two },
    { ConsoleKey.D3, CalcKey.Three },
    { ConsoleKey.D4, CalcKey.Four },
    { ConsoleKey.D5, CalcKey.Five },
    { ConsoleKey.D6, CalcKey.Six },
    { ConsoleKey.D7, CalcKey.Seven },
    { ConsoleKey.D8, CalcKey.Eight },
    { ConsoleKey.D9, CalcKey.Nine },
    { ConsoleKey.Escape, CalcKey.AC },
    { ConsoleKey.Enter, CalcKey.Equal },
    { ConsoleKey.OemPlus, CalcKey.Add },
    { ConsoleKey.OemMinus, CalcKey.Minus },
    { ConsoleKey.OemPeriod, CalcKey.Dot },
    { ConsoleKey.OemComma, CalcKey.FlipSign },
    { ConsoleKey.Divide, CalcKey.Divide },
    { ConsoleKey.Oem2, CalcKey.Divide },
    { ConsoleKey.Multiply, CalcKey.Multiply },
    { ConsoleKey.X, CalcKey.Multiply },
    { ConsoleKey.Oem7, CalcKey.Percent }
};

Console.Clear();

while (true)
{
    ConsoleKeyInfo cki = Console.ReadKey(intercept: true);
    if (keysMapping.ContainsKey(cki.Key))
    {
        Console.SetCursorPosition(0, 0);
        Console.Error.WriteLine($"{cki.Key} => {keysMapping[cki.Key]}".PadRight(30, ' '));
        engine.ProcessKey(keysMapping[cki.Key]);
        Console.SetCursorPosition(0, 1);
        Console.WriteLine(engine.GetDisplay().PadRight(30, ' '));
    }
}