using System;

namespace UIOMatic.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class UIOMaticSaveOptionsAttribute: Attribute
    {
       public int RetryCount { get; set; }
    }
}