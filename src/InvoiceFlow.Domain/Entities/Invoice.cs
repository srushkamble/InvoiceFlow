using InvoiceFlow.Domain.Enums;

namespace InvoiceFlow.Domain.Entities;

public class Invoice
{
    public int Id { get; set; }
    public string InvoiceNumber { get; set; } = string.Empty;

    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public DateTime IssueDate { get; set; } = DateTime.UtcNow;
    public DateTime DueDate { get; set; }
    public InvoiceStatus Status { get; set; } = InvoiceStatus.Draft;

    public List<InvoiceItem> Items { get; set; } = new();

    public decimal TotalAmount => Items.Sum(i => i.LineTotal);
}