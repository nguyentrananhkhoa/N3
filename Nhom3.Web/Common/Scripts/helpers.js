var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('Nhom3');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);