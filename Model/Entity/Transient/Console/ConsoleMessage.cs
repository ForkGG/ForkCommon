using ProjectAveryCommon.Model.Entity.Enums.Console;
using ProjectAveryCommon.Model.Entity.Pocos;

namespace ProjectAveryCommon.Model.Entity.Transient.Console;

public class ConsoleMessage
{
    public string Message { get; }
    public ConsoleMessageType MessageType { get; }

    public ConsoleMessage(string message, ConsoleMessageType type)
    {
        Message = message;
        MessageType = type;
    }
}