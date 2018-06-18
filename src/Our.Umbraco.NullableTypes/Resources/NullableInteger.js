(function () {

    'use strict';

    angular
        .module("umbraco")
        .controller("NullableIntegerController", NullableIntegerController);

    NullableIntegerController.$inject = ['$scope'];

    function NullableIntegerController($scope) {

        var config = {
            defaultCheckboxState: $scope.model.config.defaultCheckboxState == '1',
            hideValueWhenNull: $scope.model.config.hideValueWhenNull == '1'
        };

        var notNull = function () { return $scope.model.value.checkbox; };

        // init value
        if (typeof $scope.model.value != 'object') { // handle non-standard save formats
            $scope.model.value = {
                checkbox: config.defaultCheckboxState,
                number: $scope.model.value // expecting null or integer (but this could be any value if migrating away from another data-type)
            };
        }

        // set working copy for the number field
        if (!config.hideValueWhenNull || notNull()) {
            $scope.model.number = $scope.model.value.number;
        }

        $scope.checkboxChange = function () {
            if (config.hideValueWhenNull) {
                if (notNull()) {
                    $scope.model.number = $scope.model.value.number;
                } else {
                    $scope.model.value.number = $scope.model.number;
                    $scope.model.number = '';
                }
            }
        };

        $scope.$on("formSubmitting", function () {
            if (!config.hideValueWhenNull || notNull()) {
                $scope.model.value.number = $scope.model.number;
            }
        });
    }

})();
