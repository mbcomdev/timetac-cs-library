# TimeTac Client Library

TimeTac Client Library is a thin wrapper for client to make api request. For more information please visit the TimeTac [API documentation](https://api.timetac.com/).

## Installation

Use the package manager to install TimeTac Client Library.

Using package manager:

```bash
Install-Package TimeTac-CS-Library -Version 1.0.0
```

Using .NET CLI:

```bash
dotnet add package TimeTac-CS-Library --version 1.0.0
```

Using PackageReference:

```bash
<PackageReference Include="TimeTac-CS-Library" Version="1.0.0" />
```

Using Packet CLI:

```bash
paket add TimeTac-CS-Library --version 1.0.0
```

## Usage

```csharp
using TimeTac_Library;
using TimeTac_Library.Authentication;

//Only account name is required.
ApiConfigModel config = new ApiConfigModel
{
  Host = "go.timetac.com",
  Version = 3,
  Account = "mbcomitsystemhaus"
};

Api api = new Api(config);

PasswordCredentialModel credentials = new PasswordCredentialModel
{
  Client_id = <CLIENT_ID>,
  Client_secret = <CLIENT_SECRET>,
  Username = <USER_NAME>,
  Password = <PASSWORD>
};
import Api from "@timetac/js-client-library"

const environment = {
  host: 'go.timetac.com',
  account: <ACCOUNT_NAME>,
  version: '3'
}

const authCredentials = {
  grant_type: 'password',
  client_id: <CLIENT_ID>,
  client_secret: <CLIENT_SECRET>,
  username: <USER_NAME>,
  password: <PASSWORD>
}

await api.Authentication.Login(credentials);

TaskModel[] tasks = await api.Task.Read();
```

## List of supported endpoints

- [x] [authentication](https://api.timetac.com/doc/v3#tag/authentication)
- [ ] [absenceDays](https://api.timetac.com/doc/v3#tag/absenceDays)
- [ ] absenceBans
- [ ] [absences](https://api.timetac.com/doc/v3#tag/absences)
- [ ] absenceMultistageResponsibilities
- [ ] [absenceTypes](https://api.timetac.com/doc/v3#tag/absenceTypes)
- [ ] absenceTypesRestrictToCountries
- [ ] accessCredentials
- [ ] changeTimeTrackingRequests
- [ ] checkpoints
- [ ] checkpointTrackings
- [ ] clients
- [ ] countries
- [ ] [deltaSync](https://api.timetac.com/doc/v3#tag/deltaSync)
- [ ] [departments](https://api.timetac.com/doc/v3#tag/departments)
- [ ] files
- [ ] generalSettingsChangeLog
- [ ] [generalSettings](https://api.timetac.com/doc/v3#tag/generalSettings)
- [ ] geofences
- [ ] geofenceToNodes
- [ ] invoices
- [ ] jobParams
- [ ] jobQueues
- [ ] messages
- [ ] nfcTransponders
- [ ] notifications
- [ ] notificationsTypeHtml
- [ ] notificationUrls
- [ ] offlineSyncErrors
- [ ] permissionsRelatedEndpoints
- [ ] [projects](https://api.timetac.com/doc/v3#tag/projects)
- [ ] recentTasks
- [ ] salutations
- [ ] schedulings
- [ ] [serverCommunication]()
- [ ] serverEvents
- [ ] serverTime
- [ ] skills
- [ ] surveys
- [ ] surveyAnswers
- [ ] surveySubmits
- [ ] surveyQuestions
- [ ] surveyQuestionDefinitions
- [x] [tasks](https://api.timetac.com/doc/v3#tag/tasks)
- [ ] [teamMembers](https://api.timetac.com/doc/v3#tag/teamMembers)
- [ ] [teams](https://api.timetac.com/doc/v3#tag/teams)
- [ ] [timetrackings](https://api.timetac.com/doc/v3#tag/timetrackings)
- [ ] [timesheetAccounting](https://api.timetac.com/doc/v3#tag/timesheetAccounting)
- [ ] timesheetAccountingSummaries
- [ ] timetrackingChangelogs
- [ ] timezones
- [ ] todoTasks
- [ ] translations
- [ ] [users](https://api.timetac.com/doc/v3#tag/users)
- [ ] [userStatusOverview](https://api.timetac.com/doc/v3#tag/userStatusOverview)
- [ ] zohoSubscriptions

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.


## License

[Apache License 2.0](https://choosealicense.com/licenses/apache-2.0/)
