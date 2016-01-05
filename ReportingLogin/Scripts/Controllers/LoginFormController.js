var LoginFormController = function ($scope, LoginFormFactory) {
        $scope.IsLogedIn = false;
        $scope.Message = '';
        $scope.Submitted = false;
        $scope.IsFormValid = false;

        $scope.LoginData = {
            Login: '',
            Password: ''
        };

        $scope.$watch('f1.$valid', function(newVal) {
            $scope.IsFormValid = newVal;
        });

        $scope.Login = function () {
            $scope.Submitted = true;
            if ($scope.IsFormValid) {
                LoginFormFactory.GetUser($scope.LoginData).then(function(d) {
                    if (d.data.Login != null) {
                        $scope.IsLogedIn = true;
                        window.location = ('/Home/Welcome');
                    } else {
                        window.location = ('/Home/Fail');
                    }
                });
            }
        };
    }
    
