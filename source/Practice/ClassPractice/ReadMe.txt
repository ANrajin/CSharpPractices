Access specifiers specify the access rules for the members as well as the class itself. 
If not mentioned, then the default access specifier for 
	# a class type is internal. 
	# Default access for the members is private.

## Member Functions and Encapsulation
A member function of a class is a function that has its definition or its prototype within the class definition similar to any other variable. 
It operates on any object of the class of which it is a member, and has access to all the members of a class for that object.

Member variables are the attributes of an object (from design perspective) and they are kept private to implement encapsulation. 
These variables can only be accessed using the public member functions.

## You can also declare a member function as static. Such functions can access only static variables.


** public				->	There are no restrictions on accessing public members.

** private				->	Access is limited to within the class definition. This is the default access modifier type if none is formally specified

** protected			->	Access is limited to within the class definition and any class that inherits from the class

** internal				->	Access is limited exclusively to classes defined within the current project assembly

** protected internal	->	Access is limited to the current assembly and types derived from the containing class. 
							All members in current project and all members in derived class can access the variables.   

** private protected	->	Access is limited to the containing class or types derived from the containing class within the current assembly.


****** c# by default class is internal and it member will be private
