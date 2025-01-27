#  Генерация отчета PDF из JSON-файла с использованием StimulSoft 

## Технологии
- **Frontend:** React+JS
- **Backend:** Node.js с использованием Express.js

## Установка и запуск

1. Склонируйте репозиторий;
2. Импортируйте базу данных `users.sql`;
 <br>
Для запуска серверной части выполните следующие команды:  <br>

```
cd server

node server.js
```
А для установки всех необходимых зависимостей и запуска клиентской части выполните:  
```
npm install

npm start
```

## Примечание

При импорте базы данных, создайте последовательность если она `не существует`:
```
CREATE SEQUENCE IF NOT EXISTS users_user_id_seq;

```

Настройте базу данных PostgreSQL и измените параметры подключения в файле `server/server.js`:

```javascript
const pool = new Pool({
  user: 'ВашеИмяПользователя',
  host: 'localhost',
  database: 'ВашаБазаДанных',
  password: 'ВашПароль',
  port: 5432,
});
