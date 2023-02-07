using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoSQLite.DAL
{
    internal class SqliteHelper
    {
        internal static List<User> GetUsers() // Заменили возвращаемый тип Object на корректный List<User> (глобально не меняет ни чего)
        {
            try
            {
                using(var connection = new SQLiteConnection(@"Data source = db.sqlite; Version=3;")) // строка для подключения к SQLite
                {
                    connection.Open(); // открываем соединение

                    using (var cmd = new SQLiteCommand(@"SELECT id,
       user_name,
       name,
       date_created
  FROM users;", connection)) // из SELECT базы данных SQLite
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {
                            List<User> users = new List<User> (); // получать список данных пользователей
                            // создадим список поьзователей в новом файле Users.cs ( с помощью лампочки Generate type "User" -> Generate class "User" in new file)
                            // после создания класса User - он появится в Solution Explorer
                            while(rdr.Read()) // ридер, который переходит на следующую строку при корректном завершении предидущей
                            {
                                users.Add(new User()
                                {
                                    id =rdr.GetInt32(0), // из каждой строки полученной из User - создаём объект типа User и добавляем его в список Users 
                                    UserName = rdr.GetString(1), // нажав F12 на UserName - перейдём в созанный класс User
                                    Name = rdr.GetString(2),
                                    Date = rdr.GetDateTime(3),
                                    // создаём эти свойства с помощью пкм(rmb) Generate property "id" to do
                                });
                            }
                            return users; // возвращаем список users
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message); 
            }
            return null;
        }
    }
}
