delegate - acting as functional pointers
it helps to add methods existing process without changing the existing code.

advantage - using for extensibility and flexibilty


C# provide defualt to delegate methods 

 - system.action, system.action<T>
 - system.Func<T>
 - predicate

 A predicate delegate methods must take one input parameter and it then returns a boolean value - true or false. 
 public delegate bool Predicate<in T>(T obj);

 interface or delegate (it depends on developer but..)

  - if there is even based design pattern the it better to use delegates
  - if developer doesnt want to access there properties or method then better to use delegates.