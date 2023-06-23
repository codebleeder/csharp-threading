The Main thread always has the UI

* multithreading is managed internally by a thread scheduler
* .NET CLR delegates scheduling to the OS
* each thread has its own memory stack to store it's local variables

## Sharing resources
* whenever you are sharing resource between thread, you must lock the part of code which is manipulating the shared resource.

## Threads vs processes
* Threads run parallel inside a process
* Threads share heap memory 

* Processes are fully isolated from each other
