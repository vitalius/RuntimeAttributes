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
         * Returns value of the 'Special' attribute of the local Text variable
         */
        public int getAttribute() {
            var textVar = TypeDescriptor.GetProperties(this.GetType())["Text"];
            var attr = (SpecialAttribute)textVar.Attributes[typeof(SpecialAttribute)];
            return attr.Index;
        }

        /*
         * Changes value of the 'Special' attribute of the local Text variable
         */
        public void setSpecialAttribute(int index)
        {
            var textVar = TypeDescriptor.GetProperties(this.GetType())["Text"];
            var attr = (SpecialAttribute)textVar.Attributes[typeof(SpecialAttribute)];
            var attProp = typeof(SpecialAttribute).GetProperty("Index");
            attProp.SetValue(attr, index, null);
        }
    }
}
