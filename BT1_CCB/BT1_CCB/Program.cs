internal class Program
{
    // Hàm tính tiền sau thuế với optional parameter
    static double TinhTienSauThue(double gia, double thue = 0.1)
    {
        return gia + (gia * thue);
    }

    private static void Main(string[] args)
    {
        double bien_223 = 100000; // Giá sản phẩm: 100,000 VND

        // Gọi hàm với mức thuế mặc định (10%)
        double tongTien1 = TinhTienSauThue(bien_223);
        Console.WriteLine($"Tổng tiền sau thuế (mặc định 10%): {tongTien1} VND");

        // Gọi hàm với mức thuế 5%
        double tongTien2 = TinhTienSauThue(bien_223, 0.05);
        Console.WriteLine($"Tổng tiền sau thuế (thuế 5%): {tongTien2} VND");
    }
}