using System;
/// <summary>
/// static method to veryfy if object is type of 'Array'
/// otherwise return false
/// </summary>
class Obj
{
    /// <summary>
    /// static method to veryfy if object is type of 'Array'
    /// otherwise return false
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if(typeof(Array).IsInstanceOfType(obj))
            return true;
        return false;
    }
}

