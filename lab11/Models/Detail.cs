namespace lab11.Models
{
    public class Detail
    {
        public int DetailId { get; set; }

        public virtual Product Product { get; set; }
        public int ProductId { get; set; }

        public virtual Invoice Invoice { get; set; }
        public int InvoiceId  { get; set; }

        public int Amount { get; set; }
        public float Price { get; set; }
        public float SubTotal { get; set; }
       

    }
}
