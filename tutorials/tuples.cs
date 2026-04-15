(int x, int y) pt = (x: 1, y: 2);
var slope = (double)pt.y / (double)pt.x;
System.Console.WriteLine($"the point {pt} has a slope of {slope}");

(int x, int y) pt2 = pt with { x = 7 };
System.Console.WriteLine(($"pt2 is {pt2}"));

(int A, int B) subscript = (A: 0, B: 0);
subscript = pt;
System.Console.WriteLine($"the subscript is {subscript}");

// (string Name, int Temp, int Wind) namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
// (string FirstName, string LastName) person = (FirstName: "", LastName: "");
// (string Product, string style, int quantity, decimal UnitPrice) order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);
Tuple<int, int, int> t = Tuple.Create(1, 2, 3);
(int x, int y, int z) pt3 = (t.Item1, t.Item2, t.Item3);
System.Console.WriteLine($"{pt3.x}, {pt3.y}, {pt3.z}");

var point = (x: 18, y: 20);
var (x, y) = point;
var person1 = new Person("Alice", 30, "New York");
Console.WriteLine(person1);
var user1 = new User("Bob", 25);
Console.WriteLine(user1.GetFullInfo());


public record Person(string Name, int Age, string City);
public record User
{
    public string Name { get; init; }
    public int Age { get; init; }
    public int Score { get; init; } = 0;

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string GetFullInfo() => $"{Name}, {Age} years old, Score: {Score}";
}