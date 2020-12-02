﻿using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();
        
        if (myDict == null)
            return null;

        foreach (var key in myDict.Keys)
            newDict[key] = myDict[key] * 2;

        return newDict;
    }
}
