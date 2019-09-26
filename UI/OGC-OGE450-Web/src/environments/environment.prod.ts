// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `angular-cli.json`.

export const environment = {
    production: true,
    envName: 'prod',
    debug: false,
    idleTimeout: 3540,
    idleCountdown: 60,
    base: '/oge450/',
    apiUrl: 'URL for API',
    clientId: 'Active Directory Client ID for login',
    sharePointUrl: 'URL to SharePoint Instance',
    portalUrl: 'URL to Portal (aka Training)',
};
