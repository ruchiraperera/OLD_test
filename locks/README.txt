lock ensure one thread access instance or object at a given time.


lock types - 


lock
interlock - system.Threading.Interlock;
spinlock - 
mutex - very powerfull waithandler with hold multiple mutex locks



****Synchronization Events and Wait Handles ***********************

-AutoResetEvent
-ManualResetEvent

 static AutoResetEvent autoEvent;  

There are two kinds of synchronization events: AutoResetEvent, and ManualResetEvent. They differ only in that 
AutoResetEvent changes from signaled to unsignaled automatically any time it activates a thread. Conversely, 
a ManualResetEvent allows any number of threads to be activated by its signaled state, and will only revert 
to an unsignaled state when its Reset method is called. 