(function () {

    var widgetElement: Element = document.getElementById('this');
    var widget: WidgetComponent = new WidgetComponent(widgetElement, {
        loadData: (e: Element) => {

            var dateInput = $('#this >> input[name="daterange"]');

            dateInput.daterangepicker({
                locale: {
                    format: 'DD/MM/YYYY'
                }
            });

            $('#this > button').click(function () {
                $.post('http://localhost:1187/api/holiday', { dateRange: dateInput.val() }, () => {
                    WidgetManager.Instance.refreshWidgets();
                })
            });

        },
        saveCustomisation: (customisation: { [id: string]: any }) => { },
        restoreCustomisation: (customisation: { [id: string]: any }) => { }
    });

    WidgetManager.Instance.registerWidget(widget);

})();