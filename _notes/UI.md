## install node.js

## install angular
```
    npm uninstall -g @angular/cli

    npm install -g @angular/cli@latest


    ng version
```

## Create Angular project
```
    ng new FullStack.UI

    ## open default browser
    ng serve --o
```


## Use bootstrap
past the links of bootstrap 5 css and js to index.html



## Nav
past code from  https://getbootstrap.com/docs/5.0/components/navbar/ into app.component.html


## Routing
Modify app-routing.module.ts
```
const routes: Routes = [
  {
    path: '',
    component: EmployeeListComponent
  }
];
```
Modify code in Nav


## Models
employee.model.ts


## Fetch data
Create service
```
  ng g s employees
```

Tell vs code where to find the type for http module
```
# tsconfig.json

"typeRoots": [
    "node_modules/@types",
    "node_modules/@angular/",
    "node_modules/@angular/common/http"
  ]
```

config API url
```
# src/environments/environment.ts 

export const environment = {
  baseApiUrl: 'https://localhost:7054'
};
```


## Add
Create component
```
  ng g c add-employees
```

Add route in app-routing.module.ts and Nav


copy form code from https://getbootstrap.com/docs/5.0/forms/form-control/

Use ngFrom
```
 <form #form="ngForm">
```

app.module.ts
```
imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
```