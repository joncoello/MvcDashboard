// main componenet to be wrapped around widget element
var WidgetComponenet = (function () {
    function WidgetComponenet(element, settings) {
        this.element = element;
        this.settings = settings;
        settings.loadData(element);
    }
    return WidgetComponenet;
}());
// widget settings including event callbacks
var WidgetSettings = (function () {
    function WidgetSettings() {
    }
    return WidgetSettings;
}());
// singleton for managing widgets on a page
// widgets register themselves then can be centrally managed
var WidgetManager = (function () {
    function WidgetManager() {
        this._widgets = new Array();
    }
    Object.defineProperty(WidgetManager, "Instance", {
        get: function () {
            return this._instance || (this._instance = new this());
        },
        enumerable: true,
        configurable: true
    });
    // add a widget to the collection
    WidgetManager.prototype.registerWidget = function (widget) {
        this._widgets.push(widget);
    };
    WidgetManager.prototype.refreshWidgets = function () {
        this._widgets.forEach(function (w) {
            w.settings.loadData(w.element);
        });
    };
    WidgetManager.prototype.getLayout = function () {
        var widgetsInfo = [];
        this._widgets.forEach(function (w) {
            var e = w.element.parentElement.parentElement;
            var name = w.element.className;
            var x = e.getAttribute('data-gs-x').valueOf();
            var y = e.getAttribute('data-gs-y').valueOf();
            var width = e.getAttribute('data-gs-width').valueOf();
            var height = e.getAttribute('data-gs-height').valueOf();
            widgetsInfo.push("name:" + name + ";x:" + x + ";y:" + y + ";width:" + width + ";height:" + height);
        });
        return widgetsInfo.join(",");
    };
    return WidgetManager;
}());
