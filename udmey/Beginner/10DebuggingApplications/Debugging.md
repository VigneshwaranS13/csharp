##Debugging mode



## Breakpoint

The execution will stop at the breakpoint

## Edge cases/uncommon scnarios

- defensive programming

     when we get any input before processing that input we want to make sure
it will satisfy certain criteria,else we are not gonna continut processing

- Side effect

Instead of directly processing the input we can make copy of the input and
we can start processing


## Call stack

- will show how we got to the current method

debug -> windows -> callstack

- this window will show the method that we were called from the moment of the
application start up to where we are now

- item on top of list is your current location
- bottom is where we started
- intermediate are the mehods in between from top to bottom


##  autos and locals

- watch window is useful but we have to type manually

1 autos

`debug -> windows -> Autos`

- this window is like a watch but with automatic list of variables

2 Locals

`debug -> windows -> Locals`

- this window is like a autos but will not list all variables
- it will show the variables in the local scope
		 