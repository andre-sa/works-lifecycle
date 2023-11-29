# WLC2 - Works LifeCycle v2
LEI.ipt Final Project


## Deploy with Docker

The application is containerized using docker. There are two main images: `web` (see the Dockerfile) and `db` (standard mssql server). A third image, called `migrations` (see migrations.Dockerfile), exists just to run migrations after updates (ASP.NET migrations are not great, require the code, sdk and so on). See [this](https://stackoverflow.com/questions/37562122/is-there-a-way-to-run-ef-core-rc2-tools-from-published-dll/59269689#59269689).

In summary, the project can be deployed in any Linux/Windows bix with docker + docker compose installed by following the steps below:

```bash
# clone the project
git clone <url>

# enter the project folder
cd wlc2

# build the containers
docker-compose build # if needed add --no-cache
# anternatively, docker build -t wlc2:latest -t wlc2:<X.Y.Z> .

# run the containers in background (daemon)
docker-compose up -d

# after every update or new install you may need to apply db migrations:
# run the migrations container with an interative shell
docker-compose run migrations bash
# inside apply migrations (if needed add ASPNETCORE_ENVIRONMENT=Production)
dotnet ef database update

# exit with CTRL + D
```

### Running in Production
The abovementioned instructions are to be used in dev and staging. In production several additional steps should be considered, namely:
- DB setup, backup and others (currently a simple volume is used, no backups)
- Migrations should not be used, instead Idempotent SQL scripts (see [this](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/applying?tabs=dotnet-core-cli#apply-migrations-at-runtime))
- Storage issues (currently there is not even a volume for uploads)
- Tests, optimizations, CICD pipeline with proper image versioning in a registry

## Issues to be addressed
- Migrate from MSSQL to MySQL or PostgreSQL (lighter)
- Use volumes to store uploaded files (mostly pdfs)
- Use volumes to store DB content or a dedicated DB service (with proper backups)
- Build and push containers to registry (private? Ci2 registry?)
- Automated tests with CI/CD pipeline
- Define ENV var ASPNETCORE_ENVIRONMENT=Production

## Contributing
To contribute clone the project and start developing on a different branch. Pull requests are welcome.

Please make sure to update tests as appropriate.
