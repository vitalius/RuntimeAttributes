/*
 * Simple custom attribute
 */
using System;

namespace CustomAttribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SpecialAttribute : Attribute
    {
        public int Index { get; set; }

        public SpecialAttribute()
        {
        }
    }
}
