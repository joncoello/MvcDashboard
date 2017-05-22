(function () {

    $.get('http://localhost:1187/api/holiday', function (data) {
        console.log(data);
    });
    

    var year = 2017;

    var days = [
        'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'
    ];

    var months = [
        'January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'
    ];

    $('#myAbsence').append('<table>');
    $('#myAbsence > table').addClass('table table-bordered');
    $('#myAbsence > table').append('<thead>');

    $('#myAbsence > table > thead').append('<tr>');
    $('#myAbsence > table > thead > tr').append('<th>Month');
    for (var w = 0; w < 6; w++) {
        for (var i = 0; i < 7; i++) {
            $('#myAbsence > table > thead > tr').append('<th>' + days[i]);
        }
    }

    $('#myAbsence > table').append('<tbody>');

    for (var i = 0; i < 12; i++) {
        $('#myAbsence > table > thead').append('<tr>');
        $('#myAbsence > table > thead > tr').last().append('<td>' + months[i]);

        // first day of month
        var startDate = new Date(year + '-' + (i + 1) + '-1');

        var startDay = startDate.getDay() == 0 ? 7 : startDate.getDay();

        for (var d = 0; d < (startDay - 1) ; d++) {
            $('#myAbsence > table > thead > tr').last().append('<td class="nonday">');
        }

        for (var d = 0; d < new Date(year, (i + 1), 0).getDate(); d++) {

            var dow = new Date(year + '-' + (i + 1) + '-' + (d + 1)).getDay();

            var td = '<td>';
            if (dow === 0 || dow === 6) {
                td = '<td class="weekend">';
            }

            $('#myAbsence > table > thead > tr').last().append(td + (d + 1));

        }

        var remaining = 42 - (new Date(year, (i + 1), 0).getDate()) - (startDay - 1);

        for (var d = 0; d < remaining ; d++) {
            $('#myAbsence > table > thead > tr').last().append('<td class="nonday">');
        }

    }

})();