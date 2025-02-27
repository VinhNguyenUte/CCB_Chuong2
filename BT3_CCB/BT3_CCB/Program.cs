internal class Program
{
    enum OrderStatus
    {
        Pending = 1,    // Chờ xử lý
        Processing,     // Đang xử lý
        Shipped,        // Đã giao hàng
        Delivered       // Đã nhận hàng
    }
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public OrderStatus Status { get; set; }

        // Constructor
        public Order(int orderID, string customerName, OrderStatus status)
        {
            OrderID = orderID;
            CustomerName = customerName;
            Status = status;
        }

        // Phương thức in thông tin đơn hàng với optional parameter 
        public void PrintOrderInfo(bool showStatus = true)
        {
            Console.WriteLine($"Đơn hàng #{OrderID}");
            Console.WriteLine($"Khách hàng: {CustomerName}");
            if (showStatus)
            {
                Console.WriteLine($"Trạng thái: {Status}");
            }
            Console.WriteLine("--------------------------");
        }
    }
    private static void Main(string[] args)
    {
        // Tạo một đơn hàng
        Order bien_223 = new Order(101, "Nguyễn Văn A", OrderStatus.Processing);

        // In thông tin đơn hàng có trạng thái
        bien_223.PrintOrderInfo();

        // In thông tin đơn hàng nhưng không hiển thị trạng thái
        bien_223.PrintOrderInfo(false);
    }
}