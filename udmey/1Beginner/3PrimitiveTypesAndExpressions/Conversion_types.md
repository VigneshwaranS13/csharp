Postfix

int a =1;
int b =a++;

a = 2 , b = 1

Prefix

int a = 1;
int b =++a;

a = 2, b = 2

## Implicit conversion :(no data loss)

byte -> int
short -> int
int -> long
int -> float

## Explicit conversion :(data loss occur)

int -> byte
float ->int
int->short
long->int

- if var overflow occurs in byte then the result will be 1

## Non-compatible

string -> int
string ->bool

methods used:

- Convert
- Parse

convert is the class in the system namespace.common convert class methods are

- ToByte()
- ToInt16()
- ToInt32()
- ToInt64()

Parse method takes a string and try to change it to the target type

To get the var type:

- variable_name.GetType()

## commnets

- single line // here is a single-line comment

- Multi-line comment 
```
/*

Here is a multilinr
comment

*/

```