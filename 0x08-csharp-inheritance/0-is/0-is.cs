using System;
/// <summary>
/// static method to veryfy if object is type of 'int'
/// </summary>
class Obj
{
    /// <summary>
    /// static method to veryfy if object is type of 'int'
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return true;
        else
            return false;
    }
}

