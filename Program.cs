List<Student>  st=new List<Student>();
st.Add(new Student { Name = "John", Age = 18 });
st.Add(new Student { Name = "Steve", Age = 21 });
st.Add(new Student { Name = "Billr", Age = 25 });
st.Add(new Student { Name = "RamR", Age = 20 });
st.Add(new Student { Name = "Ron", Age = 19 });

//print the list
// foreach(var item in st)
// {
//     if (item.Age > 20)
//     {
//         Console.WriteLine(item.Name);
//     }
    
// }


//filter the list lambda expression
// var result = st.Where(x => x.Age > 20);
// foreach (var item in result)
// {
//     Console.WriteLine(item.Name);
// }

//examples of filter the list lambda expression
//  var result = st.Where(x => x.Age > 20 || x.Age <18);
//     foreach (var item in result)
//     {
//         Console.WriteLine(item.Name);
//     }


//examples of filter the list lambda expression any
//  var result = st.Any(x => x.Name == "ali");
//     Console.WriteLine(result);

//examples of filter the list lambda expression avrage
//   var result = st.Average(x => x.Age);
//         Console.WriteLine(result);

//examples of filter the list lambda expression Sum
//   var result = st.Sum(x => x.Age);
//         Console.WriteLine(result);

//examples of filter the list lambda expression max and min
//   var result = st.Max(x => x.Age);
//         Console.WriteLine(result);
// var result2 = st.Min(x => x.Age);
//         Console.WriteLine(result2);

//examples of filter the list lambda expression avrage
//   var result = st.Where(c=>c.Age>20).Average(x => x.Age);
//         Console.WriteLine(result);

//examples of filter the list lambda expression count age>20
//    var result = st.Where(c=>c.Age>=20).Count();
//             Console.WriteLine(result);

//examples of filter the list lambda expression count any
//    var result = st.Where(c=>c.Age==20).Any();
//    if (result)
//    {
//        Console.WriteLine("age is 20");
//    }
//    else
//    {
//        Console.WriteLine("age is not 20");
//    }

//examples of filter the list lambda expression string
//   var result = st.Where(c=>c.Name.StartsWith("R"));
//     foreach (var item in result)
//     {
//         Console.WriteLine(item.Name);
//     }

//examples of filter the list lambda expression string
//   var result = st.Where(c=>c.Name.EndsWith("R") || c.Name.EndsWith("r"));
//     foreach (var item in result)
//     {
//         Console.WriteLine(item.Name);
//     }

//examples of filter the list lambda expression  string
//    var result = st.Where(c=>c.Name.Contains("o"));
//         foreach (var item in result)
//         {
//             Console.WriteLine(item.Name);
//         }
//examples of filter the list lambda expression  firstordefault
//   var result = st.Where(c=>c.Name.Contains("o")).FirstOrDefault();
//     Console.WriteLine(result.Name);

  
