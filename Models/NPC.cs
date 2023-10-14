using System.ComponentModel.DataAnnotations;

namespace rpgAPI.Models;

public class NPC
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Raca { get; set; }
    public string Sexo { get; set; }
    public int Idade { get; set; }
    public float Altura { get; set; }
    public string EstadoCivil { get; set; }
    public string Ocupacao { get; set; }
    public string Alinhamento { get; set; }
    public string Personalidade { get; set; }
    public int Forca { get; set; }
    public int Destreza { get; set; }
    public int Constituicao { get; set; }
    public int Inteligencia { get; set; }
    public int Sabedoria { get; set; }
    public int Carisma { get; set; }
}
