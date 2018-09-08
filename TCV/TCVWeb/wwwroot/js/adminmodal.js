function formReset(form) {
    $('#submitWait').hide();
    $(form).find("button[type='submit']").show();

    $('#captcha').val('');
    $('.input-captcha').removeClass('state-success');
    $('#captchaImg').removeAttr('src').attr('src', '/Home/Captcha');
}

function formAjax(form) {
    $(form).submit(function () {
        if (!$(form).valid())
            return false;

        $(this).find("button[type='submit']").hide();
        $('#submitWait').show();

        $.ajax({
            url: $(this).attr("action"),
            type: $(this).attr("method"),
            data: $(this).serialize(),
            success: function (result) {
                formReset(form);
                if (result.code == 2) {
                    $('#formMessage').html(result.message);
                    $('#formMessage').removeClass('alert-success').addClass('alert-danger').removeClass('hidden');
                }
                else if (result.code == 1) {
                    if (result.message != null) {
                        $('#formMessage').html(result.message);
                        $('#formMessage').removeClass('alert-danger').addClass('alert-success').removeClass('hidden');
                    }
                    else {
                        if (result.returnUrl)
                            location.href = result.returnUrl;
                        else
                            location.reload();
                    }
                }
                else {
                    $('#modalContent').html(result);
                    $("#modalContainer").modal({ keyboard: true }, "show");
                    $("form").removeData("validator");
                    $("form").removeData("unobtrusiveValidation");
                    $.validator.unobtrusive.parse("form");
                    formAjax("#modalForm");
                }
            },
            error: function (data) {
                formReset(form);
                $('#formMessage').html('Có lỗi hệ thống, xin liên hệ CSKH.');
                $('#formMessage').removeClass('alert-success').addClass('alert-danger').removeClass('hidden');
            }
        });

        return false;
    });
}

function formOpen(href) {
    modalContent = $('#modalContent');
    modalContent.load(href, function () {
        $("#modalContainer").modal({ keyboard: true }, "show");
        $("form").removeData("validator");
        $("form").removeData("unobtrusiveValidation");
        $.validator.unobtrusive.parse("form");
        formAjax("#modalForm");
    });
}

function initModalForms() {
    $.ajaxSetup({ cache: false });
    $(document).on('click', '.modal-opener', function (e) {
        e.preventDefault();
        formOpen(this.href);
    });
    $(document).on('click', '.modal-closer', function (e) {
        e.preventDefault();
        $('#modalContainer').modal('hide');
    });
    $(document).on('click', '.modal-refresh', function (e) {
        e.preventDefault();
        location.reload();
    });
    $('#modalContainer').on('hidden.bs.modal', function (e) {
        $('#modalContent').html('');
    })
    $(document).on('click', '#CaptchaImg', function (e) {
        e.preventDefault();
        $('#CaptchaImg').removeAttr('src').attr('src', '/Home/Captcha');
    });
}

$(function () {
    initModalForms();
});
