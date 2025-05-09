# mediator
Mediator Pattern implemented with .NET ecosystem.

# ❓ How to use
- Clone the repo on your machine;
- Copy the two projects inside Mediator solution to your solution or project folder;
- Connect your project with Mediator.Abstractions and Mediator.Package via project reference tool;
- Enjoy! 😄


# ℹ️ About Mediator Design Pattern
The Mediator pattern is a behavioral design pattern that reduces coupling between components by making them communicate indirectly through a mediator object instead of directly with each other.

## When to Use
1. Complex communication flows: When you have numerous components that need to interact in complex ways
2. Reducing dependencies: When you want to decouple a system with many interdependent classes
3. Reusable components: When components need to be reusable across different contexts without tight coupling
4. Centralized control: When you need a central point to manage communication rules and business logic
5. CQRS architectures: In Command Query Responsibility Segregation patterns, mediator often handles dispatching commands and queries

