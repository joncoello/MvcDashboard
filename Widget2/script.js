(function () {
    $('#this').find('.calendar').first().datepicker();
    var widgetElement = document.getElementById('this');
    var widget = new WidgetComponent(widgetElement, {
        loadData: function (e) {
        },
        saveCustomisation: function (customisation) { },
        restoreCustomisation: function (customisation) { }
    });
    WidgetManager.Instance.registerWidget(widget);
})();
