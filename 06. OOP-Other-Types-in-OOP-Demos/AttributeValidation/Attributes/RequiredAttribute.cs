namespace AttributeValidation.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class RequiredAttribute : Attribute
    {
    }
}
