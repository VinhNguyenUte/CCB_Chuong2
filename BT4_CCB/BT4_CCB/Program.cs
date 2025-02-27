internal class Program
{
    private static void Main(string[] args)
    {
        // Khai báo mảng chứa danh sách sinh viên
        string[] bien_233 = { "Nguyễn Văn A", "Trần Thị B", "Lê Văn C", "Phạm Thị D" };

        // Duyệt qua mảng bằng vòng lặp foreach
        Console.WriteLine("Danh sách sinh viên:");
        foreach (string ten in bien_233)
        {
            Console.WriteLine("- "+ ten +"");
        }
    }
}