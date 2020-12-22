## String methods

1 Formatting

- ToLower()
- ToUpper()
- Trim() -- used to remove whitespace

2 Searching 

- IndexOf('c')--(char) or IndexOf("String")
- LastIndexOf('c')--(char) or LastIndexOf("string")

3 SubStrings

- SubString(startIndex)
- SubString(startIndex,Length)

4 Replacing

- Replace('e','E') --we can replace character
- Replace("like","Liked") -- we can replace strings

5 Null checking

- String.IsNullOrEmpty(str)
- String.IsNullOrWhiteSpace(str)

6 Splitting

- str.Split(' ')

Above eg. we are splitting string using  empty character.It will return array of stings


## Converting Strings to Numbers 

string s = "1234";
int i = int.Parse(i);		//for null values this will throw error while converting
int j = Convert.ToInt32(s); //for null values it will convert it into 0

## Converting Numbers to  Strings

int i = 1234;

string s = i.ToString() ;     //"1234"
string t =i.ToString("C");    // "$1234.00"
string t = i.ToString("C0");   //"$1234"

we can find the details [here] (https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)






















