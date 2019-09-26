// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `angular-cli.json`.

export const environment = {
    envName: 'dev',
    production: false,
    base: '/',
    debug: true,
    idleTimeout: 840,
    idleCountdown: 60,
    apiUrl: 'URL for API',
    oge450Url: 'URL for OGE 450 Application',
    eventClearanceUrl: 'URL for Event Clearance Application',
    clientId: 'Active Directory Client ID for login',
    sharePointUrl: 'URL to SharePoint Instance',
};

