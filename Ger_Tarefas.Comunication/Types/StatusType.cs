using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ger_Tarefas.Comunication.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StatusType
{
    concluida,
    andamento,
    aguardando
}
