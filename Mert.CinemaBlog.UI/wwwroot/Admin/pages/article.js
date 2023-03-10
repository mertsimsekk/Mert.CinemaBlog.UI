

app.controller("ArticleController", function ($scope, $http) {

    $scope.GetArticleList = function () {
        $http({
            method: "GET",
            headers: GetHeader(),
            url: "https://localhost:7165/api/Article/GetAll"
        }).then(function (response) {
            $scope.articleList = response.data;
        });
    }

    $scope.GetArticleList();

  
  

    $scope.ArticleDelete = function (id) {
        $http({
            method: "GET",
            headers: GetHeader(),
            url: "https://localhost:7165/api/Article/Delete?articleId=" + id
        }).then(function (response) {
            alert("Makale silinmiştir.");
            $scope.GetArticleList();
        });
    }

    $scope.ArticleActive = function (id) {
        $http({
            method: "PUT",
            headers: GetHeader(),
            url: "https://localhost:7165/api/Article/SetActive?articleId=" + id
        }).then(function (response) {
            alert("Makale aktifleştirildi.");
            $scope.GetArticleList();
        });
    }

});