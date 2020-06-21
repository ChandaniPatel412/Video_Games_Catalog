app.service("APIService", function ($http) {
	this.getGames = function () {
		return $http.get("http://localhost:51751/Api/Game");
	}

	this.getGame = function (id) {
		return $http.get("http://localhost:51751/Api/Game/" + id);
	}

	this.updateGame = function (data) {
		return $http.put("http://localhost:51751/Api/Game", data);
	}

	this.uploadFile = function (formdata) {
		var configs = {
			headers: { 'Content-Type': undefined },
			transformRequest: function (data) {
				return formdata;
			}
		};

		return $http.post("http://localhost:51751/Api/File", formdata, configs);
	}
});  