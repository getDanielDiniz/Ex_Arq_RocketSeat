using Ger_Tarefas.Comunication.Requests;
using Ger_Tarefas.Comunication.Types;

namespace Ger_Tarefas.Comunication.Responses;
public class ResponseTarefaJSON
{
    public Guid Id { get; set; }
    public string Name { get; set; } 
    public string Description { get; set; }
    public PriorityType Priority { get; set; }
    public StatusType Status { get; set; } 
    public DateOnly DeadLine { get; set; } 

    public ResponseTarefaJSON()
    {
        //Construtor vazio necessário
    }

    public ResponseTarefaJSON(Guid id, RequestTarefaJSON model)
    {
        Id = id;
        Name = model.Name;
        Description = model.Description;
        Priority = model.Priority;
        Status = model.Status;
        DeadLine = model.DeadLine;
    }

    public ResponseTarefaJSON(RequestTarefaJSON model)
    {
        Id = Guid.NewGuid();
        Name = model.Name;
        Description = model.Description;
        Priority = model.Priority;
        Status = model.Status;
        DeadLine = model.DeadLine;
    }
}
