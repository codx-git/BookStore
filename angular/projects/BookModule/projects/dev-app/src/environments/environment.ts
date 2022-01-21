import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'BookModule',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44305',
    redirectUri: baseUrl,
    clientId: 'BookModule_App',
    responseType: 'code',
    scope: 'offline_access BookModule role email openid profile',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44305',
      rootNamespace: 'BookModule',
    },
    BookModule: {
      url: 'https://localhost:44311',
      rootNamespace: 'BookModule',
    },
  },
} as Environment;
