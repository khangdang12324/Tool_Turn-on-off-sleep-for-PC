# ☕ KeepAwake

Một tiện ích nhỏ gọn trên Windows giúp ngăn máy tính và màn hình tự động tắt, hoạt động hoàn toàn ẩn dưới khay hệ thống (System Tray).

## 🌟 Giới thiệu

Bạn cảm thấy phiền phức khi màn hình máy tính tự động tắt sau 1 phút không tương tác? KeepAwake là giải pháp "nhỏ nhưng có võ" giúp bạn giải quyết vấn đề này. 

Thay vì phải mở ứng dụng Settings của Windows để chỉnh sửa thời gian tắt màn hình mỗi khi cần treo máy, KeepAwake chạy ngầm siêu nhẹ ở góc phải thanh Taskbar, cho phép bạn chủ động Bật/Tắt chế độ giữ sáng màn hình tức thời chỉ với một cú click chuột.

## 📸 Giao diện trực quan

*(Nhắc nhẹ: Bạn hãy tạo thư mục `images` trên GitHub, up tấm ảnh khay hệ thống hôm nọ lên, sau đó dán link ảnh đè vào chữ `link-anh-cua-ban.png` ở dòng dưới nhé)*

![Giao diện KeepAwake]
<img width="261" height="115" alt="image" src="https://github.com/user-attachments/assets/abb180aa-40c5-47b4-8d7f-15d44d9fcdc3" />


## 🚀 Tính năng chính

* **Giữ màn hình luôn sáng:** Ngăn màn hình tắt và ngăn Windows rơi vào trạng thái Sleep.
* **Giao diện tối giản:** Không có cửa sổ ứng dụng cồng kềnh, hoạt động 100% qua icon trên System Tray.
* **Tự vẽ UI bằng code:** Icon trực quan thay đổi theo trạng thái (⚪ Chấm xám: Đang Tắt | 🟢 Chấm xanh: Đang Bật).
* **Đóng gói độc lập (Self-contained):** Chạy ngay lập tức chỉ với 1 file `.exe` duy nhất mà không yêu cầu máy người dùng phải cài sẵn .NET Runtime.

## 📥 Tải xuống & Cài đặt

**[⬇️ BẤM VÀO ĐÂY ĐỂ TẢI VỀ KEEPAWAKE (Bản mới nhất)](https://github.com/khangdang12324/Tool_Turn-on-off-sleep-for-PC/releases/tag/v1)**

**Hướng dẫn sử dụng nhanh:**
1. Nhấn vào link trên để tải file `KeepAwake.zip` về máy.
2. Giải nén thư mục vừa tải.
3. Chạy trực tiếp file `KeepAwake.exe` để sử dụng ngay (có thể click chuột phải chọn *Send to > Desktop* để tạo shortcut).

## 💡 Cách sử dụng

* Sau khi chạy, ứng dụng sẽ xuất hiện dưới dạng một chấm tròn ở khay hệ thống (góc dưới cùng bên phải màn hình).
* **Nhấp đúp chuột trái** vào icon để chuyển đổi qua lại giữa 2 trạng thái:
    * ⚪ **Icon Xám:** Chế độ KeepAwake đang **TẮT**. Màn hình sẽ tự tắt theo cài đặt mặc định của Windows.
    * 🟢 **Icon Xanh lá:** Chế độ KeepAwake đang **BẬT**. Màn hình của bạn sẽ được giữ sáng liên tục.
* **Nhấp chuột phải** vào icon để mở menu ngữ cảnh, cho phép bạn thao tác Bật/Tắt hoặc chọn "Thoát" để đóng hoàn toàn ứng dụng.

## 🛠️ Công nghệ sử dụng

* **Ngôn ngữ:** C#
* **Nền tảng:** .NET 10 (Publish Single File & Self-contained)
* **Giao diện:** Windows Forms (TrayApplicationContext)
* **API Hệ thống:** Win32 API (`SetThreadExecutionState` từ `kernel32.dll`)

---

## 👨‍💻 Tác giả

Được phát triển để giải quyết sự phiền toái nhỏ trong công việc hàng ngày.
🌐 Tham khảo thêm các dự án khác tại Portfolio cá nhân: [dangnguyenphuckhang.id.vn](https://dangnguyenphuckhang.id.vn)
