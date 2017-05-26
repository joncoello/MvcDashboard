$('#calendar').datepicker();

var widgetElement = document.getElementById('this');
var widget = new WidgetComponenet(widgetElement, {
    loadData: function (e) {
    }
});
WidgetManager.Instance.registerWidget(widget);