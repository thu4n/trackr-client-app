# Trackr
![img](/logoSmall.png)

Một ứng dụng desktop giúp theo dõi hành trình đơn hàng, đây là đồ án cho môn học Lập trình mạng căn bản tại UIT. 
## Table of Contents
- [Quy tắc làm việc chung trên GitHub](#quy-tắc-làm-việc-chung-trên-github)
- [Quy ước chung về code và tên biến](#quy-ước-chung-về-code-và-tên-biến)
- [Tổng quan về đồ án](#tổng-quan-về-đồ-án)
- [Các tính năng chính của ứng dụng](#các-tính-năng-chính-của-ứng-dụng)
- [Kiến trúc hệ thống và công nghệ sử dụng](#kiến-trúc-hệ-thống-và-công-nghệ-sử-dụng)
- [Đặc tả các giao thức truyền thông trong ứng dụng](#đặc-tả-các-giao-thức-truyền-thông-trong-ứng-dụng)
- [Demo ứng dụng](#demo-ứng-dụng)
## Quy tắc làm việc chung trên GitHub
- Clone nhánh `main` của repository này về để có thể bắt đầu làm việc trên local. Sau này, mỗi khi có các thay đổi mới trên GitHub, sử dụng `git pull` để kéo về local.
- Khi commit các thay đổi của mình, phải ghi rõ nội dung commit và quy tắc là commit sau khi hoàn thành một tính năng cụ thể nào đó, KHÔNG commit dồn.
- Khi push lên GitHub, **tuyệt đối** không push lên nhánh `main` (Đã có set protection rule). Push lên nhánh `dev` cho các tính năng *chung* và sửa đổi *tổng thể*.
- Khi muốn thay đổi của mình được merge vào `main`, tạo pull request và nhờ người khác trong team vào review request.
- Hai nhánh để làm việc chính là nhánh `server-side` và nhánh `client-side`. Mỗi khi có tính năng được hoàn thiện ở 1 trong 2 nhánh, tiến hành `merge` vào nhánh `dev` và kiểm tra conflict.
- Nếu nhánh `server-side` hoặc nhánh `client-side` bị tụt lại so với `dev`, thực hiện lệnh `git pull origin dev` để kéo thay đổi về nhánh mà mình **đang làm**.
- Khi có bug, khó fix thì tạo thêm nhánh `fix-bug-x-in-y` từ nhánh mình **đang làm** với `x` là tên bug và `y` là tên nhánh. Sau khi đã kiểm chứng không còn xuất hiện bug, tiến hành merge vào nhánh **gốc** và xóa nhánh hiện tại đi.
## Quy ước chung về code và tên biến

**Áp dụng cho trùng tên biến**

Nếu khác tên thì chỉ cần comment trực tiếp vào code và ghi vào document

Khi đặt tên biến hoặc tên hàm, ta sẽ thống nhất đặt thứ tự prefix + `_` để phân cách, đây là các thứ tự ưu tiên sẽ liệt kê từ trên xuống

### Kiểu dữ liệu

- Thống nhất theo kiểu toán học về số học, ta có:
  - Số nguyên: int, long
  - Số thực:float, double

> Ví dụ: int_a, long_a, float_a, double _a

- Thống nhất về kiểu dữ liệu:
  - Mảng: arr

> Ví dụ: arr_a

### Kiểu toolbox in C# khi lập trình

Thống nhất ghi cụ thể ra

> Ví dụ: textbox, richtextbox, ...

### Ý nghĩa

Cái này mình thống nhất ghi ý nghĩa tên biến vào file docx và phải có comment dưới tên biến và tên hàm. Comment ý nghĩa bằng tiếng việt

### Quy ước code clean

- Khi viết `{}` thì phải xuống hàng luôn.

> Ví dụ: while(1)
> {
> }

- Ở các lần commit, ghi rõ theo cú pháp: nội dung sửa đổi - ngày

- Các file có đánh số cần có `[]`

> Ví dụ: main[1].cpp, test[1].cpp

## Tổng quan về đồ án
**Trackr** là một ứng dụng desktop để người dùng cập nhật và theo dõi tình trạng vận chuyển đơn hàng được mua trực tuyến từ trước. Ứng dụng được sử dụng trong ngữ cảnh như sau: "Một cửa hàng online cần sử dụng dịch vụ vận chuyển để giao hàng đến cho khách hàng, ứng dụng này sẽ hoạt động như bộ phận chuyên vận chuyển các đơn hàng của shop. Người quản lý cửa hàng sẽ có khả năng thêm đơn hàng và phân công giao hàng". Sẽ có 3 loại user (sẽ không có user thuộc loại Cửa hàng để giữ tính đơn giản) khi truy cập vào ứng dụng:

- Customer - Người mua hàng muốn kiểm tra xem đơn hàng đã được vận chuyển tới đâu
- Delivery - Nhân viên giao hàng thường xuyên cập nhật vị trí và tình trạng của đơn hàng mình đang vận chuyển.
- Administrator (admin) - Quản trị viên có khả năng theo dõi và thực hiện các tác vụ quản lý như thêm, sửa hoặc xóa các thông tin (record) về user hoặc đơn hàng. Đây là vai trò dành cho người quản lý cửa hàng.

Ngoài ra còn có các đối tượng Parcel chứa mọi thông tin chi tiết về một đơn hàng tương ứng.
## Các tính năng chính của ứng dụng
- Cho phép nhiều user cùng lúc có thể xem cũng như cập nhật thông tin theo thời gian thực.
- Hệ thống tính phí giao hàng dựa trên khoảng cách vật lý
- Có xác thực và phân quyền cho mỗi loại user:
  - Customer chỉ có quyền đọc thông tin của bên Delivery và Parcel.
  - Delivery tương tự như customer, nhưng có thêm quyền cập nhật các thông tin liên quan đến vị trí và tình trạng của Parcel.
  - Admin có toàn quyền đối với các record của Customer, Delivery và Parcel.
## Kiến trúc hệ thống và công nghệ sử dụng
- Kiến trúc hệ thống

![img2](/system-architecture-diagram.png)

- Công nghệ sử dụng:
 1. IDE: Visual Studio 2019 hoặc 2022 
 2. Ngôn ngữ sử dụng: C# (ngôn ngữ dùng chính), XAML ,HTML, CSS, Javascript, SQL.
 3. Framework sử dụng: WPF, ASP.NET 
 4. Thư viện sử dụng: SignalR
 5. Network stack: Websocket (TCP), RESTful API HTTP request
 6. Loại project: Desktop application
 7. Database system: Azure SQL Database và SQL Server Express LocalDB
 8. Version control: Git

## Đặc tả các giao thức truyền thông trong ứng dụng
## Demo ứng dụng
