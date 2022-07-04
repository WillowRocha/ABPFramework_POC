import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'GettingStarted',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44394',
    redirectUri: baseUrl,
    clientId: 'GettingStarted_App',
    responseType: 'code',
    scope: 'offline_access GettingStarted',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44394',
      rootNamespace: 'ABP.GettingStarted',
    },
  },
} as Environment;
