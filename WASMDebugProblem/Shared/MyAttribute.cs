using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASMDebugProblem.Shared
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class MyAttribute : Attribute
    {
        readonly string positionalString;
        public MyAttribute(string positionalString)
        {
            this.positionalString = positionalString;
        }
        public MyAttribute(MyEnum myEnum)
        {
            this.positionalString = Enum.GetName(myEnum);
        }
        public string PositionalString
        {
            get { return positionalString; }
        }
    }
    public enum MyEnum
    {
        One, Two, Three
    }
}
