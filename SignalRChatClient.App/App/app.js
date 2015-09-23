var app = angular.module('chirpchirp', [
  'ui.router'
]);

app.config(function ($urlRouterProvider) {
  $urlRouterProvider.when("", "/")
                    .otherwise(() => alert('not found'));
});

function addAngularState(id, url, title, controller, template) {
  template = template || (id + ".tpl.html");

  var stateConfig = {
    url: url,
    templateUrl: template,
    controller: controller,
    controllerAs: "vm",
    params: { title: title },
    bindToController: true
  };

  app.config(function ($stateProvider) {
    $stateProvider.state(id, stateConfig);
  });
}