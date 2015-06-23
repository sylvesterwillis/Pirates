var app = angular.module('main', []).
controller('DemoCtrl', function ($scope, $http) {
	$scope.getGold = function () {
		var pirateCount = $('#pirateCount').val();
		var resultDiv = $('#result');

		if (!$.isNumeric(pirateCount)) {
			resultDiv.html('Please enter a number.');
		}
		else {
			var url = '/api/pirates/' + pirateCount;
			console.log(url);
			resultDiv.html('Waiting for result...');

			$http({
				method: 'GET',
				url: url
			})
			.success(function (data) {
				resultDiv.html(data);
			})
			.error(function (data, status) {
				resultDiv.html(data);
			});
		}
	};
});