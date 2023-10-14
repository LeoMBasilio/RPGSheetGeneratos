namespace rpgAPI.Controllers;

public static class sheetGenerator
{
    private static List<string> Nomes = new List<string> { "Alden", "Elara", "Thorian", "Isolde", "Roderic", "Sylvana", "Davian", "Elysia", "Faelan", "Mirabelle", "Gareth", "Ceridwen", "Aria", "Lorelei", "Alaric", "Maelis", "Lyria", "Finnian", "Cassia", "Eldric", "Seraphina", "Lucien", "Oriana", "Emrys", "Brielle", "Kaelen", "Vivienne", "Tristan", "Morgana", "Calista", "Lysander", "Rhiannon", "Gavin", "Maelis", "Eowyn", "Rhys", "Elowen", "Caelum", "Isolde", "Eirian", "Thalassa", "Caden", "Aurelia", "Lorcan", "Esme", "Alistair", "Sorcha", "Eldarion", "Aurora", "Brenna" };
    private static List<string> Raca = new List<string> { "Humano", "Elfo", "Anão", "Orc", "Halfling", "Gnomo", "Meio-Elfo", "Meio-Orc", "Tiefling", "Aarakocra", "Genasi", "Goliath", "Tabaxi", "Kenku", "Gith", "Firbolg", "Warforged", "Changeling", "Tritão", "Yuan-Ti", "Aasimar", "Folk Humano", "Minotauro", "Kobold", "Centaur", "Lizardfolk", "Goblin", "Kalashtar", "Shifter", "Changeling", "Simic Hybrid", "Vedalken", "Warforged", "Loxodon", "Sharkfolk", "Thri-Kreen", "Satyr", "Kitsune", "Naga", "Siren", "Tengu", "Vanara", "Grung", "Kor", "Sahuagin", "Merfolk", "Kuo-Toa", "Aven" };
    private static List<string> Sexo = new List<string> { "Masculino", "Feminino" };
    private static List<string> EstadoCivil = new List<string> { "Solteiro", "Casado", "Viúvo", "Divorciado" };
    private static List<string> Profissao = new List<string> { "Mercenário", "Ladrão", "Mago", "Cavaleiro", "Clerigo", "Ferreiro", "Caçador", "Alquimista", "Taverna", "Bardo", "Diplomata", "Coveiro", "Fazendeiro", "Arqueiro", "Espadachim", "Navegador", "Astrólogo", "Acrobata", "Pescador", "Artista", "Boticário", "Caçador de Recompensas", "Curandeiro", "Historiador", "Assassino", "Cientista", "Artesão", "Explorador", "Bibliotecário", "Necromante", "Bailarino", "Médico", "Palhaço", "Pirata", "Comerciante", "Nobre", "Tatuador", "Xamã", "Aventureiro", "Guarda da Cidade", "Pregador", "Lutador de Arena", "Caçador de Monstros", "Dramaturgo", "Construtor de Máquinas", "Arqueólogo", "Caçador de Tesouros" };
    private static List<string> Class = new List<string> { "Guerreiro", "Mago", "Ladino", "Clérigo", "Bárbaro", "Bardo", "Druida", "Feiticeiro", "Bruxo", "Paladino", "Ranger", "Monge", "Arqueiro", "Necromante", "Alquimista", "Cavaleiro", "Xamã", "Assassino", "Artífice", "Feiticeiro de Sangue", "Inquisidor", "Mestre das Máquinas", "Adivinho", "Arqueólogo", "Lutador de Arena", "Psíquico", "Samurai", "Elementalista", "Xerife", "Sacerdotisa", "Mercador", "Esgrimista", "Engenheiro", "Médico", "Cavaleiro das Trevas", "Mestre de Bestas", "Ninja", "Cavaleiro da Ordem", "Mestre de Armas", "Gatuno", "Arqueiro Sombrio", "Clériga da Luz", "Bardo do Colégio", "Guardião Selvagem", "Monge do Punho", "Assassino de Guilda", "Alquimista Tinker", "Caçador de Monstros" };
    private static List<string> Alinhamento = new List<string> { "Leal e Bom", "Neutro e Bom", "Caótico e Bom", "Leal e Neutro", "Neutro", "Caótico e Neutro", "Leal e Mau", "Neutro e Mau", "Caótico e Mau" };
    private static List<string> Personalidade = new List<string> { "Paciente", "Impaciente", "Alegre", "Triste", "Sério", "Brincalhão", "Calmo", "Nervoso", "Simpático", "Antipático", "Amigável", "Hostil", "Sociável", "Solitário", "Otimista", "Pessimista", "Corajoso", "Covarde", "Honrado", "Desonrado", "Honesto", "Desonesto", "Generoso", "Avarento", "Pacífico", "Violento", "Preguiçoso", "Ambicioso", "Vingativo", "Paciente", "Impaciente", "Alegre", "Triste", "Sério", "Brincalhão", "Calmo", "Nervoso", "Simpático", "Antipático", "Amigável", "Hostil", "Sociável", "Solitário", "Otimista", "Pessimista", "Corajoso", "Covarde", "Honrado", "Desonrado", "Honesto", "Desonesto", "Generoso", "Avarento", "Pacífico", "Violento", "Preguiçoso", "Ambicioso", "Vingativo" };


    public static string RandomName()
    {
        Random random = new Random();
        return Nomes[random.Next(Nomes.Count)];
    }

    public static string RandomRaca()
    {
        Random random = new Random();
        return Raca[random.Next(Raca.Count)];
    }

    public static string RandomSexo()
    {
        Random random = new Random();
        return Sexo[random.Next(Sexo.Count)];
    }

    public static int RandomIdade()
    {
        Random random = new Random();
        return random.Next(5, 200);
    }

    public static float RandomAltura()
    {
        Random random = new Random();
        return (float)random.NextDouble() * (3.00f - 1.00f) + 1.00f;
    }

    public static string RandomEstadoCivil()
    {
        Random random = new Random();
        return EstadoCivil[random.Next(EstadoCivil.Count)];
    }

    public static string RandomProfissao()
    {
        Random random = new Random();
        return Profissao[random.Next(Profissao.Count)];
    }

    public static string RandomClass()
    {
        Random random = new Random();
        return Class[random.Next(Class.Count)];
    }

    public static string RandomAlinhamento()
    {
        Random random = new Random();
        return Alinhamento[random.Next(Alinhamento.Count)];
    }

    public static string RandomPersonalidade()
    {
        Random random = new Random();
        return Personalidade[random.Next(Personalidade.Count)];
    }

    public static int RandomForca()
    {
        Random random = new Random();
        return random.Next(1, 20);
    }

    public static int RandomDestreza()
    {
        Random random = new Random();
        return random.Next(1, 20);
    }

    public static int RandomConstituicao()
    {
        Random random = new Random();
        return random.Next(1, 20);
    }

    public static int RandomInteligencia()
    {
        Random random = new Random();
        return random.Next(1, 20);
    }

    public static int RandomSabedoria()
    {
        Random random = new Random();
        return random.Next(1, 20);
    }

    public static int RandomCarisma()
    {
        Random random = new Random();
        return random.Next(1, 20);
    }
}
