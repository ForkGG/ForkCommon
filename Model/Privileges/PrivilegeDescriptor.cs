namespace ProjectAveryCommon.Model.Privileges;

public class PrivilegeDescriptor<T> where T : IPrivilege
{
    public T Type { get; set; }
}