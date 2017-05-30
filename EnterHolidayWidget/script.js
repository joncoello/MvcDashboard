(function () {
    var dateInput = $('#this >> input[name="daterange"]');
    dateInput.daterangepicker({
        locale: {
            format: 'DD/MM/YYYY'
        }
    });
    $('#this > button').click(function () {
        $.post('http://localhost:1187/api/holiday', { dateRange: dateInput.val() }, function () {
            WidgetManager.Instance.refreshWidgets();
        });
    });
    var widgetElement = document.getElementById('this');
    var widget = new WidgetComponent(widgetElement, {
        loadData: function (e) {
        },
        saveCustomisation: function (customisation) {
        },
        restoreCustomisation: function (customisation) {
        }
    });
    WidgetManager.Instance.registerWidget(widget);
})();
