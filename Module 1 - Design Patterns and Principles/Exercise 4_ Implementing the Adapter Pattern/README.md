# Adapter Pattern Example

## Exercise 4: Implementing the Adapter Pattern

### Objective

To implement the Adapter Design Pattern in Java for integrating multiple third-party payment gateways with different interfaces into a unified payment processing system.

---

## Scenario

A payment processing system must support multiple payment gateways, each having its own interface and method names. The Adapter Pattern is used to provide a common interface for processing payments regardless of the underlying gateway implementation.

---

## Steps Performed

1. Created a Java project named **AdapterPatternExample**.
2. Created a package named **adapter**.
3. Defined the target interface **PaymentProcessor**.
4. Implemented third-party payment gateway classes.
5. Created adapter classes for each payment gateway.
6. Mapped gateway-specific methods to the common interface.
7. Created a test class to demonstrate payment processing through different gateways.
8. Executed the application and verified the output.

---

## Project Structure

```text
AdapterPatternExample
│
└── src
    │
    └── adapter
        ├── PaymentProcessor.java
        ├── PayPalGateway.java
        ├── StripeGateway.java
        ├── PayPalAdapter.java
        ├── StripeAdapter.java
        └── AdapterPatternTest.java
```

---

## Screenshots
### Project Structure

![Project Structure](https://github.com/user-attachments/assets/d5c12b26-6618-4e61-8c0f-df65de0b3b54)

### Program Output

![Program Output](https://github.com/user-attachments/assets/af881f8a-39cd-419e-bdbf-7fa63bf10290)

---

## Observation

The Adapter Pattern enables classes with incompatible interfaces to work together. The payment gateways are integrated through adapter classes that translate requests from the common PaymentProcessor interface to gateway-specific methods.

---

## Result

The Adapter Design Pattern was successfully implemented. Different payment gateways were accessed through a common interface, improving flexibility and maintainability of the payment processing system.
