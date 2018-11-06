(function () {
    var app = angular.module("app");
    app.component("mathangList", {
        templateUrl:"~/App/Main/views/mathangs/Viewmathang.cshtml",
        controllerAs: "vm",
        controller: ['abp.services.app.mathang',controller]
    });
    function controller(mathangService){
        var vm = this;
        vm.users = [];
        function getmathang() {
            mathangService.listAll().then(function (result) {
                vm.users = result.data;
            });
        }
        getmathang();
    }
})();