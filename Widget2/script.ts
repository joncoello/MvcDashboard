$('#calendar').datepicker();

var widgetElement = document.getElementById('this');
var widget = new WidgetComponent(widgetElement, {
    loadData: function (e) {
    },
    saveCustomisation: (customisation: { [id: string]: any }): void => { },
    restoreCustomisation: (customisation: { [id: string]: any }): void => { }
});
WidgetManager.Instance.registerWidget(widget);