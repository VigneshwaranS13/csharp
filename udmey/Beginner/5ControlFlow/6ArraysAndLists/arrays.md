## Array

- Arrays represents a fixed number of variables of particular type


In  c-sharp we have two types of arrays

1. Single Dimension Array
2. Multi Dimension Array

## Single Dimension Array

- the one which we seen earlier
- it have one 

` var numbers = new int[5]`
` var numbers = new int[5] { 1,2,3,4,5}`

- In above eg,we have an single dimesion array of int type with the length of array as 5

## Multi Dimension Array

- we have two types of multi-dimesion array

1. Rectangular
2. Jagged 

### Rectangular
- each row has the exact same number of columns

Syntax 2D :

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

Syntax 3D :

```
var matrix = new int[3,5,4] ;
```

### Jagged ( array of arrays)
- number of columns in each row can be different

Syntax  :

```
var matrix1 = new int[3] [] ; 

matrix1[0] = new int[4]{3,6,9,12};
matrix1[1] = new int[3];
matrix1[2] = new int[3];

matrix1[0][0];// 3

```

### differnce
- in jagged array we have 2 square brackets,in rectangular array we have 1 square brackets
- In dotnet CLR is optimized for single dimenison arays
- to model a matrix jagged array is faster than a rectangular array

