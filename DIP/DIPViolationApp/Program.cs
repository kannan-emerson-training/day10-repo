

using DIPViolationApp.HighLevelModules;

var taxCalc = new TaxCalculator(LogOptions.Text);
int result = taxCalc.CalculateTax(100, 0);
Console.WriteLine(result);



void CaseStudy1() {


    Console.WriteLine("Hello, World!");
    int a = 10;
    int b = 0;

    //try
    //{
    //    Console.WriteLine(a / b);
    //}
    //catch (DivideByZeroException ex) {

    //    Console.WriteLine(ex.Message);
    //}

    Console.WriteLine("end of program");

}
