using System;
using UIOMatic.Enums;

namespace UIOMatic.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class UIOMaticListViewCellContentAttribute : Attribute
    {
        /// <summary>
        /// Javascript function that could return custom Html markup depending on any predicate.
        /// </summary>
        /// <example>
        /// function (row, column) { return column == columnX && row[column] == 'true' ? '<span class="icon icon-check color-green"></span>' : '<span class="icon icon-block color-red"></span>'; }
        /// </example>
        public string Decorator { get; set; }

        public bool IsValid()
        {
            return Decorator != null && Decorator.StartsWith("function") && Decorator.EndsWith("}");
        }   
    }
}