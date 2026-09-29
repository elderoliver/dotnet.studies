// See https://aka.ms/new-console-template for more information


//Declaring a string variable 
string name = "Elder";

//Declaring a int Variable 
int age = 18;

//Declaring a decimal variable 
decimal price = 1000.99m; // the "m" means a decimal literal 

double temperature = 35.9; 

/* decimal and double are different in C# */

bool isActive = true; 

char myFirstNameLetter = 'E'; // It allows just one character AND use SINGLE quotes 

/* and We can use var which automacally set the type according with the value */
var myName = "Elder"; 
var myAge = 36; 

/* BUT 'VAR' DOES NOT MEAN THAT C# IS DYNAMICALLY TYPED */

// Because you cannot do later 
// myAge = "Elder"; 


/* CONSTANTS */

const decimal tax = 10.5m;  // The value never changes 

// What the difference between a contanst and a readonly field 
// R: the constant is compile time and readonly can be change during the initialization/constrution 

Console.WriteLine("Hello, World!");


/* Operators */

int a = 10; 
int b = 20; 

Console.WriteLine(a + b); 
Console.WriteLine(a - b); 
Console.WriteLine(a * b); 
Console.WriteLine(a / b); 
Console.WriteLine(a % b); // modulus operator  


// Important integer Division 
// If I do have two operands integers the result will be integer 
int number1 = 10; 
int number2 = 3; 

// This result will be 3 not 3.3333

Console.WriteLine(number1 / number2); 


// but if you declare this way 

double number1Double = 10; 
double number2Double = 3; 

Console.WriteLine(number1Double / number2Double); 


// Concatenate String 

// old way 
string fullName = "Elder" + " " + "Oliveira"; 
// new way 

string firstName = "Elder";
string surName = "Oliveira"; 
string fullNameNewWay = $"{firstName} {surName}"; 

Console.WriteLine(fullNameNewWay); 


/* Conditions */

int age2 = 18;

if (age2 >= 18)
{
    Console.WriteLine("You are a adult");
} else
{
    Console.WriteLine("You are an teenager or a kid."); 
}

/*

    Comparison Operators

    ==    equal
    !=    different
    >     greater than
    <     less than
    >=    greater than or equal
    <=    less than or equal

*/

/* Logical Operators */

// AND &&
// OR ||
// NOT ! 

/* Loops */ 

Console.WriteLine("FOR LOOP"); 
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i); 
}

Console.WriteLine("WHILE");

int counter = 0; 

while (counter < 5)
{
    Console.WriteLine(counter); 
    counter++; 
}

/* Declaring an array */ 

int[] numbers = { 10, 20, 30, 40 }; 

// arrays are zero-indexed 
Console.WriteLine(numbers[0]); 

/* foreach */

// very common in backend C# 

string[] names =
{
    "Elder",
    "Jonh",
    "Maria"
} ;

foreach(string item in names)
{
    Console.WriteLine(item); 
}

// Very common dealing with Collections 

/* Methods */

static void myMethod()
{
    Console.WriteLine("Hello from myMethod"); 
}

myMethod(); 

static void myMethodWithParameters(string parameter)
{
    Console.WriteLine($"My string parameter is {parameter}");
}

myMethodWithParameters("I am a Backend Software Engineer");

/* Methods wich return values */

static int Add(int a, int b)
{
    return a + b; 
}

/* Classes and Objects */


Person person = new Person(); 

person.name = "Elder"; 

person.age = 36; 

// or 
// object initializer 
Person person2 = new Person
{
    name = "Elder", 
    age = 36
}; 



/* ** The four OOP concepts ** */ 

// Encapsulation -> Keeping data and behavior together and controlling access 
// Abstration -> Showing only what is necessary and hiding implemantation details. 
// Inheritance -> One class can inherit functionality from another
// polymorphism -> One same interface can represent more than one implementation 

/* Collections */

// in real backend development, you will work with collections much more than arrays. 
// List<T>

List<string> listName = new List<string>();

listName.Add("Elder"); 
listName.Add("Oliveira");

foreach(var item in listName)
{
    Console.WriteLine(item); 
}


/*

    List<T>
    Dictionary<TKey, TValue>
    HashSet<T>
    IEnumerable<T>
    ICollection<T>
    IList<T>

*/



/* Nullable values */ 

string variableCannotBeNull = "can not be null"; 

string? variableMayBeNull = "can be null"; 

// it helps prevents NullReferenceException in modern C# 


class Person
{
    public string name { get; set; }
    public int age { get; set; }
}