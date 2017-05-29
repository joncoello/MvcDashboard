$('#calendar').datepicker();

var widgetElement = document.getElementById('this');
var widget = new WidgetComponent(widgetElement, {
    loadData: function (e) {
    }
});
WidgetManager.Instance.registerWidget(widget);