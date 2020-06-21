app.controller('APIController', function ($scope, $state, $stateParams, APIService) {
	$scope.getAllGames = function () {
		var getGames = APIService.getGames();
		getGames.then(function (response) {
			$scope.games = response.data;
		}, function (error) {
			alert('Oops! Something went wrong while fetching the data.');
		});
	}

	$scope.getGameDetail = function () {
		var getGame = APIService.getGame($stateParams.id);
		getGame.then(function (response) {
			$scope.game = response.data;
		}, function (error) {
			alert('Oops! Something went wrong while fetching the data.');
		});
	}

	$scope.updateGame = function () {
		var update = APIService.updateGame($scope.game);
		update.then(function (response) {
			$state.go('catalog');
		}, function (error) {
			alert('Oops! Something went wrong while fetching the data.');
		});

	}

	var formdata = new FormData();
	$scope.getTheFiles = function ($files) {
		angular.forEach($files, function (value, key) {
			formdata.append(key, value);
		});
	};

	$scope.uploadFile = function () {
		var update = APIService.uploadFile(formdata);
		update.then(function (response) {
			$scope.game.GameImage = response.data;
			alert('Uploaded Successfully.');
		}, function (error) {
			alert('Oops! Something went wrong while fetching the data.');
		});

	}
});