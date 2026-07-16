# Builder Pattern Example

## Exercise 3: Implementing the Builder Pattern

### Objective

To implement the Builder Design Pattern in Java for constructing complex objects with multiple optional attributes in a flexible and readable manner.

---

## Scenario

A system is required to create different configurations of a Computer object with attributes such as CPU, RAM, Storage, and GPU. The Builder Pattern is used to simplify the object creation process and improve code readability.

---

## Steps Performed

1. Created a Java project named **BuilderPatternExample**.
2. Created a package named **builder**.
3. Defined a product class named **Computer**.
4. Added attributes such as CPU, RAM, Storage, and GPU.
5. Implemented a static nested **Builder** class inside the Computer class.
6. Added methods in the Builder class to set individual attributes.
7. Implemented the **build()** method to create a Computer object.
8. Created a test class to demonstrate different Computer configurations.
9. Executed the application and verified the output.

---

## Project Structure

```text
BuilderPatternExample
│
└── src
    │
    └── builder
        ├── Computer.java
        └── BuilderPatternTest.java
```

---

## Screenshots

### Project Structure

![Project Structure](https://github.com/user-attachments/assets/01de1630-bb90-432c-9d4d-43ffbc555b77)

### Program Output

![Program Output](https://github.com/user-attachments/assets/8785c6db-ab3e-4e8e-a49b-69940ef76ad7)

---

## Observation

The Builder Pattern separates the construction of a complex object from its representation. It allows the creation of different configurations of a Computer object using a step-by-step approach while keeping the code clean and maintainable.

---

## Result

The Builder Design Pattern was successfully implemented. Different Computer configurations were created using the Builder class, demonstrating flexibility, readability, and ease of object construction.
