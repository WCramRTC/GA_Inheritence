## What is Inheritance

"Inheritance is the coding concept of reusing code by creating a series of classes that inherit properties and methods from one another. By creating a general class with functionality shared across multiple classes, and having classes inherit from that class, they now have access to the same functionality and can be cleanly updated and organized in one class, rather than across multiple."







1. **Reuse Code**: It lets us use existing code in new parts of our program, saving time and effort.

2. **Organize Code**: It helps us structure our code in a neat way, making it easier to understand.

3. **Updates**: When we need to change something, we can do it in one place (the original code), and those changes apply to all related code.

4. **Flexibility**: It allows us to work with different things in a similar way, making our code more flexible.

5. **Specialize**: We can take common code and add specific details to create different versions of something.

6. **Simplify Complexity**: It helps us make complex systems easier to understand by showing how things are connected.



In C#, inheritance is a fundamental object-oriented programming concept that allows you to create a new class (derived or child class) based on an existing class (base or parent class). Here are the key components and concepts related to inheritance in C#:

1. **Base Class (Parent Class)**:
   - The base class is the existing class from which you want to inherit properties and methods.
   - It is also known as the parent class or superclass.

2. **Derived Class (Child Class)**:
   - The derived class is the new class that you create to inherit properties and methods from the base class.
   - It is also known as the child class or subclass.

3. **Inheritance Syntax**:
   - In C#, you use the `:` symbol to denote inheritance. For example:
     ```csharp
     class ChildClass : ParentClass
     {
         // Child class members
     }
     ```

4. **Access Modifiers**:
   - Inherited members (fields, properties, methods) can have different access modifiers in the child class.
   - You can use `public`, `protected`, `internal`, or `private` access modifiers to control visibility and access.

7. **Constructor Inheritance**:
   - Constructors are not inherited by default, but you can explicitly call the base class constructor using the `base` keyword in the constructor of the child class.

8. **Method Hiding**:
   - If you define a method in the child class with the same name as a method in the base class, you are hiding the base class method.
   - You can use the `new` keyword to explicitly hide a base class method.

9. **Multiple Inheritance**:
   - C# supports single inheritance, meaning a class can inherit from only one base class.
   - However, a class can implement multiple interfaces, allowing it to inherit multiple sets of method signatures.

12. **Polymorphism**:
    - Inheritance allows you to achieve polymorphism, where you can use a reference to the base class to refer to objects of the derived class.
    - This promotes code reusability and flexibility.


```csharp

	public class Character {
	
		public string Name { get; set; }
		public int HP { get; set;}
		public GameController Movement { get; set; }
		public AIBehavior Behavior { get ; set; }

		public class Character(string name, int hp, GameController movement, AIBehavior behavior ) {

			Name = name;
			HP = hp;
			Movement = movement;
			Behavior = behavior;
		}

		public void Attack() {
			// Code to swing sword
			Console.WriteLine("Swinging The Sword");
		}

		public void AttackPlayer() {
			// Attack player character
			Console.WriteLine("Attacking the Player");
		}

		public void SellingMerchandise() {
			Console.WriteLine("Displaying Wares");
		}
	
	}

```


```csharp

class Transportation
{
    // Properties
    public string Type { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberOfWheels { get; set; }

    // Constructor
    public Transportation(string type, string model, int year, int numberOfWheels )
    {
        Type = type;
        Model = model;
        Year = year;
    }

    // Method to Start
    public void Start()
    {
        Console.WriteLine($"Starting the {Year} {Type} {Model}.");
    }

    // Method to Stop
    public void Stop()
    {
        Console.WriteLine($"Stopping the {Year} {Type} {Model}.");
    }
}

class Program
{
    static void Main()
    {
        // Create a Transportation object
        Transportation myVehicle = new Transportation("Car", "Sedan", 2022);

        // Access properties and methods of the Transportation class
        Console.WriteLine($"Type: {myVehicle.Type}");
        Console.WriteLine($"Model: {myVehicle.Model}");
        Console.WriteLine($"Year: {myVehicle.Year}");

        myVehicle.Start();
        myVehicle.Stop();
    }
}

```