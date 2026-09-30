void Exception()
int x = 0;
Console.WriteLine("Enter a number to divide by 10");

try
{
    //Code that could cause an exception, e.g., opening a file
    int result = 10 / x; //What is x = 0?
}
catch (DivideByZeroException ex)
{
    //Handle the exception, e.g., display an error message
    Console.WriteLine("An error occurred by zero." );
}
catch (FileNotFoundException ex)
{
    //Handle file not found error
    Console.WriteLine($"File not found: {ex.FileName}");
}
