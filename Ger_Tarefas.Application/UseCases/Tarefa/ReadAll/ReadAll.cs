using Ger_Tarefas.Comunication.Responses;

namespace Ger_Tarefas.Application.UseCases.Tarefa.ReadAll;
public class ReadAll : DefaultUseCase
{
    public static List<ResponseTarefaJSON> Execute()
    {
        return GetMockedList();
    }
}
