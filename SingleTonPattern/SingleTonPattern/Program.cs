
using SingleTonPattern.Service;


DataService sv1 =  DataService.CreateAnInstance();

DataService sv2 = DataService.CreateAnInstance();



Console.WriteLine(sv1.GetHashCode());
Console.WriteLine(sv2.GetHashCode());

Console.WriteLine(sv1.GetData());
Console.WriteLine(sv2.GetData());