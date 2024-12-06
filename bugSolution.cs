public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Initialize with default value
    }

    public void MyMethod()
    {
        // Accessing the property after initialization
        int value = MyProperty; 
    }
}