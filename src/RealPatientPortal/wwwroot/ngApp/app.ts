namespace RealPatientPortal {

    angular.module('RealPatientPortal', ['ui.router', 'ngResource', 'ui.bootstrap']).config((
        $stateProvider: ng.ui.IStateProvider,
        $urlRouterProvider: ng.ui.IUrlRouterProvider,
        $locationProvider: ng.ILocationProvider
    ) => {
        // Define routes
        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: '/ngApp/views/home.html',
                controller: RealPatientPortal.Controllers.HomeController,
                controllerAs: 'controller'
            })
            .state('secret', {
                url: '/secret',
                templateUrl: '/ngApp/views/secret.html',
                controller: RealPatientPortal.Controllers.SecretController,
                controllerAs: 'controller'
            })
            .state('login', {
                url: '/login',
                templateUrl: '/ngApp/views/login.html',
                controller: RealPatientPortal.Controllers.LoginController,
                controllerAs: 'controller'
            })
            .state('mdlogin', {
                url: '/mdlogin',
                templateUrl: '/ngApp/views/mdLogin.html',
                controller: RealPatientPortal.Controllers.MDLoginController,
                controllerAs: 'controller'
            })
            .state('mdDash', {
                url: '/mdDashboard',
                templateUrl: '/ngApp/views/mdDashboard.html',
                controller: RealPatientPortal.Controllers.MDDashboardController,
                controllerAs: 'controller'
            })
            .state('register', {
                url: '/register',
                templateUrl: '/ngApp/views/register.html',
                controller: RealPatientPortal.Controllers.RegisterController,
                controllerAs: 'controller'
            })
            .state('medHistory', {
                url: '/medHistory',
                templateUrl: '/ngApp/views/medicalHistory.html',
                controller: RealPatientPortal.Controllers.MedicalHistoryController,
                controllerAs: 'controller'
            })
            .state('externalRegister', {
                url: '/externalRegister',
                templateUrl: '/ngApp/views/externalRegister.html',
                controller: RealPatientPortal.Controllers.ExternalRegisterController,
                controllerAs: 'controller'
            }) 
            .state('about', {
                url: '/about',
                templateUrl: '/ngApp/views/about.html',
                controller: RealPatientPortal.Controllers.AboutController,
                controllerAs: 'controller'
            })
            .state('notFound', {
                url: '/notFound',
                templateUrl: '/ngApp/views/notFound.html'
            });

        // Handle request for non-existent route
        $urlRouterProvider.otherwise('/notFound');

        // Enable HTML5 navigation
        $locationProvider.html5Mode(true);
    });

    
    angular.module('RealPatientPortal').factory('authInterceptor', (
        $q: ng.IQService,
        $window: ng.IWindowService,
        $location: ng.ILocationService
    ) =>
        ({
            request: function (config) {
                config.headers = config.headers || {};
                config.headers['X-Requested-With'] = 'XMLHttpRequest';
                return config;
            },
            responseError: function (rejection) {
                if (rejection.status === 401 || rejection.status === 403) {
                    $location.path('/login');
                }
                return $q.reject(rejection);
            }
        })
    );

    angular.module('RealPatientPortal').config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptor');
    });

    

}
