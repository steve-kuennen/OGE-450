// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `angular-cli.json`.

export const environment = {
    production: false,
    apiUrl: 'http://localhost:60299/api/',
    base: '/',
    envName: 'dev',
    clientId: 'd26b0eb6-6c0d-4292-8419-f3ea86a4f338',
    debug: true,
    idleTimeout: 840,
    idleCountdown: 60,
    sharePointUrl: 'https://devportal.omb.gov/sites/ogc/',
    portalUrl: 'http://accessdev.omb.gov/portal',
};
