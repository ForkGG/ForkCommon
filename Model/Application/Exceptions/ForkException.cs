using System;

namespace ProjectAveryCommon.Model.Application.Exceptions;

public class ForkException : Exception
{

    public ForkException()
    {
    }
    public ForkException(string message) : base(message)
    {
    }
}