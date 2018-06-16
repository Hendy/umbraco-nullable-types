(function () {

    'use strict';

    angular
        .module("umbraco")
        .controller("NullableBooleanController", NullableBooleanController);

    NullableBooleanController.$inject = ['$scope'];

    function NullableBooleanController($scope) {

        $scope.model.value = $scope.model.value || '';

    }

})();
