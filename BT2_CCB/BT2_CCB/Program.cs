using System.Text;
enum OrderStatus
{
    Pending = 1,    // Chờ xử lý
    Processing,     // Đang xử lý
    Shipped,        // Đã giao hàng
    Delivered       // Đã nhận hàng
}
internal class Program
{
    
    private static void Main(string[] args)
    {
        Console.WriteLine("Danh sách trạng thái đơn hàng:");
        foreach (string name in Enum.GetNames(typeof(OrderStatus)))
        {
            Console.WriteLine($"- {name} ({(int)Enum.Parse(typeof(OrderStatus), name)})");
        }

        Console.Write("\nNhập số trạng thái đơn hàng (1-4): ");
        if (int.TryParse(Console.ReadLine(), out int statusNumber))
        {
            if (Enum.IsDefined(typeof(OrderStatus), statusNumber))
            {
                OrderStatus bien_223 = (OrderStatus)statusNumber;
                Console.WriteLine($"Trạng thái đơn hàng: {bien_223}");
            }
            else
            {
                Console.WriteLine("Lỗi: Số nhập vào không hợp lệ!");
            }
        }
    }
}