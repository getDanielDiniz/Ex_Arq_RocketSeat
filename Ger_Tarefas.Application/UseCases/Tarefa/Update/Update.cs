using Ger_Tarefas.Comunication.Requests;
using Ger_Tarefas.Comunication.Responses;

namespace Ger_Tarefas.Application.UseCases.Tarefa.Update;
public class Update : DefaultUseCase
{
    public static void Execute(Guid id, RequestTarefaJSON dadosAtualizados)
    {
        List<ResponseTarefaJSON> lista = GetMockedList();

        int IndexTarefaToUpdate = lista.FindIndex(x => x.Id == id);

        ResponseTarefaJSON UpdatedTarefa = new() {
            Id = id,
            Name = dadosAtualizados.Name,
            DeadLine = dadosAtualizados.DeadLine,
            Description = dadosAtualizados.Description,
            Priority = dadosAtualizados.Priority,
            Status = dadosAtualizados.Status
        };

        lista[IndexTarefaToUpdate] = UpdatedTarefa;

        OverwriteMockedList(lista);
    }
}
