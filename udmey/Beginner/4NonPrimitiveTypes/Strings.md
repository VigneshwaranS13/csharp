## String
- sequence of characters
- its is surrounded ny double quotes whereas the characters are surrounded by singles quotes

## Creating Strings

` string name = "dhoni";`
` sting name = firstName + " " + lastname;`

- we can also add concatenation

## String Format

` string name = string.Format("{0} {1}",firstName,lastname);`

- in csharp string keyword maps to the Sting class in Dot Net framework.In that class
Format is a static method,so we can direclty access that method;
- this mehod takes couple of parameters . format string i.e .{0] {1} -which we used to define a template for a string inside this template
Inside the template we have placeholders ,placeholders are indiacated by curly braces which used to store
the values

`var numbers = new int[3] {1,2,3};`
`string list = string. Join(",",numbers);`

- Join in a static method for a string class
- It takes two arguments
- the fist argument is a string which is a separator
- the second argument is the array whose elements we would like to combine

## Sting Elements


` string name = "Mosh";`
`char firstchar = name[0];`

Now that we have a string we can access each of individual charcter using an index

## String Properties

- Stings are `immutable`,which means once you create them you cannot change them
- we can manipulate strings using methods but it will create a new string but the original string will
not change instead it will generate a new string

## Escape characters :

```
\n  -> New Line
\t  ->tab
\\  ->Backslash
\'  ->single Quotation Mark
\'' -> double quotation mark

```

## Verbatim Stings

`string path = "c :\\projects\\project1\\folder1";`

 - because of these special characters there are cases while creating
 string become little bit messy
 
 - in csharp we have `verbatim` string with this string we can get rid of 
 all this double backslashes
 
 `string path = @"c :\projects\project1\folder1";`





