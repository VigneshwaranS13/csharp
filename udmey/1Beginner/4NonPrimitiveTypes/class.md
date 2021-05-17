## Class

- combines  related  varibles(fields) and functin(methods)
- its a blueprint from which we create an object
- Object is an instance of class


## Declaring class

```
public class Class_Name
{
 public string var_name;
 public return_type method()
 {
 
 }
}
```



## void :

- is the return type which does not return any values

eg :


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

- thie class have Introduce method with void ,so it will return any values
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

## Creating Objects

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
peraon.Name = 'Vignesh';
peraon.Introduce();
```


## Static Modifier

```
public class Calculator
{
  public static int Add(int a ,int b)
 {
     return a+ b;
 }
}
```
- we can add static keyword to add method,as a result we can directly access
the method  by the calculator class itself.
- we do not need to create objects for accessing static members (And we cannot)


`int result = Calculator.Add(1,2);`

## use of static modifier

- witout the static modifier,when we create 3 objects of  this calculator class ,each objects in the memory
will have the add method

- but when we applied static modifier that add method will be in one place in memory .i.e calcultor class itself
- we use the static modifier when we want to use the concept that only a single
instacne of that should exisit in memory

- main and current datetime are eg for the static modifier


## Demo

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
### Note :		
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

- we can use struct when we want to create a small lightweight object like above or when we dealing
with point which has x and y
- when we want to define thousands of objects like above structure more efficient
 
 



  
