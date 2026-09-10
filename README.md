# QuanLySV - Hệ Thống Quản Lý Sinh Viên (Windows Forms & Oracle DB)

Ứng dụng desktop quản lý hồ sơ sinh viên được phát triển bằng ngôn ngữ **C#** trên nền tảng **Windows Forms (.NET Framework 4.8)** kết hợp với hệ quản trị cơ sở dữ liệu **Oracle Database**. Dự án áp dụng kiến trúc phân tầng (N-tier) kết hợp thiết kế điều hướng giao diện linh hoạt dựa trên **UserControl**.

---

## 📌 Tính năng chính

### 1. Quản lý danh sách sinh viên (`UcList`)
- **Hiển thị danh sách tổng thể**: Trình bày thông tin sinh viên dưới dạng bảng trực quan (`DataGridView`) gồm MSSV, Họ tên, Giới tính, Ngày sinh, CCCD/VNeID, Địa chỉ, Số điện thoại và Trạng thái.
- **Bộ lọc linh hoạt**:
  - Lọc theo **Trạng thái hoạt động**: *Tất cả*, *Đang hoạt động*, *Ngưng hoạt động*.
  - Lọc theo **Giới tính**: *Tất cả*, *Nam*, *Nữ*.
- **Hành động theo dòng**:
  - Nút **Sửa**: Điều hướng sang màn hình cập nhật thông tin sinh viên.
  - Nút **Xóa (Xóa mềm)**: Cập nhật trạng thái sinh viên sang *Ngưng hoạt động*, có hộp thoại xác nhận trước khi thực hiện.
  - **Tự động ẩn nút Sửa/Xóa**: Các sinh viên ở trạng thái *Ngưng hoạt động* sẽ tự động ẩn các nút hành động để bảo toàn tính toàn vẹn dữ liệu.

### 2. Thêm mới & Chỉnh sửa hồ sơ sinh viên (`UcFormEdit`)
- Dùng chung một màn hình cho cả chức năng **Thêm mới** và **Cập nhật**, tự động điền dữ liệu khi ở chế độ chỉnh sửa.
- Thu thập đầy đủ các trường thông tin:
  - **Mã số sinh viên (MSSV)**, **Họ và tên**.
  - **Giới tính** (Radio button Nam / Nữ).
  - **Ngày sinh**, **Nơi sinh**.
  - **Số CCCD / VNeID**, **Ngày cấp**, **Nơi cấp**.
  - **Quê quán / Nguyên quán**, **Địa chỉ thường trú / Cư trú**.
  - **Số điện thoại** (định dạng kiểm soát qua `MaskedTextBox`).

### 3. Kiến trúc điều hướng động (Single-Form UserControl Navigation)
- `Form1` đóng vai trò là Shell/Khung ứng dụng chính.
- Việc chuyển đổi giữa màn hình *Danh sách* và *Thêm mới/Chỉnh sửa* được thực hiện bằng cách nạp/hủy các `UserControl` vào vùng chứa trung tâm (`PnlBody`) giúp ứng dụng mượt mà, không mở nhiều cửa sổ con rải rác.

---

## 🏗 Cấu trúc dự án

```text
QuanLySV/
├── App.config               # Cấu hình ứng dụng & Chuỗi kết nối Oracle Database
├── Form1.cs                 # Form chính chứa thanh điều hướng và vùng hiển thị
├── Program.cs               # Điểm khởi chạy ứng dụng (Main Entry Point)
├── sql.txt                  # Kịch bản DDL khởi tạo bảng cơ sở dữ liệu
├── Controls/                # Các UserControl giao diện thành phần
│   ├── UcList.cs            # Giao diện danh sách sinh viên & bộ lọc
│   └── UcFormEdit.cs        # Giao diện biểu mẫu thêm/sửa sinh viên
├── Helpers/                 # Các lớp tiện ích dùng chung
│   ├── OracleHelper.cs      # Xử lý kết nối và thực thi ADO.NET với Oracle
│   ├── GridViewHelper.cs    # Tiện ích tùy biến cột và kích thước DataGridView
│   └── AppColors.cs         # Bảng mã màu tiêu chuẩn cho giao diện
├── Models/                  # Các lớp thực thể dữ liệu (Data Models)
│   └── Student.cs           # Thực thể thông tin Sinh viên
└── Services/                # Tầng nghiệp vụ và truy vấn dữ liệu (Business / Data Layer)
    └── StudentService.cs    # Xử lý các thao tác CRUD với bảng STUDENT
```

---

## ⚙️ Công nghệ sử dụng

- **Ngôn ngữ**: C# 7.3+
- **Framework**: .NET Framework 4.8 (Windows Forms)
- **Cơ sở dữ liệu**: Oracle Database (hỗ trợ các phiên bản 11g, 12c, 19c, 21c)
- **Thư viện kết nối**: `Oracle.ManagedDataAccess` (ODP.NET Managed Driver)
- **Quản lý gói phụ thuộc**: NuGet Package Manager

---

## 🚀 Hướng dẫn cài đặt & Khởi chạy

### 1. Yêu cầu hệ thống
- Hệ điều hành: Windows 10/11 hoặc Windows Server.
- Môi trường phát triển: **Visual Studio 2019** hoặc **Visual Studio 2022** (với Workload *.NET desktop development*).
- Đã cài đặt và đang chạy dịch vụ **Oracle Database** (hoặc Oracle XE).

### 2. Khởi tạo Cơ sở dữ liệu
Đăng nhập vào Oracle SQL Developer hoặc SQL*Plus bằng tài khoản của bạn và thực thi script tạo bảng `STUDENT`:

```sql
CREATE TABLE STUDENT (
    STUDENTID VARCHAR2(20) PRIMARY KEY,
    NAME VARCHAR2(100) NOT NULL,
    SEX NUMBER(1),               -- 1: Nam, 0: Nữ
    BIRTHOFDATE DATE,
    BIRTHLOCAL VARCHAR2(200),
    VNEID VARCHAR2(12) UNIQUE,
    DATEOFISSUE DATE,
    LOCALOFISSUE VARCHAR2(200),
    LOCAL VARCHAR2(255),
    PLACEOFRESIDENCE VARCHAR2(255),
    NUMBERPHONE VARCHAR2(15),
    STATUS NUMBER(1) DEFAULT 1   -- 1: Đang hoạt động, 0: Ngưng hoạt động
);
```

### 3. Cấu hình Chuỗi kết nối (Connection String)
Mở tệp [App.config](file:///d:/TTANH/projects/learn-winform/qlsv_winform/QuanLySV/App.config) và cập nhật thông tin đăng nhập Oracle tương ứng với máy của bạn:

```xml
<connectionStrings>
  <add name="OracleConnection" 
       connectionString="User Id=YOUR_USER;Password=YOUR_PASSWORD;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SID=orcl)));" 
       providerName="Oracle.ManagedDataAccess.Client" />
</connectionStrings>
```

### 4. Build và Chạy ứng dụng

#### Bằng Visual Studio:
1. Mở tệp giải pháp `QuanLySV.sln`.
2. Chuột phải vào project `QuanLySV` chọn **Restore NuGet Packages**.
3. Nhấn `F5` hoặc chọn **Debug > Start Debugging** để khởi chạy ứng dụng.

#### Bằng dòng lệnh:
```powershell
# Di chuyển vào thư mục QuanLySV
cd QuanLySV

# Biên dịch ứng dụng
dotnet build QuanLySV.csproj

# Khởi chạy file thực thi
.\bin\Debug\QuanLySV.exe
```

---

## 📋 Quy ước mã nguồn & Kiến trúc

- **Kiến trúc phân tầng**:
  - `Controls` (Giao diện) không viết trực tiếp câu lệnh SQL mà giao tiếp thông qua `Services`.
  - `Services` thực thi nghiệp vụ và tương tác với database thông qua `OracleHelper`.
  - `OracleHelper` đóng gói các thao tác mở/đóng kết nối an toàn với lệnh `using`.
- **Quy ước đặt tên**: Tuân thủ chuẩn FDS cho Windows Forms:
  - Nút bấm: tiền tố `Btn` (ví dụ `BtnCreate`, `BtnList`, `BtnSave`).
  - Ô nhập liệu: tiền tố `Tbx` (ví dụ `TbxStudentId`, `TbxName`).
  - Danh sách chọn: tiền tố `Cbx` (ví dụ `CbxStatus`, `CbxSex`).
  - Bảng dữ liệu: tiền tố `Dgv` (ví dụ `DgvListSV`).
  - Hằng số cột: chữ hoa bắt đầu bằng `COL_` (ví dụ `COL_EDIT`, `COL_DELETE`).
