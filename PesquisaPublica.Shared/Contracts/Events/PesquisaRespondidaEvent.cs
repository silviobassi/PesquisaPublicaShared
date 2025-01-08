namespace PesquisaPublica.Shared.Contracts.Events;

public record PesquisaRespondidaContractEvent
{
    public DateTime OccurredOn { get; init; }
    public long PesquisaId { get; init; }
    public string? NomeRespondente { get; init; }
    public string? EmailRespondente { get; init; }
    public int IdadeRespondente { get; init; }
    public required HashSet<long> RespostasIds { get; init; }
}