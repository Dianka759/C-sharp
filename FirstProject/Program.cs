// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// //  data types
// // string name = "Georgie";
// // int number =  7;
// // double dec = 3.14;
// // float floatbalue = 1.2f;
// // bool isTired = true;


// // Lists and dictonaries
// // array and list
// // array - FIXED LENGTH

// //  [null, null, null, null]
// string[] groceryList = new string[4];
// string[] groceryList2 = { "bananas", "milk", "bread", "cheese" };
// groceryList[2] = "cheese";
// Console.WriteLine(groceryList[2]);
// Console.WriteLine(groceryList.Length);

// // list = variable length
// List<int> numberList = new List<int>();
// numberList.Add(6);
// numberList.Add(9);
// numberList.Add(6);
// numberList.Add(9);
// numberList.Add(6);
// numberList.Add(9);

// numberList.Remove(6);
// numberList.RemoveAt(3); //remove at index
// numberList.Insert(1, 5); //index, value

// Console.WriteLine(numberList.Count);
// Console.WriteLine(numberList);

// foreach (int i in numberList)
// {
//     Console.WriteLine(i);
// }

// String vs Char
// String contains multiple letters
// string words = "Hello";

// // Char only contains 1 letter and SPECIFICALLY uses single quotations
// char singeChar = 'd';


static void SayHello()
{
    Console.WriteLine("HELLo WORLD HOW U DOIN TODAY");
}
SayHello();


static string SayHelloString()
{
    return "Hello String";
}
Console.WriteLine(SayHelloString());


//                  parameters
static int DoMath(int a, int b) {
    return a - b;
}
//                arguments
int result = DoMath(10,7);
Console.WriteLine(result);



//  Dictionaries 
Dictionary<string, string> profile = new Dictionary<string, string>();
profile.Add("Name", "Diana");
profile.Add("Age", "25");
profile.Add("location", "Poland");

Console.WriteLine("Name: " + profile["Name"]);