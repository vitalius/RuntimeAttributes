/*
 * Simple text class
 */
using System;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using System.Reflection;

namespace CustomAttribute
{
    public class SampleClass
    {
        [Special(Index=55)]
        public string Text { get; set; }

        /*
         * Returns Index value of the 'Special' attribute 
         */
        public int getAttribute() {
            var textVar = TypeDescriptor.GetProperties(this.GetType())["Text"];
            var attr = (SpecialAttribute)textVar.Attributes[typeof(SpecialAttribute)];
            return attr.Index;
        }

        /*
         * Changes Index value of the 'Special' attribute 
         */
        public void setAttribute(int index)
        {
            var textVar = TypeDescriptor.GetProperties(this.GetType())["Text"];
            var attr = (SpecialAttribute)textVar.Attributes[typeof(SpecialAttribute)];
            var attProp = typeof(SpecialAttribute).GetProperty("Index");
            attProp.SetValue(attr, index, null);
        }
    }
}
