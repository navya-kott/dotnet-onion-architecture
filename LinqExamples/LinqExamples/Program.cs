var numbers = new[] {11, 1,1,  5 };
var evens = numbers.Where(n => n % 2 == 0);
evens.Dump();

var duplicated = new[] { 1, 2, 2, 3, 3, 3, 4 };
var uniqueNumbers = duplicated.Distinct();
uniqueNumbers.Dump(); 


IEnumerable<object> Object = ["a", 1, "b", 2];
Object.OfType<int>().Dump();
Object.OfType<string>().Dump();

var nums= new[] { 1, 2, 3, 4, 5 };
var remaining = nums.Skip(2);
remaining.Dump(); 


var squares = numbers.Select(n => n * n);
squares.Dump(); 


var strs = new[] { "rat","ran","cat" };
var sorted = strs.OrderByDescending(n => n);
sorted.Dump();

var people = new[]
{
    new { Name = "Alice", Age = 25 },
    new { Name = "Bob", Age = 20 },
    new { Name = "Charlie", Age = 25 }
};

var sortit = people.OrderBy(p => p.Age).ThenBy(p => p.Name);
sortit.Dump();


var count = numbers.Count();
count.Dump("Numbers count");

var total = numbers.Sum() / numbers.Count();
total.Dump("total");

var avg = numbers.Average();
avg.Dump("Average of numbers");


var min = numbers.Min();
var max = numbers.Max();
min.Dump(); 
max.Dump();

var words = new[] { "apple", "banana", "apricot", "blueberry" ,"apple"};
var grouped = words.GroupBy(w => w);
grouped.Dump();


var students = new[]
{
    new { Id = 1, Name = "Alice" },
    new { Id = 2, Name = "Bob" }
};
var scores = new[]
{
    new { StudentId = 1, Score = 90 },
    new { StudentId = 2, Score = 85 }
};

var joined = students.Join(scores,
    student => student.Id,
    score => score.StudentId,
    (student, score) => new { student.Name, score.Score });

joined.Dump();



var first = numbers.First(n => n % 2 == 0);
first.Dump("first"); 


var firstd = words.FirstOrDefault(n => n[0]=='w');
firstd.Dump();


var single = numbers.SingleOrDefault(n => n == 155);
single.Dump();


var a = new[] { 1, 2, 3 };
var b = new[] { 3, 4, 5 };
var result = a.Union(b);
result.Dump(); 
