List<double> grades = new List<double>() { 12.5, 10.3, 2.8, 10.4, 2 };
grades.Add(14.3);
foreach (var grade in grades)
{
    Console.WriteLine(grade);
}
Console.WriteLine("----------");
Console.WriteLine(grades[0]);
