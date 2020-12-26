## Array

- Array is a data structure  which is used to store a collection of variables
of the same type

## Declaring Array

`int[] numbers = new int [3];`

- arrays are fixed size in csharp
- we need to specifyt the array while declaring and it can't be changed
- when declaring array we need to allocate memory for that ,that is where
`new` keyword comes into the picture
- In csharp we have class called array,so when we create an intance of that
an array class,its an object so only we need to allocate memory for this

## Accessing Array

- we can access array elaments using an index
- In csharp array is zero indexed,which means the first element of
an array have the index of zero

```
int [] numbers = new int[3];

numbers[0]= 1;
numbers[1]= 2;
numbers[2]= 3;

```

## Object initialization syntax

- during the declartion we can supply the values in curly braces

` int [] numbers = new int [3] {1,2,3}; `

- when we decalring values we need to pass the value for all element
`var numbers = new int[3] { 1, 2 };`
- above will thorw error

## demo

- when we declare an array all the elaments value in the array are set to defalut
datatype of that array(eg 0 for int datatype,False for boolean datatype,empty for string)




