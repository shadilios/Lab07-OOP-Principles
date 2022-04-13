# OOP-Pinciples-Lab

### Description

This project represent an animal class that inherits to mulitple subclasses that form main groups of animals & those too inherit to other subclasses that inherit to classes that hold the animals themselves.  

<br><hr><br>

### Diagram to navigate the project
![img](https://user-images.githubusercontent.com/70282602/161405322-282cd78f-e81e-497a-98f2-ac7eac6a0a79.png)

### Interface definition

An interface is a class that we can't define functionality in, and we inherit it to classes we want to force them to inherit from.

### My Interfaces

My interfaces are ICanRun, ICanFly, ICanSwim.  
I inherit those Interfaces to classes I know that will use this functionality as a main method of moving.
Exmaple: I inherit the ICanSwim interface to each Shark, Dolphin, because I know they will swim and it will let me print their Swimming speed.
