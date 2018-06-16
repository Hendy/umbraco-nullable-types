(function () {

    'use strict';

    angular
        .module("umbraco")
        .controller("NullableStringController", NullableStringController);

    NullableStringController.$inject = ['$scope'];

    function NullableStringController($scope) {

        // restore or create default saved value
        $scope.model.value = $scope.model.value || {
            checkbox: $scope.model.config.defaultCheckboxState == '1',
            text: ''
        };

        // working vars
        $scope.model.text = $scope.model.value.text;
        var textNulled = $scope.model.value.text;

        $scope.checkboxChange = function () {
            if (!($scope.model.config.showTextWhenNull == '1')) { // if text should be hidden

                if ($scope.model.value.checkbox) {
                    $scope.model.text = textNulled;
                } else {
                    textNulled = $scope.model.text;
                    $scope.model.text = '';
                }
            }
        };
        
        // on save set value from working var
        $scope.$on("formSubmitting", function () {



            $scope.model.value.text = $scope.model.text;
        });
    }

})();
