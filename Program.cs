void ObterMeias(List<Time> times)
{
    var jogadores = (from time in times
                     from jogador in time.Jogadores
                     where jogador.Tipo == Tipo.MEIA
                     select new { jogador.NomeJogador, time.NomeTime }
                     ).ToList();
    Console.WriteLine(string.Join(" \n", jogadores));
}

List<Time> times = new() {
    new Time ("Gremio",new List<Jogador>() {
        new Jogador("Gabriel Granco", Tipo.GOLEIRO),
        new Jogador("Rafinha", Tipo.LATERAL),
        new Jogador("Bruno Cortez", Tipo.LATERAL),
        new Jogador("Pedro Geromel", Tipo.ZAGUEIRO),
        new Jogador("Ruan", Tipo.ZAGUEIRO),
        new Jogador("Tiago Santos", Tipo.VOLANTE),
        new Jogador("Lucas Silva", Tipo.VOLANTE),
        new Jogador("Ferreira", Tipo.MEIA),
        new Jogador("Jaminton Campaz", Tipo.MEIA),
        new Jogador("Jhonata Robert", Tipo.MEIA),
        new Jogador("Diego Souza", Tipo.ATACANTE),
    }),
    new Time("Flamengo", new List<Jogador>() {
        new Jogador("Hugo Souza", Tipo.GOLEIRO),
        new Jogador("Rodinel", Tipo.LATERAL),
        new Jogador("Renê", Tipo.LATERAL),
        new Jogador("Gustavo Henrique", Tipo.ZAGUEIRO),
        new Jogador("Léo Pereira", Tipo.ZAGUEIRO),
        new Jogador("Thiago Maia", Tipo.VOLANTE),
        new Jogador("João Gomes", Tipo.VOLANTE),
        new Jogador("Kenedy", Tipo.MEIA),
        new Jogador("Diego", Tipo.MEIA),
        new Jogador("Vitinho", Tipo.MEIA),
        new Jogador("Vitor Gabriel", Tipo.ATACANTE),
    }),
};

ObterMeias(times);

class Time
{
    public string NomeTime { get; set; }
    public List<Jogador> Jogadores { get; set; }

    public Time(string nome, List<Jogador> jogadores)
    {
        this.NomeTime = nome;
        this.Jogadores = jogadores;
    }
}

class Jogador
{
    public string NomeJogador { get; set; }
    public Tipo Tipo { get; set; }

    public Jogador(string nome, Tipo tipo)
    {
        this.NomeJogador = nome;
        this.Tipo = tipo;
    }
}

enum Tipo
{
    GOLEIRO,
    LATERAL,
    ZAGUEIRO,
    MEIA,
    ATACANTE,
    VOLANTE,
}