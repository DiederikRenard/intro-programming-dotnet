# Intro Programming .NET

A basic C# learning project covering core programming concepts through hands-on exercises.

This is the C# counterpart of [intro-programming-python](https://github.com/blitz-exercises/intro-programming-python). Each exercise is a stub that throws `NotImplementedException`. Replace the stub so the matching test passes.

## Prerequisites

- .NET 8 SDK

## How to check your work

From the project root:

```bash
dotnet test
```

Green means that exercise is correct. A failing test means it is not done yet, or the return value does not match the contract in the summary comment.

Run one area or one test:

```bash
dotnet test --filter ConditionalsTests
dotnet test --filter FullyQualifiedName~FunctionsTests.Exercise03_Square
```

## Topics

| Folder | Topics |
| --- | --- |
| `VariablesAndDataTypes` | `int`, `double`, `string`, `bool`, conversion, `null` |
| `Operators` | arithmetic, comparison, logical, assignment, membership |
| `Conditionals` | `if` / `else if` / `else`, nested conditions, `? :` |
| `Loops` | `for`, `foreach`, `while`, `break`, `continue`, index |
| `Functions` | methods, parameters, `return`, optional arguments, scope |
| `Collections` | `List`, `Dictionary`, tuples, `HashSet` |
| `Exceptions` | `try` / `catch`, specific exceptions, `throw`, `finally` |
| `ClassesAndObjects` | class, constructor, methods, instances |

## Build in Docker

The solution can be compiled without a local .NET SDK:

```bash
docker build -t intro-programming-dotnet .
```

That restores packages, builds the solution, and lists the tests. It does not require the exercises to be solved.
