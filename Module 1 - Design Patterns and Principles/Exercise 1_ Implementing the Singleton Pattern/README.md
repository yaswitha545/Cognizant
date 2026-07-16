# Singleton Pattern Example

## Exercise 1: Implementing the Singleton Pattern

### Objective
To implement the Singleton Design Pattern in Java and ensure that only one instance of a Logger class exists throughout the application lifecycle.

---

## Scenario
A logging utility class is required in the application to provide consistent logging. The Singleton Design Pattern is used to ensure that only one Logger object is created and shared across the application.

---

## Steps Performed

1. Created a Java project named **SingletonPatternExample**.
2. Created a package named **singleton**.
3. Created the **Logger** class.
4. Implemented the Singleton Design Pattern by:
   - Declaring a private static instance variable.
   - Making the constructor private.
   - Providing a public static method to access the instance.
5. Created the **SingletonTest** class.
6. Tested the implementation by obtaining multiple references to the Logger object.
7. Verified that the same Logger instance was used throughout the application.

---

## Project Structure

```text
SingletonPatternExample
│
└── src
    │
    └── singleton
        ├── Logger.java
        └── SingletonTest.java
```

## Screenshots

## Screenshots

### Project Structure

![Project Structure](https://github.com/user-attachments/assets/0abcc3b4-fa9f-4c7f-82a3-172525bb77c4)

### Program Output

![Program Output](https://github.com/user-attachments/assets/3eb86d68-0d37-4888-bef5-c09d1460a5f8)

## Observation

The Singleton Pattern ensures that only one instance of the Logger class is created. Multiple requests for the Logger object return the same instance, providing a single point of access throughout the application.

---

## Result

The Singleton Design Pattern was successfully implemented and tested. The Logger class maintained a single instance during the application lifecycle, demonstrating the correct use of the Singleton Pattern.
