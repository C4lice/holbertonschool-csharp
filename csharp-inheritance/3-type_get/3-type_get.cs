using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo typeInfo = myObj.GetType().GetTypeInfo();

        Console.WriteLine("Properties:");
        foreach (PropertyInfo property in typeInfo.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine("Methods:");
        foreach (MethodInfo method in typeInfo.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
