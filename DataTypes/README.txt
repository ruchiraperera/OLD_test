There are two types of data type in C#

  1.   primitive types (or) predefined

Ex:  byte, short, int, float, double, long ,char, bool, DateTime, string, object etc..

 2.   non-primitive types (or) User Defined

Ex: class , struct , enum , interface,  delegate, array.

In C#, based on what a variable contains there is two types of built-in data type
Value types

A variable holds actual values then that type of data types are value types. These value types are stored in “stack” memory and these value types are fixed in size. If you assign a value of a variable to another variable it will create two copies.

Ex: byte, short, int, float, double, long ,char, bool, DateTime.

    Primitive data types are value types except string, object.
    Object type is superior to all types. It can store any type or any size of data. It helps in inheritance process.
    Struct, enum are value types.

Reference types

A variable holds a reference to the value, then that type of data types are reference types. These reference types are stored in “heap” memory and these types are not fixed in size.  They are maintained in system managed heap but it also uses stack to store reference of the heap. Two primitive types (string and object) and non-primitive data types (class, interface & delegate) are examples of reference type.

Ex:   class, interface, delegate, string, object and array