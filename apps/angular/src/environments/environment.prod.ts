import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'AventHub',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44326',
    redirectUri: baseUrl,
    clientId: 'AventHub_App',
    responseType: 'code',
    scope: 'offline_access AventHub',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44379',
      rootNamespace: 'AventHub',
    },
  },
} as Environment;
