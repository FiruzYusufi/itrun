using System.Linq;

List<String> strings = new() {"abdujon", "1", "1", "1", "1", "1", "2","3","4", "4", "4", "4", "4", "4", "5","6","7","8"};


var strs = strings.OrderByDescending(str=> str).Distinct().ToList();
//var newstr = from s in strings where s == "1" select s;
var newstr = strings.Where(s => s.ToUpper().StartsWith("A")).Distinct().ToList();
string aa = "abdujon";
string bb = aa.ToUpper();
Console.WriteLine(bb);
//foreach (var s in newstr)
//{
//    Console.WriteLine(s);
//}
