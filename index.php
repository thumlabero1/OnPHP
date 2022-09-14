<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <title>Quản lý sinh viên</title>
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>
<div class="container">
<h3>LỚP</h3>
 <div class="list-group">
 <?php
 // Kết nối CSDL
 $conn = mysqli_connect("localhost", "root", "", "qlsv");
 if (!$conn){
 die("Lỗi kết nối: ". mysqli_connect_error());
 }
 // Thực hiện truy vấn
 $sql = "SELECT * FROM lop";
 $lop = mysqli_query($conn, $sql);
 // Duyệt và xuất kết quả
 if(mysqli_num_rows($lop) > 0){
 while($l = mysqli_fetch_assoc($lop)){
 echo "<a class=\"list-group-item\" href=\"\">" . $l["lop"] . "</a>&nbsp;";
 }
 }
 ?>
 </div>
 <h3>DANH SÁCH SINH VIÊN</h3>
 <table class="table table-hover">
 <tr><th>MSSV</th><th>Họ tên</th><th>Email</th><th>Thao tác</th></tr>
 <?php
 $sql = "select * from sinhvien";
 $sinhvien = mysqli_query($conn, $sql);
 if(mysqli_num_rows($sinhvien) > 0){
 while($sv = mysqli_fetch_assoc($sinhvien)){
 echo "<tr>";
 echo "<td>". $sv["mssv"] ."</td>";
 echo "<td>". $sv["hoten"] . "</td>";
 echo "<td>". $sv["email"] . "</td>";
 echo "<td><a href=\"\">Sửa</a> | <a href=\"\">Xóa</a></td>";
 echo "</tr>";
 }
 }
 ?>
 </table>
</div>
</body>
</html>