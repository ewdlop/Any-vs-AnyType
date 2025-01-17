class Program
{
    static void Main()
    {
        // Declare a dynamic variable
        dynamic dynamicObject = new System.Dynamic.ExpandoObject();

        // Add properties dynamically
        dynamicObject.Name = "John Doe";
        dynamicObject.Age = 30;
        dynamicObject.SayHello = new Action(() =>
        {
            Console.WriteLine($"Hello, my name is {dynamicObject.Name} and I am {dynamicObject.Age} years old.");
        });

        // Access and invoke dynamically added properties
        Console.WriteLine(dynamicObject.Name); // Outputs: John Doe
        Console.WriteLine(dynamicObject.Age);  // Outputs: 30
        dynamicObject.SayHello();              // Outputs: Hello, my name is John Doe and I am 30 years old.

        // Change properties at runtime
        dynamicObject.Name = "Jane Smith";
        dynamicObject.Age = 25;
        dynamicObject.SayHello();              // Outputs: Hello, my name is Jane Smith and I am 25 years old.

        // Add new properties or methods at runtime
        dynamicObject.Greet = new Func<string, string>((greeting) =>
        {
            return $"{greeting}, {dynamicObject.Name}!";
        });

        Console.WriteLine(dynamicObject.Greet("Hi")); // Outputs: Hi, Jane Smith!
    }
}
