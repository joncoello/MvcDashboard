(function () {

    $('#this').find('.calendar').first().datepicker();

    var widgetElement = document.getElementById('this');
    var widget = new WidgetComponent(widgetElement, {
        loadData: function (e) {
        },
        saveCustomisation: (customisation: { [id: string]: any }) => { },
        restoreCustomisation: (customisation: { [id: string]: any }) => { }
    });
    WidgetManager.Instance.registerWidget(widget);

})();