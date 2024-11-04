using Ger_Tarefas.Comunication.Responses;

namespace Ger_Tarefas.Application.UseCases.Tarefa.Delete;
public class DeleteTarefa : DefaultUseCase
{

    public static void Execute(Guid id)
    {
        List<ResponseTarefaJSON> list = GetMockedList();

        ResponseTarefaJSON? FoundTarefa = list.Find(tarefa => tarefa.Id == id);

        list.Remove(FoundTarefa);

        OverwriteMockedList(list);
    }
}
