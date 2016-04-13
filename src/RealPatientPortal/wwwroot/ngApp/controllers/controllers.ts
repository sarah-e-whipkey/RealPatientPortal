namespace RealPatientPortal.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
    }


    export class SecretController {
        public secrets;

        constructor($http: ng.IHttpService) {
            $http.get('/api/secrets').then((results) => {
                this.secrets = results.data;
            });
        }
    }

    export class MDDashboardController {

        public dashes = [

            {
                img: '../../images/patient.png',
                title: 'Register New Patient',
                state: 'register'
            },


            {
                img: '../../images/medRec.png',
                title: 'Patient List',
                state: 'patientList'
            },

            {
                img: '../../images/emailpic.png',
                title: 'Inbox',
                state: 'mdInbox'
            },

            {
                img: '../../images/calendar1.png',
                title: 'Scheduled Appointments',
                state: 'mdCalendar'
            },

            {
                img: '../../images/Simple-Pencil-300px.png',
                title: 'Edit Patient Record',
                state: 'editPatient'
            }
        ];

    }

    export class MedicalHistoryController {

        constructor(private $http: ng.IHttpService, private $state: ng.ui.IStateService) { }

    }

    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
