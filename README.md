# Uninitialized Property Access in C# 

This repository demonstrates a common error in C#: accessing a property of a class before it has been assigned a value.  Uninitialized properties can lead to unexpected behavior or exceptions, particularly in multithreaded environments. The `bug.cs` file shows the error, while `bugSolution.cs` provides a solution. 

**Problem:**
In the `MyMethod` function of `ExampleClass`, the `MyProperty` is accessed without first assigning it a value. This will result in the value being 0 (the default value for an `int`), which might not be the expected behaviour. 

**Solution:**
The solution lies in initializing the property during class instantiation in the constructor, or explicitly assigning a value before accessing it.