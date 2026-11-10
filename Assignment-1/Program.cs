string name;
int age;
string address;

Console.Write("Enter your name: ");
name = Console.ReadLine();

Console.Write("Enter your age: ");
age = int.Parse(Console.ReadLine());

Console.Write("Enter your address: ");
address = Console.ReadLine();

Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Address: " + address);