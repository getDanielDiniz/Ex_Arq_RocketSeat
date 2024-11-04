using Ger_Tarefas.Comunication.Responses;

namespace Ger_Tarefas.Application.UseCases.Tarefa.ReadById;
public class ReadById : DefaultUseCase
{

    public static ResponseTarefaJSON Execute(Guid id)
    {
        List<ResponseTarefaJSON> list = GetMockedList();
        
        ResponseTarefaJSON? FoundTarefa = list.Find(tarefa => tarefa.Id == id);

        return FoundTarefa;
    }
}
