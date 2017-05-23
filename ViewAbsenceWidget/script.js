(function () {

    function getData() {
        $.get('http://localhost:1187/api/holiday', function (data) {

            $('#myAbsence').empty();

            console.log(data);

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

                for (var d = 0; d < new Date(year, (i + 1), 0).getDate() ; d++) {

                    var currentDate = new Date(year + '-' + (i + 1) + '-' + (d + 1));
                    var dow = currentDate.getDay();

                    var yearString = currentDate.getFullYear().toString();
                    var monthString = (currentDate.getMonth() + 1).toString();
                    if (monthString.length == 1) {
                        monthString = "0" + monthString;
                    }
                    var dayString = currentDate.getDate().toString();
                    if (dayString.length == 1) {
                        dayString = "0" + dayString;
                    }

                    var currentDateString = yearString + '-' + monthString + '-' + dayString;
                    var isHoliday = false;
                    if (data.length > 0) {
                        var nextDate = data[0];
                        if (nextDate === currentDateString) {
                            isHoliday = true;
                            data.splice(0, 1);
                        }
                    }


                    var td = '<td>';
                    if (dow === 0 || dow === 6) {
                        td = '<td class="weekend">';
                    }
                    if (isHoliday) {
                        td = '<td class="holiday">';
                    }

                    $('#myAbsence > table > thead > tr').last().append(td + (d + 1));

                }

                var remaining = 42 - (new Date(year, (i + 1), 0).getDate()) - (startDay - 1);

                for (var d = 0; d < remaining ; d++) {
                    $('#myAbsence > table > thead > tr').last().append('<td class="nonday">');
                }

            }

        });
    }

    getData();

    $('#absenceRefresh').click(function () {
        getData();
    });

    $('#myAbsence > table > thead > tr > th').first().click(function () {
        getData();
    });

})();