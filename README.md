ReData
==================
Program for laboratory work on "Software and Hardware Methods and Means of Information Protection" discipline

## How work with ReData
Программа запросит код:

![image](https://user-images.githubusercontent.com/50168261/168461349-aafb405e-fe68-44e4-9320-be3875c47b4e.png)
 
Загрузится главная форма, если код верен. Иначе сообщит об ошибке конфигурационного файла.
Главная форма

![image](https://user-images.githubusercontent.com/50168261/168173984-cb3c8ed3-757d-4028-827f-ae56a33fc75e.png)

Ошибка может проявляться если:
Файл конфигурации был подменен, и ключи шифрования не совпадают.
 
Выбираем файл атрибуты которого будем менять:
![image](https://user-images.githubusercontent.com/50168261/168173371-fb1134f8-2c46-403e-80d9-6caf75cd99f5.png)
![image](https://user-images.githubusercontent.com/50168261/168174132-e6c81b98-4f12-4584-985c-978b53cf6043.png) 

Меняем данные и нажимаем Use.

![image](https://user-images.githubusercontent.com/50168261/168174315-5adbc362-8742-4237-ac76-e3474232becf.png)

Программа имеет ограниченное количество запусков. После 10 запусков будет выведено следующее сообщение
 
![image](https://user-images.githubusercontent.com/50168261/168461391-4d1107c7-fe43-44be-967a-48f06efdf4c6.png)

При удаленном файле конфигурации:

![image](https://user-images.githubusercontent.com/50168261/168461396-03b7938c-3024-4536-920a-78834fae043a.png)

Файл шифруется алгоритмом Feistel.


## Обход

Если есть необходимость протестировать приложение ещё раз:
1. Удаляем файл конфигурации.
2. Заходим в реестр юзера @Sowtfare.
3. Удаляем Ветку.

*Примечание:* теперь можете ставить любой код при первом запуске. Однако теперь вы используете только его.
