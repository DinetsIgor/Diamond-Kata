using DiamondKata.Exceptions;
using DiamondKata.Generators;
using DiamondKata.Generators.Interfaces;

try
{
    if (args.Length != 1)
    {
        Console.WriteLine("Incorrect parameters: Invalid number of arguments.");
        return;
    }

    var diamondChar = args[0];
    if (diamondChar.Length > 1)
    {
        Console.WriteLine("Incorrect parameters: Parameter length should be equal 1.");
        return;
    }

    IDiamondGenerator generator = new DiamondGenerator();
    var diamondLines = generator.Generate(diamondChar[0]);

    foreach (var line in diamondLines)
    {
        Console.WriteLine(line);
    }
}
catch(DiamondValidationException exception)
{
    Console.WriteLine($"Diamond generation error: {exception.Message}");
}
catch (Exception exception)
{
    Console.WriteLine($"Unhandled error: {exception.Message}");
}