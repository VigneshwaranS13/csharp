## System.IO 

All classes related to file are located in this namespace.Few usefull classes are

- File,FileInfo
- Directory,DirectoryInfo
- Path


### File,FileInfo

- Provide methods for creatin,copying,deleting,moving and opening of files

##### Differnces ;

- `FileInfo` : provides instance methods
- `File` : provides static methods


if  we need only few opertions then we can use File class, else we 
can use FileInfo class because whenever we calling this classes some 
security cheking done from os side,which will affect out performance
of our application if we call File class frequntly.

`Methods:`

- Create()
- Copy()
- Delete()
- Exists()
- GetAttributes()
- Move()
- ReadAllText()


### Directory,DirectoryInfo

- `Directory` : provides static methods
- `DirectoryInfo` :provides instance methods


`Methods:`

- CreateDirectory()
- Delete()
- Exists()
- GetCurrentDirectory()
- GetFiles()
- Move()
- GetLogicalDrives()


## Path class

It provides methods that work with the string that contains File or directory path 
information


- GetDirectoryName()
- GetFileName()
- GetExtension()
- GetTempPath()







