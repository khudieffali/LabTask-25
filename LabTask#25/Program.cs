
using LabTask_25;

Book book = new("Salam", "Aziz", 520, 15);
Book book1 = new("Salam1", "Aziz1", 800, 20);

Electronic electronic = new("Comp1", 1300, 15);
Electronic electronic2 = new("Comp", 1500, 10);


Product[] arr = {book,book1,electronic,electronic2};

foreach (var item in arr)
{
    Console.WriteLine(item.GetPrice());
    Console.WriteLine("-------------------------");
    Console.WriteLine(item.ReduceStock(5));

}


