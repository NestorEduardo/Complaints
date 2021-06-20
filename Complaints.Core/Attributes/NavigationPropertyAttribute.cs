using System;

namespace Complaints.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public class NavigationPropertyAttribute : Attribute
    {
        public NavigationPropertyAttribute() { }
    }
}
