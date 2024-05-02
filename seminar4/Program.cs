
using seminar4;

var numbers = new List<int>() { 5,6,7,8,9 };
var numbers2 = numbers.MyWhere<int>(x => x > 7);

numbers2.ToList().ForEach(Console.WriteLine);