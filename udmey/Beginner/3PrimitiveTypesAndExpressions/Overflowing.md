## Overflowing
byte number = 255;
number = number + 1 ; //result =0

- when we run above code overflow will occur at run time
- in c# sharp by default  we dont have overflow cheking
- so we will gor notified if its exist boundary
- so we can use check keyword to check that

checked
{
byte number = 255;
number = number + 1 ;
}

- with above code overflow will not occur at run time
- it will thorw an exception and the program will crash 

## Scope

- Scope is where a variable /constant has meaning and its accessible

{
	byte a = 1;
	{
	 byte b =2;
	   {
	    byte c =3;
	   }
	}	
}

- variable a is accessible in loop 1 and all its child loop whereas var b is accessible
only in loop2 and its child loop 3
