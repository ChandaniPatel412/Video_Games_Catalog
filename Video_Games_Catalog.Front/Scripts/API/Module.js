var app;
(function () {
	app = angular.module('APIModule', ['ui.router']);
	app.config(['$stateProvider', function ($stateProvider) {
		$stateProvider
			.state('catalog',
				{
					url: '',
					templateUrl: 'Catalog.html',
					controller: 'APIController'
				})
			.state('game',
				{
					url: '/game/:id',
					templateUrl: 'Edit.html',
					controller: 'APIController',
				});
	}]);

	app.directive('ngFiles', ['$parse', function ($parse) {

		function fn_link(scope, element, attrs) {
			var onChange = $parse(attrs.ngFiles);
			element.on('change', function (event) {
				onChange(scope, { $files: event.target.files });
			});
		};

		return {
			link: fn_link
		}
	}]);
})();   