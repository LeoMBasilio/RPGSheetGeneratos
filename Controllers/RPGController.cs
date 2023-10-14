using Microsoft.AspNetCore.Mvc;
using rpgAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rpgAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RPGController : ControllerBase
{

    private int id = 0;


    [HttpGet]
    public IActionResult GeneratorNPC()
    {
        NPC _sheet = new NPC()
        {
            Id = id++,
            Name = sheetGenerator.RandomName(),
            Raca = sheetGenerator.RandomRaca(),
            Sexo = sheetGenerator.RandomSexo(),
            Idade = sheetGenerator.RandomIdade(),
            Altura = sheetGenerator.RandomAltura(),
            EstadoCivil = sheetGenerator.RandomEstadoCivil(),
            Ocupacao = sheetGenerator.RandomProfissao(),
            Alinhamento = sheetGenerator.RandomAlinhamento(),
            Personalidade = sheetGenerator.RandomPersonalidade(),
            Forca = sheetGenerator.RandomForca(),
            Destreza = sheetGenerator.RandomDestreza(),
            Constituicao = sheetGenerator.RandomConstituicao(),
            Inteligencia = sheetGenerator.RandomInteligencia(),
            Sabedoria = sheetGenerator.RandomSabedoria(),
            Carisma = sheetGenerator.RandomCarisma()
        };
        return Ok(_sheet);
    }



}
