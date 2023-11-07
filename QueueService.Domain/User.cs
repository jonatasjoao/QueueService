using System.Text.Json.Serialization;

namespace QueueService.Domain;

public class User
{
    public Int64 ID { get; set; }
    
    public Int64 PersonID { get; set; }
    
    public string UserName { get; set; }
    
    public string NormalizedUserName { get; set; }
    
    public string Email { get; set; }
    
    public string NormalizedEmail { get; set; }
    
    public bool? EmailConfirmed { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string PasswordHash { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string TransactionPasswordHash { get; set; }
    
    public string SecurityStamp { get; set; }
    
    public string ConcurrencyStamp { get; set; }
    
    public string PhoneNumber { get; set; }
    
    public bool? PhoneNumberConfirmed { get; set; }
    
    public string TwoFactorEnabled { get; set; }
    
    public string Cep { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
    public DateTime? DestroyedAt { get; set; }
    
    public bool? LockoutEnabled { get; set; }
    
    public bool? TermsOfAccept { get; set; }
    
    public int? AccessFailedCount { get; set; }
    
    public string Role { get; set; }    
    
    public bool NeedChange { get; set; }
    
    public bool Attendant { get; set; } = false;
    
    public Person Person { get; set; }
    
    public string addressNumber { get; set; }
    
    public string addressComplement { get; set; }
    
    public bool IsManager { get; set; } = false;
    
    public bool IsCommercial { get; set; } = false;
}