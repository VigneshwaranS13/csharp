## Byte code

- The compiler will compile the code into byte code which is platform independent

## CLR

- Used to convert byte code into native code (like a just-in-time compiler)
- This native code is platform dependent

## Architecuture

- Application conisist of building blocks called class
- classed collabrates with each other during runtime which will
give some functinalities

## class

- class in a container which have some data/attributes and functions/methods
- data represnts state of the application
- fucntions/methods have behaviour which will do things
- as our appications grows we will have more no of classes,in order to manage classes
we have Namespaces


## Namespace

- Its a container for related classes
- we have namespaces for working with database,security
- when namespacing grows we need different ways of 
partioning application
- That's wher `Assembly` comes into the picture

## Assembly (DLL or EXE)

- An assembly is a container for related namespaces
- Physically its file under disk which either can be executable(exe)
or dll(dynamic-link library)

- when we compile application the comiper will build one or more
assembly depending on how we partion our code

