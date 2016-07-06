$(document).ready(function () {
    var username = 'viko1', password = '1234';
    var authorization = btoa(username + ':' + password);
   $.ajax({
       method: 'GET',
       url: 'https://baas.kinvey.com/appdata/kid_BkgBNW78/books',
       headers: {'Authorization' : 'Basic ' + authorization},
       success: function (data, status) {
           for (var i = 0; i < data.length; i++) {
               var title = data[i].title;
               var author = data[i].author;
               var description = data[i].description;
               
               var tr = $('<tr>' +
                            '<td>' + title + '</td>' +
                            '<td>' + author + '</td>' +
                            '<td>' + description + '</td>' +
                        '</tr>');

               $('.list-books').append(tr);
           }
       },
       error: function () {
           
       }
   })
});