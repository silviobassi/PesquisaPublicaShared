namespace PesquisaPublica.Shared.Contracts.Events;

public interface PesquisaRespondidaEvent
{
    public DateTime OccurredOn { get; }
    public long PesquisaId { get; }
    public string? NomeRespondente { get; }
    public string? EmailRespondente { get; }
    public int IdadeRespondente { get; }
    public HashSet<long> RespostasIds { get; }
}