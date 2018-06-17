(function () {

    'use strict';

    angular
        .module("umbraco")
        .controller("NullableStringController", NullableStringController);

    NullableStringController.$inject = ['$scope'];

    function NullableStringController($scope) {

        var config = {
            defaultCheckboxState: $scope.model.config.defaultCheckboxState == '1',
            hideTextWhenNull: $scope.model.config.hideTextWhenNull == '1'
        };

        var textActive = function () { return $scope.model.value.checkbox; };

        // init value
        if (typeof $scope.model.value != 'object') { // handle non-standard save formats
            $scope.model.value = {
                checkbox: config.defaultCheckboxState,
                text: $scope.model.value // expecting null or string value
            };
        }

        // set working copy for the textbox
        if (!config.hideTextWhenNull || textActive()) {
            $scope.model.text = $scope.model.value.text;
        }

        $scope.checkboxChange = function () {
            if (config.hideTextWhenNull) {
                if (textActive()) {
                    $scope.model.text = $scope.model.value.text;
                } else {
                    $scope.model.value.text = $scope.model.text;
                    $scope.model.text = '';
                }
            }
        };

        $scope.$on("formSubmitting", function () {
            if (!config.hideTextWhenNull || textActive()) {
                $scope.model.value.text = $scope.model.text;
            }
        });

    }

})();
