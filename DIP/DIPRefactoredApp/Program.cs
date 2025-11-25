

using DIPRefactoredApp.HighLevelModules;
using DIPRefactoredApp.LowLevelModules;

var calc = new TaxCalculator(new DbLogger());
Console.WriteLine(calc.CalculateTax(10, 0)); ;