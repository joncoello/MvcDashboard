var WidgetComponenet = (function () {
    function WidgetComponenet(element, settings) {
        this.element = element;
        this.settings = settings;
        settings.loadData(element);
    }
    return WidgetComponenet;
}());
var WidgetSettings = (function () {
    function WidgetSettings() {
    }
    return WidgetSettings;
}());
var WidgetManager = (function () {
    function WidgetManager() {
        this._widgets = new Array();
    }
    Object.defineProperty(WidgetManager.prototype, "Instance", {
        get: function () {
            return this._instance || (this._instance = new WidgetManager());
        },
        enumerable: true,
        configurable: true
    });
    // add a widget to the collection
    WidgetManager.prototype.registerWidget = function (widget) {
        this._widgets.push(widget);
    };
    WidgetManager.prototype.RefreshWidgets = function () {
        this._widgets.forEach(function (w) {
            w.settings.loadData(w.element);
        });
    };
    return WidgetManager;
}());
