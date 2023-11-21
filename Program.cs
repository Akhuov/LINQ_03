
using LINQ_004;

//Queries.Run();

Person[] students = { new Person("Tom"), new Person("Bob"), new Person("Sam") };
Person[] employees = { new Person("Tom"), new Person("Bob"), new Person("Mike") };

// объединение последовательностей
var people = students.Except(employees);

foreach (Person person in people)
    Console.WriteLine(person.Name);