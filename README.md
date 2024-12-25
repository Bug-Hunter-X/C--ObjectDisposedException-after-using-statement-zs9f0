# C# ObjectDisposedException Example

This repository demonstrates a common error in C#: accessing a disposed object. Specifically, it shows how attempting to use a database context after it has been disposed of (via a `using` statement) results in an `ObjectDisposedException`. 

The `bug.cs` file contains the problematic code. The `bugSolution.cs` file shows how to fix the issue.

## Bug

The main issue lies within the `MyMethod()` function. The database context (`context`) is correctly disposed of using a `using` statement. However, after the `using` block, the code tries to access the same context again. Since the context has been disposed of, this results in an `ObjectDisposedException`. 

## Solution

The solution involves ensuring that any access to the database context happens within the scope of the `using` statement.  In the corrected code, all database operations occur within the `using` block preventing the error.