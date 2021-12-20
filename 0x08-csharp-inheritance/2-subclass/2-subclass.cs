using System;
/// <summary>
/// return True if the object is an instance of a class that inherits from the specified class
///  otherwise return false
/// </summary>
class Obj
{
    /// <summary>
    /// return True if the object is an instance of a class that inherits from the specified class
    ///  otherwise return false
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return (derivedType.IsSubclassOf(baseType));
    }
}
