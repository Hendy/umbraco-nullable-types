(function () {

    'use strict';

    angular
        .module("umbraco")
        .controller("NullableIntegerController", NullableIntegerController);

    NullableIntegerController.$inject = ['$scope'];

    function NullableIntegerController($scope) {

        $scope.model.value = $scope.model.value || '';

    }

})();
