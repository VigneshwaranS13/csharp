## Enum

- An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).

## Syntax

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

## ToString

- we can convert any object to string using ToSting()
- Console.Writeline will always convert any value to string,so we dont need to use ToSting method
- if we are not using Console.Writeline then we need to use ToString() to convert to string

## Parsing

- Parsing in programming means getting a string and converting it into different data type
- in case we want to convert string datatype to enum then we can use the below syntax

```
var methodName = "Registered";
var enumconvertedvar = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
Console.WriteLine(enumconvertedvar);//Registered
Console.WriteLine(enumconvertedvar.GetType());//CSharpFundamentals.ShippingMethod
```

- type is the method in .net which containd metadata bout all the datatypes,WE can user typeof operator whenever we see the type






