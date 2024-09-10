$(document).ready(function () {
    function gui_api() {
        var data = {
            GiaMoiKm: $('#TextBox1').val(),
            QuangDuong: $('#TextBox2').val(),
        };
        if (isNaN(data.GiaMoiKm)) {
            $('#ketqua_wed').html('Hãy nhập giá mỗi km là số dương! ');
            $('#TextBox1').focus();
            return;
        }
        if (isNaN(data.QuangDuong)) {
            $('#ketqua_wed').html('Hãy nhập quãng đường đã đi là số dương! ');
            $('#TextBox2').focus();
            return;
        }
        $('#ketqua_web').html('Đang gửi API tính toán ...');
        $.post("api.aspx",
            data,
            function (kq, status) {
                if (status == "success") {
                    $('#ketqua_web').html(kq);
                }
            });
    }
    $("#Button1").click(function () {
        gui_api();
    });
});