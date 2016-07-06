$('#login').click(function () {
    var app_key = 'kid_BkgBNW78';
    var app_secret = 'fbcfe0a8b99e46c8b309d1b79916980c';
    var authorization = btoa(app_key + ':' + app_secret);

    var inputData = {
        username: $('#login-username').val(),
        password: $('#login-password').val()
    };

    $.ajax({
        method: 'POST',
        url: 'https://baas.kinvey.com/user/kid_BkgBNW78/login',
        headers: {'Authorization': 'Basic ' + authorization},
        data: JSON.stringify(inputData),
        contentType: 'application/json',
        success: function (data, status) {
            var token = data._kmd.authtoken;
            sessionStorage['authToken'] = token;
            console.log(sessionStorage.authToken);
            window.location.href = '../list-books/list-books.html';
        },
        error: function (data, status) {
            alert('Invalid username or password!');
        }
    })
});