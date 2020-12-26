## Stringbuilder

- string class is immutable
- If we want to lot of edit in string then we can use stringBuilder
- Its a class defined in `System.Text`
- A mutable string
- Easy and fast to create and manipulate stings
- It doesnt have searching methods like strings.Instead it have manipulation
methods

1 Append()
2 Insert()
3 Remove()
4 Replace()
5 Clear()

## Quiz

StringBuilder only provides methods for fast and efficient manipulation of 
strings. It doesn't have any methods to search in strings. If we need to 
search in a string that we're building using a StringBuilder, we need 
to cover it to a string first: builder.ToString().IndexOf('M').
