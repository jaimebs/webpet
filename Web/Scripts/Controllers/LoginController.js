var appLogin = angular.module("appLogin", []);
appLogin.controller("Login", function($scope,$http,$window) {
    $scope.Logar = function (usuario) {
        $http.post("/Login/Logar", usuario).success(function(dados) {
            if (dados.retorno) {
                $window.location.href = "/Home";
            } else {
                swal("Aviso!", "Login ou Senha inváldo!", "warning");
            }
        });
    };
});