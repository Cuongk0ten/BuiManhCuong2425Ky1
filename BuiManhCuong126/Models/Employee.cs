using System.ComponentModel.DataAnnotations;

namespace BuiManhCuong126.Models;

public class Employee
{
    [Key]
    public string Hoten { get; set; }
    public int MaSinhVien { get; set; }

    public DateTime Ngaysinh { get; set; }
}