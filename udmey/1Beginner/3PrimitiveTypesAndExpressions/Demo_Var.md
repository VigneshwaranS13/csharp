## Demo

- By defalut all real numbers are addignes to double

eg :

float price =56.89;

- above code will through redline near that number.
- so we need add f to the number


float price =56.89f ;

## var

- by using  var we dont need to explicitly addign datatype
- compiler will automatically take datatype

- by defalut c# will automatically take integral number as integral

- we can use object browser 


## Format string

   Console.WriteLine("{0} {1}", byte.MinValue , byte.MaxValue);
   Console.WriteLine("{0} {1}",float.MinValue , float.MaxValue);
  
  - this will pass the values inide the paranthesis while compiling
  
## constant

const float Pi = 3.14f;
float Pi = 1.03f;
  
- it will show error in second line which represnts constant cannot be changed

##### ERROR :Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0128	A local variable or function named 'Pi' is already defined in this scope

  
  
