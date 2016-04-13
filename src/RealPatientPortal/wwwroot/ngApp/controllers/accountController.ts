namespace RealPatientPortal.Controllers {

    export class AccountController {
        public externalLogins;

        public getUserName() {
            return this.accountService.getUserName();
        }

        public getClaim(type) {
            return this.accountService.getClaim(type);
        }

        public isLoggedIn() {
            return this.accountService.isLoggedIn();
        }

        public logout() {
            this.accountService.logout();
            this.$location.path('/');
        }

        public getExternalLogins() {
            return this.accountService.getExternalLogins();
        }

        constructor(private accountService: RealPatientPortal.Services.AccountService, private $location: ng.ILocationService) {
            this.getExternalLogins().then((results) => {
                this.externalLogins = results;
            });
        }
    }

    angular.module('RealPatientPortal').controller('AccountController', AccountController);


    export class LoginController {
        public loginUser;
        public validationMessages;

        public login() {
            this.accountService.login(this.loginUser).then(() => {
                this.$location.path('/');
            }).catch((results) => {
                this.validationMessages = results;
            });
        }

        constructor(private accountService: RealPatientPortal.Services.AccountService, private $location: ng.ILocationService) { }
    }

    export class MDLoginController {
        public loginUser;
        public validationMessages;

        public login() {

            this.accountService.login(this.loginUser).then(() => {
                this.$location.path('/mdDashboard');
            }).catch((results) => {
                this.validationMessages = results;
            });
        }

        constructor(private accountService: RealPatientPortal.Services.AccountService, private $location: ng.ILocationService) { }
    }


    export class RegisterController {
        public registerUser;
        public validationMessages;
        public race = [
            { a: 'American Indian or Alaskan Native' },
            { b: 'Asian' },
            { c: 'Black or African American' },
            { d: 'Native Hawaiian or Other Pacific Islander' },
            { e: 'White' }
        ];

        public register() {
            this.accountService.register(this.registerUser).then(() => {
                this.$location.path('/medHistory');
            }).catch((results) => {
                this.validationMessages = results;
            });
        }

        constructor(private accountService: RealPatientPortal.Services.AccountService, private $location: ng.ILocationService) { }
    }





    export class ExternalRegisterController {
        public registerUser;
        public validationMessages;

        public register() {
            this.accountService.registerExternal(this.registerUser.email)
                .then((result) => {
                    this.$location.path('/');
                }).catch((result) => {
                    this.validationMessages = result;
                });
        }

        constructor(private accountService: RealPatientPortal.Services.AccountService, private $location: ng.ILocationService) {}

    }

    export class ConfirmEmailController {
        public validationMessages;

        constructor(
            private accountService: RealPatientPortal.Services.AccountService,
            private $http: ng.IHttpService,
            private $stateParams: ng.ui.IStateParamsService,
            private $location: ng.ILocationService
        ) {
            let userId = $stateParams['userId'];
            let code = $stateParams['code'];
            accountService.confirmEmail(userId, code)
                .then((result) => {
                    this.$location.path('/');
                }).catch((result) => {
                    this.validationMessages = result;
                });
        }
    }

}
