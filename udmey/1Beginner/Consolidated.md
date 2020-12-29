# Table of Contents
1. [Introduction](#1introduction)
2. [PrimitiveTypes And Expressions](#2primitivetypes-and-expressions)
3. [Non-Primitive Types](#3non-primitive-types)
4. [Control Flow](#4control-flow)
5. [Arrays And List](#5arrays-and-lists)



## 1.Introduction

#### Byte code

- The compiler will compile the code into byte code which is platform independent

#### CLR

- Used to convert byte code into native code (like a just-in-time compiler)
- This native code is platform dependent

#### Architecuture

- Application conisist of building blocks called class
- classed collabrates with each other during runtime which will
give some functinalities

#### class

- class in a container which have some data/attributes and functions/methods
- data represnts state of the application
- fucntions/methods have behaviour which will do things
- As our appications grows we will have more no of classes,in order to manage classes
we have Namespaces


#### Namespace

- Its a container for related classes
- we have namespaces for working with database,security
- when namespacing grows we need different ways of 
partioning application
- That's where `Assembly` comes into  picture

#### Assembly (DLL or EXE)

- An assembly is a container for related namespaces
- Physically its file under disk which either can be executable(exe)
or dll(dynamic-link library)

- when we compile application the comiper will build one or more
assembly depending on how we partion our code

#### Summary



#### C# vs .NET

C# is a programming language, while .NET is a framework. It consists of a run-time environment (CLR) and a class library that we use for building applications.

#### CLR

When you compile an application, C# compiler compiles your code to IL (Intermediate Language) code. IL code is platform agnostics, which makes it possible to a take a C# program on a different computer with different hardware architecture and operating system and run it. For this to happen, we need CLR. When you run a C# application, CLR compiles the IL code into the native machine code for the computer on which it is running. This process is called Just-in-time Compilation (JIT).

#### Architecture of .NET Applications

- In terms of architecture, an application written with C# consists of building blocks called classes. A class is a container for data (attributes) and methods (functions). Attributes represent the state of the application. Methods include code. They have logic. That's where we implement our algorithms and write code.

- A namespace is a container for related classes. So as your application grows in size, you may want to group the related classes into various namespaces for better maintainability.

- As the number of classes and namespaces even grow further, you may want to physically separate related namespaces into separate assemblies. An assembly is a file (DLL or EXE) that contains one or more namespaces and classes. An EXE file represents a program that can be executed. A DLL is a file that includes code that can be re-used across different programs.



---

## 2.PrimitiveTypes And Expressions

#### Variable

A Name given to a storage location in memory

#### Constant

An immutable value

#### Declaring Variable/Constant

- we need to initialize and assign the variable before use it

int number;
int Number = 1;
`csharp is case sensitive`

const float Pi = 3.24f;

#### Identifier(Variable name)

- it cannot start with the number
- it cannot include whitespace
- it cant be a reserved keyword
- Always use meaningful names

#### Naming Conventions:

1. Camel Case 		 :firstName
2. Pascal Case 		 :FitstName
3. Hungarian Notation :strFirstName(not recommended mostly used in c,c++)


#### Recommendation :

- For local variable Camel Case  eg : int number;
- For constants use Pascal Case eg: const int MaxZoom =5;


#### Overflowing
```
byte number = 255;
number = number + 1 ; //result =0
```

- when we run above code overflow will occur at run time
- In c# sharp by default  we dont have overflow checking
- so we will not get notified if its exist boundary
- so we can use check keyword to check that

```
checked
{
byte number = 255;
number = number + 1 ;
}
```

- with above code overflow will not occur at run time
- it will thorw an exception and the program will crash 

#### Scope

- Scope is where a variable /constant has meaning and its accessible
```
{
	byte a = 1;
	{
	 byte b =2;
	   {
	    byte c =3;
	   }
	}	
}
```

- variable a is accessible in loop 1 and all its child loop whereas var b is accessible only in loop2 and its child loop 3

#### Demo

- By defalut all real numbers are assigned to double

eg :

float price =56.89;

- above code will through redline near that number.
- so we need add f to the number


float price =56.89f ;

#### var

- by using  var we dont need to explicitly assign datatype
- compiler will automatically take datatype

- by defalut c# will automatically take integral number as integral

- we can use object browser 


#### Format string
```
   Console.WriteLine("{0} {1}", byte.MinValue , byte.MaxValue);
   Console.WriteLine("{0} {1}",float.MinValue , float.MaxValue);
```
  - this will pass the values inide the paranthesis while compiling
  
#### Constant

```
const float Pi = 3.14f;
float Pi = 1.03f;
```

  
- it will show error in second line which represnts constant cannot be changed

`ERROR :Severity	Code	Description	Project	File	Line`	`Suppression State Error	CS0128	A local variable or function named 'Pi' is already defined in this scope`



#### Postfix

int a =1;
int b =a++;

a = 2 , b = 1

#### Prefix

int a = 1;
int b =++a;

a = 2, b = 2

#### DataTypes

![DataTypes](https://github.com/VigneshwaranS13/csharp/blob/master/udmey/1Beginner/Images/DataTypes.PNG)
#### Implicit conversion :(no data loss)

byte -> int
short -> int
int -> long
int -> float

#### Explicit conversion :(data loss occur)

int -> byte
float ->int
int->short
long->int

- if var overflow occurs in byte then the result will be 1

#### Non-compatible

string -> int
string ->bool

`methods used:`

- Convert
- Parse

to get the var type:

- variable_name.GetType()

#### comments

- single line `// here is a single-line comment`

- Multi-line comment 
```
/*
Here is a multiline
comment
*/
```

  
#### What are Logical Operations?
Logical operations are part of Boolean algebra .In Boolean algebra, the value of variables can only be true or false, also denoted 1 and 0 respectively. Unlike elementary algebra, where the main operations are addition, subtraction,etc.The main operations of Boolean algebra are `conjunction (AND), disjunction (OR) andnegation (NOT)`. 

#### Clean Coding
When it comes to coding, you should avoid using variable names such as x, y, z as they don’t give a clue to other developers reading your code (or even yourself). Instead, use meaningful
names. For instance, we can use  x, y and z as follows:
x: isOver18
y: isCitizen
z: isEligible
Often, it’s a good practice to prefix Boolean names with IS or HAS (if possible).

---

## 3.Non-Primitive Types

- Class
- Structs
- Arrary
- String
- Enum


#### Class

- combines  related  varibles(fields) and functin(methods)
- its a blueprint from which we create an object
- Object is an instance of class


#### Declaring class

```
public class Class_Name
{
 public string var_name;
 public return_type method()
 {
 
 }
}
```

#### void :

- is the return type which does not return any values

`eg :`


```
public class Person
{
 public string Name;
 public void Introduce()
 {
     Console.WriteLine("Hi, My name is",Name);
 }
}
```

- this class have Introduce method with void ,so it will not return any values
- this introduce method does not take any parameter as indicated by empty parenthsis


```
public class Calculator
{
  public int Add(int a ,int b)
 {
     return a+ b;
 }
}
```
- This class have add method which will take two integers as arugument and return sum of those integers

#### Creating Objects

- like declaring variable we start with creating object like below
```
Person person = new Person();
\\or
var person = new Pwerson();
```

- we need to explicitly allocate memory for the objects thats where we are using `new` operator
- CLR will take care of memory utlization by using the process called `Garbage collection`
- now we have person object we can access its members
- its better to have one class per file

```
person.Name = 'Vignesh';
person.Introduce();
```


#### Static Modifier

```
public class Calculator
{
  public static int Add(int a ,int b)
 {
     return a+ b;
 }
}
```
- we can add static keyword to add method,as a result we can directly access the method  by the calculator class itself.
- we do not need to create objects for accessing static members (And we cannot)


`int result = Calculator.Add(1,2);`

#### use of static modifier

- without the static modifier,when we create  objects of  this calculator class ,each objects in the memory will have the add method

- but when we applied static modifier that add method will be in one place in memory .i.e calcultor class itself
- we use the static modifier when we want to use the concept that only a single instacne of that should exisit in memory

- main and current datetime are eg for the static modifier


#### Demo

#### Person.cs
```
public class Person
    {
        public string FirstName;
        public string LastName;
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
```	

#### Calculator.cs
```
public class Calculator
    {
        public int Add(int a ,int b)
        {
            return a + b;
        }
    }
```	
#### Program.cs
```
static void Main(string[] args)
        {
            Person vicky = new Person();
            vicky.FirstName = "vigneshwaran";
            vicky.LastName = "s";
            vicky.Introduce(); 

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);			
        }
```
#### Note :		
All methods of console application is static,becuse we have only one console

### Structure / Struct

- another type similar to class
- in terms of syntax its very similar to a class except the struct keyword

```
public struct RgbColor
{
 public int Red;
 public int Green;
 public int Blue;
}
``` 

- we can use struct when we want to create a small lightweight object like above or when we dealing with point which has x and y
- when we want to define thousands of objects like above structure more efficient
 
 #### Array

- Array is a data structure  which is used to store a collection of variables of the same type

#### Declaring Array

`int[] numbers = new int [3];`

- arrays are fixed size in csharp
- we need to specifyt the array while declaring and it can't be changed
- when declaring array we need to allocate memory for that ,that is where `new` keyword comes into the picture
- `In csharp we have class called array,so when we create an intance of that an array class,its an object so only we need to allocate memory for this`

#### Accessing Array

- we can access array elaments using an index
- In csharp array is zero indexed,which means the first element of
an array have the index of zero

```
int[] numbers = new int[3];

numbers[0]= 1;
numbers[1]= 2;
numbers[2]= 3;
```

#### Object initialization syntax

- during the declartion itself we can supply the values in curly braces 
` int [] numbers = new int [3] {1,2,3}; `

- when we decalring values we need to pass the value for all element
`var numbers = new int[3] { 1, 2 };`
- above will throw error

#### demo

- when we declare an array all the elaments value in the array are set to defalut datatype of that array(eg 0 for int datatype,False for boolean datatype,empty for string)

```
var numbers = new int[3] {1,2,3};
// int[] numbers = new int[3];
numbers[2] = 30;
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);

var bools = new bool[3];
bools[1] = true;
bools[0]= false;
Console.WriteLine(bools[0]);
Console.WriteLine(bools[1]);
Console.WriteLine(bools[2]);//false

var letters = new string[3];
Console.WriteLine(letters[0]);
Console.WriteLine(letters[1]);
Console.WriteLine(letters[2]);
```			

#### String
- sequence of characters
- its is surrounded by double quotes whereas the characters are surrounded by singles quotes

#### Creating Strings

` string name = "Vignesh";`
` sting name = firstName + " " + lastname;`

- we can also add concatenation

#### String Format

` string name = string.Format("{0} {1}",firstName,lastname);`

- `in csharp string keyword maps to the String class in Dot Net framework .In that class, Format is a static method,`so we can direclty access that method;
- this mehod takes couple of parameters . format string i.e .{0] {1} - which we used to define a template for a string inside this template.Inside the template we have placeholders ,placeholders are indiacated by curly braces which used to store
the values

`var numbers = new int[3] {1,2,3};`
`string list = string. Join(",",numbers);`

- Join in a static method for a string class
- It takes two arguments
- the fist argument is a string which is a separator
- the second argument is the array whose elements we would like to combine

#### String Elements


`string name = "Vignesh";`
`char firstchar = name[0];`

Now that we have a string we can access each of individual charcter using an index

#### String Properties

- Strings are `immutable`,which means once we create them we cannot change them
- we can manipulate strings using methods but it will create a new string but the original string will not change 

#### Escape characters :

```
\n  -> New Line
\t  ->tab
\\  ->Backslash
\'  ->single Quotation Mark
\'' -> double quotation mark

```

#### Verbatim Stings

`string path = "c :\\projects\\project1\\folder1";`

 - because of these special characters there are cases while creating
 string become little bit messy
 
 - in csharp we have `verbatim` string with this string we can get rid of  all this double backslashes
 
 `string path = @"c :\projects\project1\folder1";`

#### Demo
```
var firstname = "MS";
var lastname = "dhoni";
var fullname = string.Format("My favaourite crickter is {0} {0}", firstname, lastname);
Console.WriteLine(fullname);

var names = new string[3] { "MS", "Dhnoi", "Forever" };
var combined = string.Join(",", names);
Console.WriteLine(combined);

var text1 = "Hi\nHow are you?\nHow was your day\nPFB path for file in my system\nC:\\windows\\project\\file1.txt";
Console.WriteLine(text1);

// Verbatim string
var text2 = @"C:\windows\project\file1.txt";
Console.WriteLine(text2);
```

#### Enum

- An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).

#### Syntax

```
public enum ShippingMethod 
    { 
        RegularMail =1,
        Registered =2,
        Express =3
    }
```
- Enum is internally a integer
- if we want to change to byte then we need to mention the same while creating  enum

```
public enum ShippingMethod :byte
    { 
        RegularMail =1,
        Registered =2,
        Express =3
    }	
```

#### ToString

- we can convert any object to string using ToString()
- Console.Writeline will always convert any value to string,so we dont need to use ToSting method while working on console application
- if we are not using Console.Writeline then we need to use ToString() to convert to string

#### Parsing

- Parsing in programming means getting a string and converting it into different data type
- in case we want to convert string datatype to enum then we can use the below syntax

```
var methodName = "Registered";
var enumconvertedvar = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
Console.WriteLine(enumconvertedvar);//Registered
Console.WriteLine(enumconvertedvar.GetType());//CSharpFundamentals.ShippingMethod
```

- type is the method in .net which containd metadata bout all the datatypes,We can user typeof operator whenever we want to see the data type of variable.

#### Demo

```
public enum ShippingMethod 
    { 
        RegularMail =1,
        Registered =2,
        Express =3
    }
    public enum ShippingMethod2
    {
        RegularMail,// by default it will asssign value 0 for the first member and will automatically increment by 1
        Registered,
        Express
    }
    public enum ShippingMethod3 : byte
    {
        RegularMail,// by default it will asssign value 0 for the first member and will automatically increment by 1
        Registered,
        Express
    }
class Program
{   
	
	static void Main(string[] args)
	{

		var method = ShippingMethod.Express;
		Console.WriteLine((int)(method));// 3
		Console.WriteLine(method);// Express

		var methodID = 2;
		Console.WriteLine((ShippingMethod)(methodID)); // Express

		var method2 = ShippingMethod2.Express;
		var method3 = ShippingMethod2.Registered;
		var method4 = ShippingMethod2.RegularMail;
		Console.WriteLine((int)method2);//2
		Console.WriteLine((int)method3);//1
		Console.WriteLine((int)method4);//0
		Console.WriteLine(method2.GetType());//CSharpFundamentals.ShippingMethod2

		var method5 = ShippingMethod3.Express;
		var method6 = ShippingMethod3.Registered;
		var method7 = ShippingMethod3.RegularMail;
		Console.WriteLine((byte)method5);//2
		Console.WriteLine((byte)method6);//1
		Console.WriteLine((byte)method7);//0
		Console.WriteLine(method5.GetType());//CSharpFundamentals.ShippingMethod3

		Console.WriteLine(method2.ToString());//console.writeline will automatically convert the var to string

		var methodName = "Registered";
		var enumconvertedvar = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
		Console.WriteLine(enumconvertedvar);//Registered
		Console.WriteLine(enumconvertedvar.GetType());//CSharpFundamentals.ShippingMethod




	}
}
```	

#### RefTypes and values
In csharp we have two main types from which we create new type

1. Structures
2. Classes

#### Structures

- primtive types
- Custom strucures


#### Classes

- Arrays
- Strings
- Custom classes

#### Value Tpes(Structures)

- when we create varible in value type a part of memory called `stack` is allocated for that varible
- Memory allocation done automatically
- when this variable get out of scope it will immediately
get removed from stack by runtime /CLR
 

####  Reference Types (Classes)

- Programmer need to allocate the memory with the new operator
- Memory alloccation happen in different area of memory called `heap`
- This memory is more sustainable
- so the object created in heap memory will continue in memory for little while even if the object get out of scope
- it will get removed by the process called `Garbage collector` while runtime or by CLR

#### Demo

```
	// value type will create a copy of var with new memory location in stack
	var a = 5;
	var b = a;
	b++;
	Console.WriteLine(string.Format("a :{0} b : {1}",a,b));// a=5,b=6

	/*reference type will copy of the refrence of the variable  which is present in heap to the stack
	so if we assign to other var then it will create another reference in stack which will refernce to
	the same heap memory location*/

	var numbers = new int[3] { 1, 2, 3 };
	var numbers2 = numbers;
	numbers2[0] = 200;
	Console.WriteLine(string.Format("numbers[0] is : {0} and  numbers2[0] :{1}", numbers[0], numbers2[0]));
```

```
	public class Person2
	{
		public int Age;
	}
    class Program
    {   
        
        static void Main(string[] args)
        {
            // since we have value type(int) in method Increment it will copy the value of var numbers in another location and will add 10
            // This whole process will take place in stack
            var number = 5;
            Incrememt(number);
            Console.WriteLine(number);

            // Here we have refernce type (Person class object) so when we do MakeOld method it will copy the refernce to object p1 and it will add the age
            // Here the process takes place in heap except creation of reference which will happen in Stack
            Person2 Person2_obj = new Person2() { Age = 30 };
            MakeOld(Person2_obj);
            Console.WriteLine(Person2_obj.Age);//50
        }
        public static void Incrememt(int a)
        {
            a += 10;
        }
        public static void MakeOld(Person2 p1)
        {
            p1.Age += 20;
        }
    }
```	
---

## 4.Control Flow

#### Conditional statements 

1. if/else statements
2. Switch/case statements

- we also have conditional operator (which is shortcut for using if and else)
` a? b : c`

#### if/else

syntax :

```
if (condition)
	Statement;
else if (anotherCondition)
	anotherStatment;
else
    otherStatment;
```

- if we have more than one line of code, then we need to enclose them with curly braces
- we can also have mutiple if else statements which is called `nested if/else`


#### Switch/case

- In switch/case , we have variable and compare the value of the variable with different method

```
switch(variable)
{
 case var.method1();
        ...
		break;
 case var.method2();
        ...
		break;
 default :
        ...
		break;
 ```
 
 #### Demo if-else

 ```
	int hour = 18;
	// using if else
	if (hour > 0 && hour < 12)
	{
		Console.WriteLine("Its morning");
	}
	else if (hour >= 12 && hour < 18)
	{
		Console.WriteLine("Its afternoon");
	}
	else
	{
		Console.WriteLine("It's evening");
	}


	bool IsGoldCustomer = true;

	//float price;

	//if (IsGoldCustomer)
	//{
	//    price = 10.58f;
	//    Console.WriteLine(price);
	//}
	//else
	//{
	//    price = 8.58f;
	//    Console.WriteLine(price);
	//}

	// using conditional operator
	float price2 = (IsGoldCustomer) ? 10.58f : 8.58f;
	Console.WriteLine(price2);
```			
 #### Demo switch

 ```
	var season = Season.Spring;
	switch(season)
	{
		case Season.Autumn:
			Console.WriteLine("Its autumn season");
			break;
		case Season.Winter:
			Console.WriteLine("It's winter season");
			break;
		case Season.Summer:
			Console.WriteLine("Its summer season");
			break;
		default:
			Console.WriteLine("It's Spring :) ");
			break;
	}

	// in case if we want the same op for two cases

	var season2 = Season.Winter;
	switch (season2)
	{
		case Season.Autumn:                    
		case Season.Winter:
		// this will act like a or operator
			Console.WriteLine("It's either autmn or winter season,enjoy");
			break;
		case Season.Summer:
			Console.WriteLine("Its summer season");
			break;
		default:
			Console.WriteLine("It's Spring :) ");
			break;
	}

 ```



 #### Iteration Statements
- used to repeately execute the sequence of statments.In c-sharp we have 4 iteration statments

1. for loops
2. foreach loops
3. while loops
4. do-while loops

#### for loops
```
for (var i = 0; i < 10; i++)
{

}
```

i -> counter - > initialization clause
i<10 -> conditonal clause
i++ -> iteration clause(increment/decrement counter)

#### Demo for loop

```
	// To print odd or even number within 10
	for (var i = 1; i <= 10; i++)
	{
		if (i % 2  == 0)
		{
			Console.WriteLine(string.Format("Even number : {0}",i));
		}
		else
		{
			Console.WriteLine(string.Format("Odd number : {0}",i));
		}
	}

	// To reverse the order
	for (var i = 10; i >=1; i--)
	{
		if( i % 2 ==0 )
		{
			Console.WriteLine(string.Format("even number : {0}", i));
		}

		else
		{
			Console.WriteLine(string.Format("odd number : {0}", i));
		}
	}
```

#### foreach
```
foreach ( var number in numbers)
{

}
```
- foreach is used to iterate over elements of Enumerable object(list,array or simply collection)

#### Demo foreach loop

```
	var name = "Vignesh";
	// with for loop
	for (var i = 0; i < name.Length; i++ )
	{
		Console.WriteLine(name[i]);
	}
	// with foreach

	foreach(var letter in name)
	{
		Console.WriteLine(letter);
	}

	// foreach for array

	var numbers = new int[5] { 1, 2, 3, 4, 5 };
	foreach (var number in numbers)
	{
		Console.WriteLine(number);
	}
```

#### while
```
while (i <10)
{
...
i++
}
```

- loop will execute till the condition meet

#### Demo while loop

```
	//for (var i =0; i <=10; i++)
	// {
	//     if ( i % 2 == 0)
	//     {
	//         Console.WriteLine(i);
	//     }
	// }
	/* same code in while loop */
	var i = 1;
	while (i <= 10)
	{
		if (i % 2 == 0)
		{
			Console.WriteLine(i);
		}
		i++;
	} 
	
	//while (true)
	//{
	//    Console.Write("Type your name ");
	//    var input = Console.ReadLine();

	//    if (string.IsNullOrWhiteSpace(input))
	//    {
	//        break;
	//    }
	//    else
	//    {
	//        Console.WriteLine(" @Echo " + input);
	//    }
	//} 
	// same program in differnt format
	while (true)
	{
		Console.Write("Type your name");
		var input = Console.ReadLine();
		if (!(string.IsNullOrWhiteSpace(input)))
		{
			Console.WriteLine("@Echo  " + input);
			continue;
		}
		break;
	}
```

#### do-while

```
do
{
...
i++
}while (i <10);
```
- it will executed atleast once


- `Break` - jumps out of the loops
- `continue` - jumps to the next iteration



#### which loop should used

- its better to use for loop when we know the iteration value
- its better to use while loop when we dont know the iteration value


 #### Demo Random string

 ```
	//var random = new Random();

	//for (var i = 0; i <= 10; i++)
	//    Console.Write((char)random.Next(97, 122));

	//Console.WriteLine((int)'a'); // 97
	//Console.WriteLine((int)'z'); // 122

	//for (var i = 0; i <= 10; i++)
	//    Console.Write((char)('a'+random.Next(0, 26)));
	//    Console.WriteLine();
	//    Console.Write(('a' + random.Next(0, 26)));// when we add a charcter to the number  the result it going to be a number
	//Console.WriteLine();

	var random = new Random();
	var passwordLength = 10;
	char[] buffer = new char[passwordLength];

	for (var i=0;i < passwordLength; i++)
		buffer[i] =(char)('a'+ random.Next(0,26));
	var password = new string(buffer);
	Console.WriteLine(password);
 
 ```
 ---

## 5.Arrays And Lists

 #### Array

- Arrays represents a fixed number of variables of particular type


In  c-sharp we have two types of arrays

1. Single Dimension Array
2. Multi Dimension Array

#### Single Dimension Array

- the one which we seen earlier
- it have one datatype collection

` var numbers = new int[5]`
` var numbers = new int[5] { 1,2,3,4,5}`

- In above eg,we have an single dimesion array of int type with the length of array as 5

#### Multi Dimension Array

- we have two types of multi-dimesion array

1. Rectangular
2. Jagged 

#### Rectangular
- each row has the exact same number of columns

Syntax :

```
var matrix = new int[3,5] ; // 3-> rows , 5 -> columns
var matrix = new int[3,5] 
{
    {1,2,3,4,5},
    {6,7,8,9,10},
    {11,12,13,14,15}
};
var element = matrix [0,0] ; // 1
```

3D Array :
```
var matrix = new int[3,5,4] ;
```

#### Jagged ( array of arrays)
- number of columns in each row can be different

Syntax  :

```
var matrix1 = new int[3] [] ; 

matrix1[0] = new int[4]{3,6,9,12};
matrix1[1] = new int[3];
matrix1[2] = new int[3];

matrix1[0][0];// 3

```

#### differnce
- in jagged array we have 2 square brackets,in rectangular array we have 1 square brackets
- In dotnet CLR is optimized for single dimenison arays
- to model a matrix jagged array is faster than a rectangular array

#### Demo

```
	var ary1 = new [] { 1, 2, 3, 4, 5 };

	// Length

	Console.WriteLine(" Length : " + ary1.Length);

	/** ary1.Length --instance member which means its not static
	Array.Clear -- this is static method in array class which can be directly accessible **/


	// IndexOf

	var position = Array.IndexOf(ary1, 3);
	Console.WriteLine("index of number 3 is : " + position);

	//Clear

	Array.Clear(ary1, 0, 2);
	Console.WriteLine("Effect of clear()");
	foreach (var i in ary1)
		Console.WriteLine(i);

	//Copy

	var another = new int[3];

	Array.Copy(ary1, another, 3);
	Console.WriteLine("Effect of copy");
	foreach (var i in another)
		Console.WriteLine(i);

	// Sort

	Array.Sort(ary1);
	Console.WriteLine("Effect of sort()");
	foreach (var i in ary1)
		Console.WriteLine(i);
	// Reverse

	Array.Reverse(another);

	Console.WriteLine("Effect of reverse()");
	foreach (var i in another) 
		Console.WriteLine(i);
```					
#### List

- Arrays have fixed size,once we create them we cannot change the size
- if we don't know the number of objects which we are going to use then we can't use arrays,That's where `List` comes into the picture
- similar to array ,List is a data structure for storing number of objects of the same type

- To create a list

`var numbers = new List<int>();`

#### Generic tips :
- when we work on generic type we need to mention the generic type inside the angle bracket
-  we can initialize list using object initialization method

`var numbers = new List<int>() { 1,2,3,4};`

#### Useful methods :

- Add()
- AddRange()
- Remove()
- RemoveAt()
- IndexOf()
- Contains()
- Count()

#### Demo

```
	//Lists
	var numbers = new List<int> { 1, 2, 3, 4, 5 };
	numbers.Add(6);
	numbers.AddRange(new int[4] { 6, 7, 8, 9 });
	foreach(var number in numbers)
	{
		Console.WriteLine(number);
	}
	Console.WriteLine();
	numbers.Add(3);
	Console.WriteLine("index of 3 is "+numbers.IndexOf(3));
	Console.WriteLine("Last Index of 3 is " +numbers.LastIndexOf(3));
	Console.WriteLine("count" + numbers.Count);
	numbers.Remove(3);

	foreach (var number in numbers)
	{
		Console.WriteLine(number);
	}
	Console.WriteLine("Removal of list objects ");
	//Let's try to remove all the 3s from the app

	//foreach (var number in numbers)
	//{
	//    if(number == 3)
	//    {
	//        numbers.Remove(number);
	//    }
	//}

	// application will crash for above code 
	//because in csharp  we cannot modify the collection inside foreach loop
	/**The collection used in foreach is immutable. This is very much by design. ... The foreach statement is used to iterate through the collection to get the information that we want, but can not be used to add or remove items from the source collection to avoid unpredictable side effects
	//same can be done via for loop**/
	for (var i = 0; i <numbers.Count; i++)
	{
		if(numbers[i]==3)
		{
			numbers.Remove(numbers[i]);
		}
	}
	foreach (var number in numbers)
	{
		Console.WriteLine(number);
	}
	Console.WriteLine("Before clearing count was : " + numbers.Count);
	numbers.Clear();//will remove all elements from the list
	Console.WriteLine("after clearing count was  : "+numbers.Count);
```
 ---

 
 
 
 
 













 



  



