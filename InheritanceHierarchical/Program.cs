using InheritanceHierarchical;

public class Hierarchical
{
    public static void Main()
    {
        ChildClass2 obj = new ChildClass2();
        Console.WriteLine("User name is "+obj.ReadUserName());
        obj.WriteName("My name is jenisha chlm");
        obj.Type3();
        obj.Type1();
        ChildClass1 obj2 = new ChildClass1();
        obj2.Type2();
        obj2.Type1();
        
        
    }
}
