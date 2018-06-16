(function () {

    'use strict';

    angular
        .module("umbraco")
        .controller("NullableStringController", NullableStringController);

    NullableStringController.$inject = ['$scope'];

    function NullableStringController($scope) {

        var hidden;

        $scope.model.value = $scope.model.value || {
            checkbox: false,
            text: ''
        };

        hidden = $scope.model.value.text;

        $scope.checkboxChange = function () {

            if ($scope.model.value.checkbox) {
                $scope.model.value.text = hidden;
            } else {
                hidden = $scope.model.value.text;
                $scope.model.value.text = '';
            }
        };

    }

})();
