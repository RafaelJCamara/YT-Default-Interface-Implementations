public interface IInterface
{
    private static int a = 5;

    void MethodA();
    void MethodB()
    {
        Console.WriteLine($"Default implementation of MethodB in Interface. Value of a: {a}");
        PrivateMethod();
    }

    private static void PrivateMethod()
    {
        Console.WriteLine("This is a private method in the interface.");
    }
}

public class ClassA : IInterface
{
    public void MethodA()
    {
        throw new NotImplementedException();
    }

    //public void MethodB()
    //{
    //    Console.WriteLine("ClassA's implementation of MethodB.");
    //}
}

public class Program
{
    public static void Main(string[] args)
    {
        IInterface instance = new ClassA();
        instance.MethodB();
    }
}