# ProHogar
Early propotype for our startup. :)

## 🚀Build
```
dotnet tool install --global dotnet-ef
dotnet ef database update
dotnet build
```

## 🚀Run
```
dotnet run
```

## 🧩Endpoints

### Servicio
* Get all Servicio [GET]:
``` /api/Servicio ```
* Get an specific Servicio [GET]:
``` /api/Servicio/{id} ```
### Usuario
* Log In [POST]:
``` /api/Usuario/login ```
* Register user [POST]:
``` /api/Usuario/registro ```
### Negocio
* Get all Negocio [GET]:
``` /api/Negocio ```
* Get an specific Negocio [GET]:
``` /api/Negocio/{id} ```
* Register Negocio [POST]:
``` /api/Negocio/ ```
* Delete Negocio [DELETE]:
``` /api/Negocio/{id} ```
