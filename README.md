# Intro-To-Mediator-Design-Pattern
In object-oriented programming, programs often consist of many classes.
Business logic and computation are distributed among these classes.
However, as more classes are added to a program, especially during maintenance and/or refactoring, the problem of communication between these classes may become more complex.
This makes the program harder to read and maintain.
Furthermore, it can become difficult to change the program, since any change may affect code in several other classes.

In software engineering, the mediator pattern defines an object that encapsulates how a set of objects interact.
This pattern is considered to be a behavioral pattern due to the way it can alter the program's running behavior.

With the mediator pattern, communication between objects is encapsulated within a mediator object. Objects no longer communicate directly with each other, but instead communicate through the mediator.
This reduces the dependencies between communicating objects, thereby reducing coupling.

<br/>

<p align="center">
  <img src="https://github.com/user-attachments/assets/92037a1b-840a-4d7d-bff7-7cf2043d11bc" width="800">
</p>
