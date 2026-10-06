using MyFirstApp;
Console.WriteLine("Welcome to the Calculator App!");
Calculator calculator = new Calculator();
calculator.SayHello("User");
int result = calculator.Add(5, 3);
Console.WriteLine($"The result of adding 5 and 3 is: {result}");
