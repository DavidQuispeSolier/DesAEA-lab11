namespace lab11.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public string Date { get; set; }
        public string InvoiceNumber { get; set; }
        public float Total { get; set; }
    }
}
