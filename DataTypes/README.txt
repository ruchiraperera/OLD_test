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

//---------------------------------

what is the difference in delegates and events ? 

	* Delegate in C# is a reference type, which holds a reference to the function and invokes the function when called with an Invoke method. If one is coming from C++/C background, delegate is like a pointer to a function. 
	* Event in C# is a type of Delegate, which means that if one wants to use Event, then one must define delegate first. Events can have multiple event-handler functions, which have a signature like Delegate, and get called when an Event is raised by some other Event in an application.


	Deletegate can be overrided easily and event wrap the code of delegate so it can't be override easily. 


	------------------delegate override ------------------
	class Program {       

    static void Main(string[] args)     {         

      Program p = new Program();         

      DelegateTest delegateTest = new DelegateTest();         

      delegateTest.p = new DelegateTest.Print(p.TestString);        

      delegateTest.p = null;     }       

    public void TestString(string s)    

    {     }

    }

	------------------delegate override ------------------


	------------------ event prevent override delegate type -------------

	static void Main(string[] args)         

	{             

	  Program p = new Program();            

	  EventTest eventTest = new EventTest();             

	  //eventTest.PrintEvent = null;

	  //Not allowed in C#             

	  eventTest.PrintEvent += p.TestString;         

	  }          

	public void TestString(string s)         

	{         }




