(function () {

    'use strict';

    angular
        .module("umbraco")
        .controller("NullableStringController", NullableStringController);

    NullableStringController.$inject = ['$scope'];

    function NullableStringController($scope) {

        function init() {

            // restore or create default saved value
            $scope.model.value = $scope.model.value || {
                checkbox: $scope.model.config.defaultCheckboxState == '1',
                text: ''
            };

            // set working copy for the textbox
            if (!swapText() || textActive()) {
                $scope.model.text = $scope.model.value.text;
            }

            $scope.checkboxChange = function () { checkboxChange(); };

            $scope.$on("formSubmitting", formSubit);
        }

        // if the text should be hidden when in 'null mode'
        function swapText() { return !($scope.model.config.showTextWhenNull == '1'); }

        function textActive() { return $scope.model.value.checkbox; }

        function checkboxChange() {
            if (swapText()) {
                if (textActive()) {
                    // restore textbox value from saved
                    $scope.model.text = $scope.model.value.text;
                } else {
                    // set saved, and clear textbox
                    $scope.model.value.text = $scope.model.text;
                    $scope.model.text = '';
                }
            }
        }

        function formSubit() {

            if (!swapText() || textActive()) {
                $scope.model.value.text = $scope.model.text;
            }
        }

        init();
    }

})();
