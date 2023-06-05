# Trackr

![img](/logoSmall.png)

Một ứng dụng desktop giúp theo dõi hành trình đơn hàng, đây là đồ án cho môn học Lập trình mạng căn bản tại UIT.
Đây là repository cho ứng dụng ở phía client. Phía server được lưu trữ ở repository riêng: https://github.com/howtodie123/Trackr-WebServer

## Table of Contents

- [Trackr](#trackr)
  - [Table of Contents](#table-of-contents)
  - [Quy tắc làm việc chung trên GitHub](#quy-tắc-làm-việc-chung-trên-github)
  - [Tổng quan về đồ án](#tổng-quan-về-đồ-án)
  - [Các tính năng chính của ứng dụng](#các-tính-năng-chính-của-ứng-dụng)
  - [Kiến trúc hệ thống và công nghệ sử dụng](#kiến-trúc-hệ-thống-và-công-nghệ-sử-dụng)
  - [Đặc tả database](#đặc-tả-database)
  - [Đặc tả các giao thức truyền thông trong ứng dụng](#đặc-tả-các-giao-thức-truyền-thông-trong-ứng-dụng)
  - [Đặc tả Message Structure](#đặc-tả-message-structure)
  - [Đặc tả luồng người dùng](#đặc-tả-luồng-người-dùng)
    - [Tại màn hình đăng nhập](#tại-màn-hình-đăng-nhập)
      - [Quản lý cửa hàng](#quản-lý-cửa-hàng)
      - [Nhân viên giao hàng](#nhân-viên-giao-hàng)
      - [Khách hàng](#khách-hàng)

## Quy tắc làm việc chung trên GitHub

- Clone nhánh `main` của repository này về để có thể bắt đầu làm việc trên local. Sau này, mỗi khi có các thay đổi mới trên GitHub, sử dụng `git pull` để kéo về local.
- Khi commit các thay đổi của mình, phải ghi rõ nội dung commit và quy tắc là commit sau khi hoàn thành một tính năng cụ thể nào đó, KHÔNG commit dồn.
- Khi push lên GitHub, **tuyệt đối** không push lên nhánh `main` (Đã có set protection rule). Push lên nhánh `dev` cho các tính năng *chung* và sửa đổi *tổng thể*.
- Khi muốn thay đổi của mình được merge vào `main`, tạo pull request và nhờ người khác trong team vào review request.
- Hai repository để làm việc chính là repo `server-side` và nhánh `client-side`.
- Xây dựng một tính năng nào quan trọng thì tạo nhánh riêng từ `dev` với quy tắc đặt tên là `<tên feature>-feature`. Hoàn thành tính năng đó thì merge vào `dev` rồi xóa nhánh feature đó đi hoặc giữ lại nếu còn tồn tại bug nào đó. 
- Khi có bug nặng, khó fix thì tạo thêm nhánh `fix-bug-x-in-y` từ nhánh mình **đang làm** với `x` là tên bug và `y` là tên nhánh. Sau khi đã kiểm chứng không còn xuất hiện bug, tiến hành merge vào nhánh **gốc** và xóa nhánh hiện tại đi.

- Nói thêm: [link](https://github.com/thu4n/trackr-app/issues/21#issuecomment-1538659063)

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

![img2](/documents/diagrams/system-architecture-diagram.png)

- Công nghệ sử dụng:

 1. IDE: Visual Studio 2019 hoặc 2022
 2. Ngôn ngữ sử dụng: C# (ngôn ngữ dùng chính), XAML , SQL.
 3. Framework sử dụng: Window Forms, ASP.NET Core
 4. Thư viện sử dụng: SignalR
 5. Network stack: Websocket (TCP), RESTful API HTTP request
 6. Loại project: Desktop application
 7. Database system: Azure SQL Database và SQL Server Express LocalDB
 8. Version control: Git

## Đặc tả database

![img3](/Database.png)

## Đặc tả các giao thức truyền thông trong ứng dụng

![img4](/documents/diagrams/network-stack.png)

- Đặc tả các giao thức:

  - Giao thức ở tầng Physical: Kết nối thông qua mạng Wifi hoặc mạng có dây
  - Giao thức ở tầng DataLink: nhận biết thông qua  chương trình Wireshark, phân tích gói tin có giao thức Ethernet
  - Giao thức ở tầng Network: Sử dụng địa chỉ Ipv4
  - Giao thức ở tầng Transport: Sử dụng giao thức TCP
  - Giao thức ở tầng Session: Sử dụng giao thức RPC có cơ chế hỗ trợ giao tiếp giữa hai tiến trình
  - Giao thức ở tầng Presentation: SSL, TLS dùng để xác thực danh tính
  - Giao thức ở tầng Application: DNS dùng để phân giải tên miền, kết nối kiểu HTTP và SMTP dùng để gửi mail
  
## Đặc tả Message Structure

![img5](/documents/diagrams/message-structure.png)


## Đặc tả luồng người dùng

![img10](/documents/diagrams/use-case-diagram.png)

### Tại màn hình đăng nhập

**Trường hợp 1**: Nếu người dùng đã đăng ký tài khoản, người dùng sẽ tiến hành đăng nhập bằng tài khoản và mật khẩu để vào giao diện chính dành riêng cho 3 loại người dùng.

**Trường hợp 2**: Nếu người dùng chưa đăng ký tài khoản, người dùng sẽ được điều hướng đến màn hình đăng ký tài khoản.

Tại giao diện dành riêng cho 3 loại người dùng:

#### Quản lý cửa hàng

- Sau khi đăng nhập, giao diện đầu tiên Quản lý cửa hàng thấy là Màn hình điều hướng bao gồm 3 cửa sổ: Đơn hàng, Nhân viên, Khách hàng.

- Tại cửa sổ Đơn hàng, Quản lý cửa hàng có thể xem danh sách tổng các đơn hàng đang hiện có. Nếu Quản lý cửa hàng nhấn vào một trong những Đơn hàng đang hiển thị hoặc nhập mã vận đơn trên thanh “Tra cứu đơn hàng”, Quản lý cửa hàng có thể thấy chi tiết quá trình vận đơn của đơn hàng; đồng thời, có thể thực hiện tác vụ chỉnh sửa, hoặc xóa đơn hàng.

- Tại cửa sổ Nhân viên, Quản lý cửa hàng có thể xem danh sách tổng các Nhân viên giao hàng đang làm việc cho cửa hàng. Nếu Quản lý cửa hàng nhấn vào một trong những Nhân viên đang hiển thị hoặc nhập mã nhân viên trên thanh “Tra cứu nhân viên”, Quản lý có thể thấy thông tin chi tiết cũng như những đơn hàng đang nhận giao của Nhân viên giao hàng; đồng thời, có thể thực hiện tác vụ chỉnh sửa, hoặc xóa nhân viên.

- Tại cửa sổ Khách hàng, Quản lý cửa hàng có thể xem danh sách tổng các Khách hàng đã đăng ký tài khoản trên ứng dụng Trackr!. Nếu Quản lý cửa hàng nhấn vào một trong những Khách hàng hoặc nhập mã khách hàng trên thanh “Tra cứu khách hàng”, Quản lý có thể thấy thông tin chi tiết cũng như những đơn hàng đã đặt của Khách hàng; đồng thời, có thể thực hiện tác vụ chỉnh sửa, hoặc xóa khách hàng.

#### Nhân viên giao hàng

- Sau khi đăng nhập, giao diện đầu tiên Nhân viên giao hàng nhìn thấy là Màn hình điều hướng bao gồm 2 cửa sổ: Đơn hàng cần giao, Đơn hàng đang giao.

- Tại cửa sổ Đơn hàng cần giao, Nhân viên giao hàng có thể nhấn chọn đơn hàng để bắt đầu giao.

- Tại cửa sổ Đơn hàng đang giao, Nhân viên giao hàng có thể xem danh sách tổng những đơn hàng mình đang giao. Nếu Nhân viên giao hàng nhấn vào một trong những đơn hàng đang hiển thị hoặc nhập mã vận đơn trên thanh “Tra cứu đơn hàng”, Nhân viên giao hàng có thể thấy chi tiết quá trình vận đơn của đơn hàng; đồng thời, có thể thực hiện tác vụ cập nhật vị trí và trạng thái đơn hàng theo thời gian thực.

#### Khách hàng

- Sau khi đăng nhập, giao diện đầu tiên Khách hàng nhìn thấy là Màn hình điều hướng bao gồm danh sách tổng những đơn hàng đã đặt.

- Nếu Khách hàng nhấn vào một trong những Đơn hàng đang hiển thị hoặc nhập mã vận đơn trên thanh “Tra cứu đơn hàng”, Khách hàng có thể theo dõi được chi tiết quá trình vận đơn của đơn hàng.  
