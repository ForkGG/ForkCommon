using System;
using ProjectAvery.Logic.Model.Enums;

namespace ProjectAvery.Logic.Model;

/// <summary>
/// Specifies that the class or method that this attribute is applied to requires the specified privilege.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class PrivilegesAttribute : Attribute
{
    public Privilege Privilege { get; }

    public PrivilegesAttribute(Privilege privilege)
    {
        Privilege = privilege;
    }
}