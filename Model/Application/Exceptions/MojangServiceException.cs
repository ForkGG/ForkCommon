namespace ProjectAveryCommon.Model.Application.Exceptions;

/// <summary>
/// Thrown when the Mojang API returns an error
/// </summary>
public class MojangServiceException : ForkException
{
    public MojangServiceException(){}
    public MojangServiceException(string message) : base(message){}
}