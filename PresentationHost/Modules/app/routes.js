mainApp.config(function ($routeProvider) {
    $routeProvider.when("/books", {
        templateUrl: "/Modules/bookGrid/View/Grid.html",
        controller:"bookController",
        displayInMenu: true,
        title: "داشبورد",
        parent: "میزکار"

    })
});