# Quy tắc chung `da-ptpm-qltv`

## **Quy tắc đặt tên biến/hàm:**

1. Đặt tên và hàm bằng tiếng Việt hoàn toàn
2. Mô tả rõ ràng biến/hàm đó có công dụng gì, để làm gì và như thế nào
3. Nếu cần thiết hãy `ghi chú`, việc ghi chú rõ ràng sẽ giúp việc đọc hiểu code rất nhiều

## **Các kiểu quy ước viết hoa:**

**1. Pascal case**

Sử dụng khi: 
- Tạo ra các `class`, `struct` hoặc `record` _(Đa phần thường sử dụng với `class` là nhiều)_
    
    Ví dụ:
    ```
    public class SinhVien (Nên)
    {
      
    }
    
    public class sinhvien/sinhVien (Không nên)
    {
      
    }
    ```
- Đối với các `interface` thì ta sẽ thêm một tiền tố I trước tên của `interface`
    
    Ví dụ:
    ```
    public interface IHocPhan
    {
      
    }
    ```
 - Các đối tượng thuộc `public` như `fields`, `properties`, `events`, `methods`, và `local functions` _(Cú pháp tạo nhanh properties: prop + tab)_
    
    Ví dụ:
    ```
    public class SinhVien
    {
        // Field
        public bool TotNghiep;

        // Property
        public string MaSV { get; set; }

        // Event
        public event Action EventProcessing;

        // Method
        public void LayDanhSachDiemHocPhan()
        {
            // Local function
            static int SoLuongHocPhanDaHoc() => IHocPhan.Count;
            // ...
        }
    }
    ```

**2. Camel case**

Sử dụng khi: 
- Các đối tượng thuộc `private` hoặc là `internal` fields
  
  Ví dụ:
    ```
    public class SinhVien
    {
        private string maSV;
    }
    ```
- Các đối số truyền vào method (hàm) 
  
  Ví dụ:
    ```
    public SinhVien TimSinhVienTheoTen(string tenSV)
    {
        
    }
    ```

## **Tham khảo thêm tại**
1. [Chuẩn viết code trong C#](https://timoday.edu.vn/chuan-viet-code-trong-c/)
2. [Biến trong C#](https://howkteam.vn/Learn/Lecture/52)
3. [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
4. [C# Coding Standards Best Practices](https://www.dofactory.com/csharp-coding-standards)
5. [Coding Standards for .NET](http://se.inf.ethz.ch/old/teaching/ss2007/251-0290-00/project/CSharpCodingStandards.pdf)

## **Còn tiếp...**
