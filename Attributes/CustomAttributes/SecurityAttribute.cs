using System;

namespace Attributes.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Method)]
    class SecurityAttribute : Attribute
    {
        public int Role { get; set; }
        public bool Secure { get; set; }
    }
}
