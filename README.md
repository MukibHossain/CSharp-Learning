# C# Learning

A personal collection of C# concepts, code examples, and notes — built while learning the language from the ground up. This repo will keep growing as I learn more topics.

## 📚 Topics Covered

| # | Topic | Description |
|---|-------|-------------|
| 1 | [Compile Time & Run Time](#compile-time--run-time) | Difference between compile-time and run-time behavior/errors |
| 2 | [Enumeration (Enum)](#enumeration-enum) | Defining and using enums |
| 3 | [Access Modifiers](#access-modifiers) | public, private, protected, internal, etc. |
| 4 | [Methods](#methods) | Method declaration, parameters, overloading |
| 5 | [Constructors](#constructors) | Default, parameterized, and copy constructors |
| 6 | [Properties](#properties) | Get/set, auto-implemented properties |
| 7 | [Inheritance](#inheritance) | Base and derived classes |
| 8 | [Abstraction](#abstraction) | Abstract classes and methods |
| 9 | [Polymorphism](#polymorphism) | Method overriding and overloading |
| 10 | [Exception Handling](#exception-handling) | try, catch, finally, custom exceptions |
| 11 | [Delegates](#delegates) | Delegate types, multicast delegates, events |

> More topics will be added here as the repo grows (e.g., interfaces, generics, LINQ, collections, async/await).

---

## 🗂️ Repository Structure

```
CSharp-Learning/
│
├── 01-CompileTime-RunTime/
├── 02-Enumeration/
├── 03-AccessModifiers/
├── 04-Methods/
├── 05-Constructors/
├── 06-Properties/
├── 07-Inheritance/
├── 08-Abstraction/
├── 09-Polymorphism/
├── 10-ExceptionHandling/
├── 11-Delegates/
│
└── README.md

```

Each folder contains one or more `.cs` files demonstrating that concept, with comments explaining the logic.

---

## 📖 Topic Notes

### Compile Time & Run Time
- **Compile-time**: Errors and checks that happen while the code is being compiled (e.g., syntax errors, type mismatches).
- **Run-time**: Errors and behavior that occur while the program is executing (e.g., `NullReferenceException`, `DivideByZeroException`).

### Enumeration (Enum)
A value type used to define a set of named constants, making code more readable than using raw numbers or strings.

### Access Modifiers
Keywords that define the visibility/accessibility of classes, methods, and members:
- `public`, `private`, `protected`, `internal`, `protected internal`, `private protected`

### Methods
Blocks of code that perform a specific task. Covers method signatures, parameters (value, ref, out, params), and method overloading.

### Constructors
Special methods used to initialize objects. Includes default constructors, parameterized constructors, and constructor overloading.

### Properties
Members that provide a flexible mechanism to read, write, or compute the value of a private field, using `get` and `set` accessors.

### Inheritance
Mechanism where a class (derived/child) acquires properties and behavior from another class (base/parent) using `:`.

### Abstraction
Hiding implementation details and exposing only essential features, using `abstract` classes and methods.

### Polymorphism
The ability of objects to take many forms:
- **Compile-time (Static)**: Method overloading
- **Run-time (Dynamic)**: Method overriding using `virtual` and `override`

### Exception Handling
Handling run-time errors gracefully using `try`, `catch`, `finally`, and creating custom exception classes.

### Delegates
Type-safe function pointers used to pass methods as arguments, and as the foundation for events in C#.

---

## 🚀 How to Run

1. Clone the repo:
   ```bash
   git clone https://github.com/<your-username>/CSharp-Learning.git
   ```
2. Open any folder in Visual Studio / VS Code / Rider.
3. Run the `.cs` file using:
   ```bash
   dotnet run
   ```

---

## 🎯 Purpose

This repository is for personal learning and revision purposes — a place to keep clean, working examples of core C# concepts that I can refer back to anytime.

---

## 📌 Status

🟢 Actively updated — new topics and examples will be added over time.
