function JQueryAjaxPost(form) {
    $.validator.unobtrusive.parse(form);
    if ($(form).valid()) {
        $.ajax({
            type: "POST",
            url: form.action,
            data: new FormData(form),
            success: function (response) {
                $("#firstTab").html(response);
            }
        });
    }
}

function Edit(url) {
    $.ajax({
        type: "GET",
        url: url,
        success: function (response) {
            $("#secondTab").html(response);
            $('ul.nav.nav-tabs a:eq(1)').html('Edit');
          
                $('ul.nav.nav-tabs a:eq(1)').tab('show');
        }
    });
}

function Delete(url) {
    $.ajax({
        type: "POST",
        url: url,
        success: function (response) {
        }
    });
}