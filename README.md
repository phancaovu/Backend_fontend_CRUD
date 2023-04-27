# Backend_fontend_CRUD
## Cấu trúc thư mục

![image](https://user-images.githubusercontent.com/66910370/234733896-c6d6cd2b-7247-4765-925f-4860c191ae9b.png)
## Run Project
### Sửa lại đường dẫn dến database
https://github.com/phancaovu/Backend_fontend_CRUD/blob/master/appsettings.json
***
```php
"ConnectionStrings": {
    "UserStore": "Server=(localdb)\\mssqllocaldb;Database=UserDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
```
### Migration Database sử dụng Package Manager Console
``` 
      Add-Migration Dbinit
      Update-Database
```   
### congfig project 
![image](https://user-images.githubusercontent.com/66910370/234735264-37acaad6-7546-4b3d-8630-a33e9b4779d0.png)


