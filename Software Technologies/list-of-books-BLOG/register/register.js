$('#login').click(function() {
    var app_key = 'kid_BkgBNW78';
    var app_secret = 'fbcfe0a8b99e46c8b309d1b79916980c';
    var authorization = btoa(app_key + ':' + app_secret);
    var username = $('#register-username').val();
    var password = $('#register-password').val();

    var inputData = {
        username: username,
        password: password
    };

    if (username !== '' && password !== '') {
        $.ajax({
            method: 'POST',
            url: 'https://baas.kinvey.com/user/kid_BkgBNW78/',
            headers: {'Authorization' : 'Basic ' + authorization},
            data: JSON.stringify(inputData),
            contentType: 'application/json',
            success: function(data, status) {
                var token = data._kmd.authtoken;
                sessionStorage['authToken'] = token;
                window.location.href = '../list-books/list-books.html'
            },
            error: function(data, status) {

            }
        });
    } else {
        alert('Invalid username or password');
    }


});