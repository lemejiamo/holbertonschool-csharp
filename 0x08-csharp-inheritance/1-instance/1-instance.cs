using System;
/// <summary>
/// static method to veryfy if object is type of 'Array'
/// </summary>
class Obj
{
    /// <summary>
    /// static method to veryfy if object is type of 'Array'
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        Console.WriteLine("{0}", Type.GetTypeArray(obj));
        if(typeof(Array).IsInstanceOfType(obj))
            return true;
        return false;
    }
}

