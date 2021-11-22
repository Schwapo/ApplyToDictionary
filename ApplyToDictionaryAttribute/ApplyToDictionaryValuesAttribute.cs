using System;
using System.Diagnostics;

[Conditional("UNITY_EDITOR")]
[AttributeUsage(AttributeTargets.Class)]
public class ApplyToDictionaryValuesAttribute : Attribute { }