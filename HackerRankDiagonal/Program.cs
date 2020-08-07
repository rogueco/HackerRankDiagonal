using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the miniMaxSum function below.
    static void miniMaxSum(Int64[] arr) {
        Int64 lowest = arr.OrderBy(x => x).Take(4).Sum();
        Int64 highest = arr.OrderBy(x => x).Skip(1).Sum();

          Console.WriteLine($"{lowest} {highest}");
    }

    static void Main(string[] args) {
        Int64[] arr = new Int64[] {254961783, 604179258, 462517083, 967304281, 860273491 };

        miniMaxSum(arr);
    }
}
