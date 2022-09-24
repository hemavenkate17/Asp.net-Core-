console.log("Code is executing")



$(document).ready(
    function() {
        $('#Check').click(function () {
            $.ajax({
                url: 'https://localhost:44391/api/Users/authenticate',
                dataType: 'json',
                type: 'post',
                contentType: 'application/json',
                data: JSON.stringify({
                    username: $('#username').val(),
                    password: $('#password').val(),

                }),
                processData: false,
                success: function (data, textStatus, jQxhr) {
                    var data1 = JSON.stringify(data.token);
                    $.ajax({
                        type: "Get",
                        url: "https://localhost:44391/api/Employees",
                        beforeSend: function (xhr) {
                            xhr.setRequestHeader('Authorization', 'Bearer '+ data1);
                        },
                        dataType: 'json',
                        success: function (result, status, xhr) {
                            alert("success");
                        },
                        error: function (xhr, status, error) {
                            alert("error");
                        }
                    });

                },
                error: function (data, jqXhr, textStatus, errorThrown) {
                    var data2 = JSON.stringify(data.responseJSON.message);
                    alert(data2)




                   
                }
            });

        })

    }
)