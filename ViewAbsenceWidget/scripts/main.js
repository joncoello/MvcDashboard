(function () {
    var widgetElement1 = document.getElementById('this');
    var widget1 = new WidgetComponent(widgetElement1, {
        loadData: getHolidayData,
        saveCustomisation: function (customisation) {
            // save currently selected employee id
            customisation['selectedEmployeeID'] = 27;
        },
        restoreCustomisation: function (customisation) {
            // get employee id from customisation or use default
            var defaultEmployeeID = -1;
            var employeeID = customisation['selectedEmployeeID'] === undefined ? defaultEmployeeID : customisation['selectedEmployeeID'];
        }
    });
    function getHolidayData(e) {
        $.get('http://localhost:1187/api/holiday', function (data) {
            console.log(e);
            $(e).empty();
            console.log(data);
            var year = 2017;
            var days = [
                'M', 'T', 'W', 'T', 'F', 'S', 'S'
            ];
            var months = [
                'January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'
            ];
            $(e).append('<table>');
            $('table', e).addClass('table table-bordered');
            $('table', e).append('<thead>');
            $('table > thead', e).append('<tr>');
            $('table > thead > tr', e).append('<th>Month');
            for (var w = 0; w < 6; w++) {
                for (var i = 0; i < 7; i++) {
                    $('table > thead > tr', e).append('<th class="daycol">' + days[i]);
                }
            }
            $('table', e).append('<tbody>');
            for (var i = 0; i < 12; i++) {
                $('table > thead', e).append('<tr>');
                $('table > thead > tr', e).last().append('<td>' + months[i]);
                // first day of month
                var startDate = new Date(year + '-' + (i + 1) + '-1');
                var startDay = startDate.getDay() == 0 ? 7 : startDate.getDay();
                for (var d = 0; d < (startDay - 1); d++) {
                    $('table > thead > tr', e).last().append('<td class="nonday">');
                }
                for (var d = 0; d < new Date(year, (i + 1), 0).getDate(); d++) {
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
                    $('table > thead > tr', e).last().append(td + (d + 1));
                }
                var remaining = 42 - (new Date(year, (i + 1), 0).getDate()) - (startDay - 1);
                for (var d = 0; d < remaining; d++) {
                    $('table > thead > tr', e).last().append('<td class="nonday">');
                }
            }
        });
    }
    WidgetManager.Instance.registerWidget(widget1);
})();
