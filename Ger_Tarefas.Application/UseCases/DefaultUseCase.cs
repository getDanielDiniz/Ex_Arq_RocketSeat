using Ger_Tarefas.Comunication.Responses;
using System.Text.Json;

namespace Ger_Tarefas.Application.UseCases;
public class DefaultUseCase
{
    public static List<ResponseTarefaJSON> GetMockedList()
    {
        string JsonFile = System.IO.File.ReadAllText("../Ger_Tarefas.Application/Mockup/Tarefas.JSON");
        List<ResponseTarefaJSON> list = JsonSerializer.Deserialize<List<ResponseTarefaJSON>>(JsonFile) ?? [];
        return list;
    }

    public static void OverwriteMockedList(List<ResponseTarefaJSON> list)
    {
        string JsonList = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true});
        System.IO.File.WriteAllText("../Ger_Tarefas.Application/Mockup/Tarefas.JSON", JsonList);
    }
}
