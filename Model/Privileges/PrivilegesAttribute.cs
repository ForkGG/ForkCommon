﻿using System;

namespace ProjectAveryCommon.Model.Privileges;

/// <summary>
/// Specifies that the class or method that this attribute is applied to requires the specified privilege.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class PrivilegesAttribute : Attribute
{
    public Type Privilege { get; }

    public PrivilegesAttribute(Type privilegeType)
    {
        if (!typeof(IPrivilege).IsAssignableFrom(privilegeType))
        {
            throw new ArgumentException("Privileges attribute can only be used with types of IPrivilege");
        }
        Privilege = privilegeType;
    }
}