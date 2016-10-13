using System;
using UIOMatic.Enums;

namespace UIOMatic.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class UIOMaticListViewRowCssAttribute : Attribute
    {
        /// <summary>
        /// Javascript function that could return CSS class depending on any predicate.
        /// </summary>
        /// <example>
        /// function (row) { return row.columnX ? 'classA' : 'classB'; }
        /// </example>
        public string Decorator { get; set; }

        public bool IsValid()
        {
            return Decorator != null && Decorator.StartsWith("function") && Decorator.EndsWith("}");
        }   
    }
}