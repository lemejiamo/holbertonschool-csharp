using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// prints the names of the available properties and methods of an object
/// </summary>
class Obj
{
    /// <summary>
    /// prints the names of the available properties and methods of an object
    /// </summary>
    public static void Print(object myObj)
    {
        TypeInfo typeInfo = myObj.GetType().GetTypeInfo();
		Console.WriteLine("{0} Properties:", typeInfo.Name);
		foreach (PropertyInfo _property in typeInfo.GetProperties())
		{
			Console.WriteLine(_property.Name);
		}

		Console.WriteLine("{0} Methods:", typeInfo.Name);
		foreach (MethodInfo method in typeInfo.GetMethods())
		{
			Console.WriteLine(method.Name);
		}
    }
}
