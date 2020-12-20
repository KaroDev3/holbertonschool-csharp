﻿using System;

/// <summary>
/// This class defines operations for inheritance checking
/// </summary>
class Obj
{
    /// <summary>
    /// method to checks if 'obj' is in the inheritance tree of 'Array'
    /// <param name="obj">object to check</param>
    /// <returns>True if 'obj' is in the inheritance tree of 'Array', otherwise return False</returns>
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;

        return false;
    }
}