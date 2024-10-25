import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { importProvidersFrom } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

// Bootstrap de la aplicación con HttpClientModule
bootstrapApplication(AppComponent, {
  providers: [importProvidersFrom(HttpClientModule)]
}).catch(err => console.error(err));
