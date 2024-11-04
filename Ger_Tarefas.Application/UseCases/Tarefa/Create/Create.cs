using Ger_Tarefas.Comunication.Requests;
using Ger_Tarefas.Comunication.Responses;

namespace Ger_Tarefas.Application.UseCases.Tarefa.Create;
public class Create : DefaultUseCase
{

    public static ResponseTarefaJSON Execute(RequestTarefaJSON RequestTarefa)
    {
        List<ResponseTarefaJSON> list = GetMockedList();

        ResponseTarefaJSON NewTarefa = new(RequestTarefa);

        list.Add(NewTarefa);

        OverwriteMockedList(list);

        return NewTarefa;
    }
}
