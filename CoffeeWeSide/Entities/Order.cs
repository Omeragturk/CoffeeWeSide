namespace CoffeeWebSide.Entities
{
    public class Order
    {
       
       public int Id { get; set; }
        public bool IsPayment { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Table Table { get; set; }
    }
}
