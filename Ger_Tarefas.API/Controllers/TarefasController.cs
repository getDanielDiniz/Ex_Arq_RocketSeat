using Ger_Tarefas.Application.UseCases.Tarefa.Create;
using Ger_Tarefas.Application.UseCases.Tarefa.Delete;
using Ger_Tarefas.Application.UseCases.Tarefa.ReadAll;
using Ger_Tarefas.Application.UseCases.Tarefa.ReadById;
using Ger_Tarefas.Application.UseCases.Tarefa.Update;
using Ger_Tarefas.Comunication.Requests;
using Ger_Tarefas.Comunication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Ger_Tarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TarefasController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(statusCode:StatusCodes.Status201Created, type: typeof(ResponseTarefaJSON))]
    public IActionResult CreateTarefa([FromBody] RequestTarefaJSON NewTarefa)
    {

        ResponseTarefaJSON response =  Create.Execute(NewTarefa);
        return Created(string.Empty,response);
    }

    [HttpGet]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK, type: typeof(List<ResponseTarefaJSON>))]
    public IActionResult GetAll() { 
        List<ResponseTarefaJSON> list = ReadAll.Execute();

        return Ok(list);
    }
    
    [HttpGet("${id}")]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK, type: typeof(ResponseTarefaJSON))]
    public IActionResult GetById([FromRoute] Guid id) {

        ResponseTarefaJSON FoundTarefa = ReadById.Execute(id);
        return Ok(FoundTarefa);
    }

    [HttpDelete("${id}")]
    [ProducesResponseType(statusCode: StatusCodes.Status204NoContent)]
    public IActionResult Delete(Guid id) {

        DeleteTarefa.Execute(id);
        return NoContent();
    }

    [HttpPut("${id}")]
    [ProducesResponseType(statusCode:StatusCodes.Status204NoContent)]
    public IActionResult UpdateById([FromRoute] Guid id, [FromBody] RequestTarefaJSON tarefa)
    {
        Update.Execute(id: id, dadosAtualizados: tarefa);
        return NoContent();
    }

    
}
