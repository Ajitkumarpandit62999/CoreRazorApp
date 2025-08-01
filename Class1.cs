namespace CommonUtils
{
    public class Class1
    {
        //reflectio
        //anynomus
        //threading
        // building delegates(func , action , predicate
        MYgenericClass<string> myGenericClass = new MYgenericClass<string>();
        public void MyMethod()
        {
            MYgenericClass<string>.MyMethod("Hello World");
        }
    }
}

public class MYgenericClass<T>
{
    public static void MyMethod(T value)
    {
        // Do something with value
    }
}
