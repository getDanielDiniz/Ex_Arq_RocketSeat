using Ger_Tarefas.Comunication.Types;

namespace Ger_Tarefas.Comunication.Requests;
public class RequestTarefaJSON
{
    public string Name {  get; set; } = string.Empty;
    public string Description {  get; set; } = string.Empty;
    public PriorityType Priority { get; set; }
    public StatusType Status { get; set; }
    public DateOnly DeadLine { get; set; }


}
