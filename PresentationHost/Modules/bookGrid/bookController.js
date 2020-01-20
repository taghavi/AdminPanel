mainApp.controller("bookController",['$http', '$scope',  function ($http, $scope) {

    //$scope.gridOptions = {
    //    data: [],
    //    urlSync: true
    //};
    //var ctrl = this;

    //this.displayed = [];

    //this.callServer = function callServer(tableState) {

    //    ctrl.isLoading = true;

    //    var pagination = tableState.pagination;

    //    var start = pagination.start || 0;     // This is NOT the page number, but the index of item in the list that you want to use to display the table.
    //    var number = pagination.number || 10;  // Number of entries showed per page.

    //    service.getPage(start, number, tableState).then(function (result) {
    //        ctrl.displayed = result.data;
    //        tableState.pagination.numberOfPages = result.numberOfPages;//set the number of pages so the pagination can update
    //        ctrl.isLoading = false;
    //        debugger;
    //    });
    //};

    //$scope.itemsByPage = 10;

    $scope.gridSource = new kendo.data.DataSource({
        transport: {
            read: function (options) {
              return  $http({
                    method: 'GET',
                    url: 'http://localhost:19947/api/values'
                }).then(function (response) {
                    debugger;
                    options.success(response.data);
                    
                    //$scope.rowCollection = response.data;
                }).then(function error(er){
                    
                });
            }
        },
      
        page: 1,
        pageSize: 5,
        serverPaging: false,
        serverFiltering: false,
        serverSorting: false
    });


    
}]);