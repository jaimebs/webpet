app.controller("UsuarioIndex", function ($scope, $http, $window) {
    $scope.Usuarios = [];

    $http.get("/Usuario/RetornarUsuarios").success(function(dados) {
        $scope.Usuarios = dados;
    });

    $scope.Novo = function() {
        $window.location.href = "/Usuario/Novo";
    };

    $scope.Editar = function (id) {
        $window.location.href = "/Usuario/Editar/"+id;
    };

});

app.controller("UsuarioNovo_Editar", function ($scope, $http, $window) {
    $scope.Usuarios = [];
    $scope.usuario = {};
    var paramentro = GetParametro();

    $http.get("/Usuario/RetornarUsuarios").success(function (dados) {
        $scope.Usuarios = dados;
    });

    $scope.Novo = function () {
        $window.location.href = "/Usuario/Novo";
    };

    $scope.Voltar = function () {
        $window.location.href = "/Usuario";
    };

    $scope.Salvar = function (usuario) {
        $http.post("/Usuario/Salvar", usuario).success(function(dados) {
            if (dados.retorno) {
                swal("Bom trabalho!", dados.mensagem, "success");
                //$scope.Voltar();
            } else {
                swal("Erro!", dados.mensagem, "error");
            }
        });
    };

    if (!angular.equals("Novo", paramentro)) {
        $http.get("/Usuario/RetornaUsuario/", { params: { id: paramentro } }).success(function (dados) {
            $scope.usuario = dados;
        });
    }

});

function GetParametro() {
    var url = document.location.href.split("/");
    var parametro = url[url.length - 1];
    return parametro;
}