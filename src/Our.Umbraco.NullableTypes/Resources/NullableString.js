(function () {

    'use strict';

    angular
        .module("umbraco")
        .controller("NullableStringController", NullableStringController);

    NullableStringController.$inject = ['$scope'];

    function NullableStringController($scope) {

        $scope.model.value = $scope.model.value || {
            checkbox: $scope.model.config.defaultCheckboxState == '1',
            text: ''
        };

        //textNulled = $scope.model.value.text;

        //if ($scope.model.config.hideText) {

        //    $scope.checkboxChange = function () {
        //        if ($scope.model.value.checkbox) {
        //            $scope.model.value.text = textNulled;
        //        } else {
        //            textNulled = $scope.model.value.text;
        //            $scope.model.value.text = '';
        //        }
        //    };

        //    // on save, swap back any nulled text
        //}

    }

})();
