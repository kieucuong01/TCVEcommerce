function formatNum(number) {
    return String(number).replace(/(.)(?=(\d{3})+$)/g, '$1,');
}

function getRoles(zoneid) {
    $.ajax({
        url: '/Cash/ZoneChanged/' + zoneid,
        type: 'GET',
        dataType: 'json',
        beforeSend: function () {
            $('#roleWait').show();
            $('#RoleId').empty();
            $('#RoleId').append($('<option value>== Chọn Nhân vật ==</option>'));
            $('#RoleId').hide();
        },
        success: function (result) {
            $('#roleWait').hide();
            $.each(result, function () {
                $('#RoleId').append($('<option/>', {
                    value: this.roleid,
                    text: this.desc
                }));
            });
            $('#RoleId').show();
        },
        error: function (data) {
            $('#roleWait').hide();
            $('#RoleId').show();
        }
    });
}

function onZoneChanged() {
    zid = $('#ZoneId').val()
    if (zid > 0) {
        getRoles(zid);
    }
    else {
        $('#RoleId').empty();
        $('#RoleId').append($('<option value>== Chọn Nhân vật ==</option>'));
    }
}

$(function() {
    $('#ZoneId').change(function () {
        onZoneChanged();
    });
    $('.btn-yuanbao').click(function () {
        x = $(this).attr('data-content');
        $('#YuanBao').val(x);
        $('#cashValue').html(formatNum((x * 1000)));
    });
    $('#YuanBao').change(function () {
        x = $(this).val();
        if ($.isNumeric(x) && x > 0) {
            $('#cashValue').html(formatNum((x * 1000)));
        } else {
            $('#cashValue').html('0');
        }
    });
});
