void Exception()
{
    Console.WriteLine("Enter a number to divide by 10");

    int x = Convert.ToInt32(Console.ReadLine());

    try
    {
        //Code that could cause an exception, e.g., opening a file
        double result = x / 10.0 ; //What is x = 0?
        Console.WriteLine(result);

    }
    catch (DivideByZeroException ex)
    {
        //Handle the exception, e.g., display an error message
        Console.WriteLine("An error occurred by zero.");
    }
    catch (FileNotFoundException ex)
    {
        //Handle file not found error
        Console.WriteLine($"File not found: {ex.FileName}");
    }
    finally
    {
        //This code always runs, exception or not
        Console.WriteLine("Cleanup complete.");
    }
}

Exception();

