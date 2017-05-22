(function () {

    var dateInput = $('#this >> input[name="daterange"]');

    dateInput.daterangepicker({
        locale: {
            format: 'DD/MM/YYYY'
        }
    });

    $('#this > button').click(function () {
        $.post('http://localhost:1187/api/holiday', { dateRange: dateInput.val() })
    });



})();