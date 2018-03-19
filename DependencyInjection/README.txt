Dependency Injection - is a form of inversion control

Dependancy injection types - 

	- construct injections
	- property injections
	- method injections

examle for inversion control

mylist.add(42); - original code 
42.addList(mylist); - inversion control code

Dependency injection example - car _car = new car(new engine());

describe this example - car needs engine to run, so car is depend on engine.

//-----------------------------------------------------------------------------------

Why dependency injection is?

reusable code
encapsulation
code maintainable
control all objects in one centralise place

Dependency Injection Frameworks - 

	- castle windsor
	- structure map
	- unity
	- autofac - this is the main framework use in currently. 



*** composition / agregation / Association

- Composition - 

public class Customer{
	readonly logger Logger;
	public Customer (logger _logger){
		Logger = _logger;
	}
}
