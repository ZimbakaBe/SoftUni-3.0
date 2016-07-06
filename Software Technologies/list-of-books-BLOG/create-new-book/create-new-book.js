$('#create-new-book').click(function () {
    var username = 'viko1', password = '1234';
    var authorization = btoa(username + ':' + password);
    var title = $('#title').val(), author = $('#author').val(), description = $('#description').val();

    var inputData = {
        title: title,
        author: author,
        description: description
    };

    if(title !== '' && author !== '' && description !== '') {
        $.ajax({
            method: 'POST',
            url: 'https://baas.kinvey.com/appdata/kid_BkgBNW78/books',
            headers: {'Authorization' : 'Basic ' + authorization},
            contentType: 'application/json',
            data: JSON.stringify(inputData),
            success: function () {
                alert('Book was created successfully');
            },
            erro: function () {
                alert('Book couldn\'t be created');
            }
        })
    } else {
        alert('Error creating book: all fields are required.')
    }
});