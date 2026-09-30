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


// C# Exceptions 
// When some error happens you have to deal with this error by using Exceptions 

try
{
    // 10 / 0 is a compile-time constant division => CS0020 error 
    // so we use a variable holding zero to get a DivideByZeroException at RUNTIME 
    int numerator = 10; 
    int divisor = 0; 

    var testingException = numerator / divisor; 

    // this line is never reached, the exception jumps straight to the catch 
    Console.WriteLine(testingException); 
} catch (Exception e)
{
    Console.WriteLine($"Ixiii we got a error {e.Message}"); 
}

/*

    One of the very common Exceptions in .NET APIs 

    database failures 
    http failures 
    invalid input 
    external api failures 
    business rules 

*/ 


// Same project, same global namespace => no 'using' required 
BankAccount bc = new BankAccount(); 

bc.deposit(500.50m);

bc.deposit(499.50m); 

Console.WriteLine($"The bank balance is {bc.getBalance()} ");

/* Access Modifiers 

    private: only have access inside the class 
    public: visible to everyone (Least Restricted)
    protected: Visible inside its own class and any child 
    internal: visible to any code within the same project/assembly 

*/

//Concept of encapsulation 
//Keep data private in the class, just beeing access by its members(methods). 
//It is useful to protect bussiness rules. 

//Concept of Abstration 
//Showing only what is necessary and hidding implementation details 

//Concept of Inheritance 
//One class can inherit functionality from another  

//Concept of Polymorphism
//One same interface can represent more than one implementation

Dog dog = new Dog(); 
// The class dog inherits the method eat from the class animal. 
dog.eat(); 


class Person
{
    public string name { get; set; }
    public int age { get; set; }
}