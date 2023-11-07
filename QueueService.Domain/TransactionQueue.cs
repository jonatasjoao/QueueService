namespace QueueService.Domain;

public class TransactionQueue
{
    public Int64 ID { get; set; }
    public bool Active { get; set; }
    public TransactionQueueStatus TransactionQueueStatus { get; set; }
    public Int64 TransactionQueueStatusID { get; set; }
    public Int64 UserID { get; set; }
    public User User { get; set; }
    public string RequestCypher { get; set; }
    public string Path { get; set; }
    public string ResponseCypher { get; set; }
    public int ResponseStatusCode { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? StartedAt { get; set; }
    public DateTime? StopedAt { get; set; }
    public DateTime? FinishedAt { get; set; }
}