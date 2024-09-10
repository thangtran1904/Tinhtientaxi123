$(document).ready(function () {
    function gui_api() {
        var data = {
            GiaMoiKm: $('#TextBox1').val(),
            QuangDuong: $('#TextBox2').val(),
        };

        if (isNaN(data.GiaMoiKm) || parseFloat(data.GiaMoiKm) <= 0) {
            $('#ketqua_web').html('Hãy nhập giá mỗi km là số dương!');
            $('#TextBox1').focus();
            return;
        }

        if (isNaN(data.QuangDuong) || parseFloat(data.QuangDuong) <= 0) {
            $('#ketqua_web').html('Hãy nhập quãng đường đã đi là số dương!');
            $('#TextBox2').focus();
            return;
        }

        $('#ketqua_web').html('Đang gửi API tính toán ...');

        $.post("api.aspx",
            data,
            function (kq, status) {
                if (status === "success") 
                    try {
                        var json = JSON.parse(kq);

                        if (json.ok) {
                            var thanhtien = json.msg;
                            $('#ketqua_web').html(`Tổng tiền taxi: ${thanhtien} VND`);
                        } else {
                            $('#ketqua_web').html(json.msg);
                        }
                    } catch (e) {
                        $('#ketqua_web').html(kq);
                    }
                } else {
                    $('#ketqua_web').html('Đã xảy ra lỗi khi gửi yêu cầu.');
                }
            }
        );
    }
    $("#Button1").click(function () {
        gui_api();
    });
});
