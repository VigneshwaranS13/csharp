# Table of Contents
1. [Introduction](#1introduction)
2. [PrimitiveTypes And Expressions](#2primitivetypes-and-expressions)



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

#### Non-Primitive Types:

- String
- Arrary
- Enum
- Class

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






