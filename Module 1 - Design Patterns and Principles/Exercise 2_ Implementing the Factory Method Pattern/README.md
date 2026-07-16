# Factory Method Pattern Example

## Exercise 2: Implementing the Factory Method Pattern

### Objective
To implement the Factory Method Design Pattern in Java for creating different types of documents such as Word, PDF, and Excel documents.

---

## Scenario

A document management system needs to create different types of documents dynamically. The Factory Method Pattern provides a way to create objects without specifying their exact classes, making the system flexible and easy to extend.

---

## Steps Performed

1. Created a Java project named **FactoryMethodPatternExample**.
2. Created a package named **factory**.
3. Defined a common document interface for all document types.
4. Created concrete document classes:
   - Word Document
   - PDF Document
   - Excel Document
5. Created an abstract factory class named **DocumentFactory**.
6. Implemented concrete factory classes for each document type.
7. Created a test class to demonstrate document creation using factory methods.
8. Executed the application and verified the creation of different document types.

---

## Project Structure

```text
FactoryMethodPatternExample
│
└── src
    │
    └── factory
        ├── Document.java
        ├── WordDocument.java
        ├── PdfDocument.java
        ├── ExcelDocument.java
        ├── DocumentFactory.java
        ├── WordFactory.java
        ├── PdfFactory.java
        ├── ExcelFactory.java
        └── FactoryMethodTest.java
```

---

## Screenshots

### Project Structure

![Project Structure](https://github.com/user-attachments/assets/4643afd7-4f0d-4c43-bfd8-7556a57f4112)

### Program Output

![Program Output](https://github.com/user-attachments/assets/893a8046-fe90-4916-ac74-34feac58806b)

---

## Observation

The Factory Method Pattern successfully separates object creation from object usage. Different document types are created through their respective factory classes without directly instantiating the document objects.

---

## Result

The Factory Method Design Pattern was successfully implemented. Different document types were created using factory classes, demonstrating flexibility, scalability, and adherence to object-oriented design principles.
