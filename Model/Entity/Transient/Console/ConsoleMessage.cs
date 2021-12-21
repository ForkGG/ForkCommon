using ProjectAveryCommon.Model.Entity.Enums.Console;
using ProjectAveryCommon.Model.Entity.Pocos;

namespace ProjectAveryCommon.Model.Entity.Transient.Console;

public class ConsoleMessage
{
    public string Message { get; set; }
    public ConsoleMessageType MessageType { get; set; }

    public ConsoleMessage(string message, ConsoleMessageType type)
    {
        Message = message;
        MessageType = type;
    }

    public ConsoleMessage()
    {
    }
}