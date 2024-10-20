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


1. Components are various classes that contain some business logic. Each component has a reference to a mediator, declared with the type of the mediator interface. The component isn’t aware of the actual class of the mediator, so you can reuse the component in other programs by linking it to a different mediator.

2. The Mediator interface declares methods of communication with components, which usually include just a single notification method. Components may pass any context as arguments of this method, including their own objects, but only in such a way that no coupling occurs between a receiving component and the sender’s class.

3. Concrete Mediators encapsulate relations between various components. Concrete mediators often keep references to all components they manage and sometimes even manage their lifecycle.

4. Components must not be aware of other components. If something important happens within or to a component, it must only notify the mediator. When the mediator receives the notification, it can easily identify the sender, which might be just enough to decide what component should be triggered in return.
From a component’s perspective, it all looks like a total black box. The sender doesn’t know who’ll end up handling its request, and the receiver doesn’t know who sent the request in the first place.

Image and Description source: Dive Into DESIGN PATTERNS by Alexander Shvets <br/>
Link to the book : https://refactoring.guru/design-patterns/book
