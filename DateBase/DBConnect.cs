using System;
using System.Linq;
using System.Data.Linq;
using LinqToDB;

namespace DateBase
{
    public class DBConnect
    {
        static string connectionString = @"Data Source=.\PostgreSQL;Initial Catalog=Films;Integrated Security=True";
        public static void Do() 
        {
            DataContext db = new DataContext(connectionString);
 
            // Получаем таблицу пользователей
            ITable<User> users = db.GetTable<User>();

            foreach (var user in users)
            {
                Console.WriteLine("{0} \t{1} \t{2} \t{3} \t{4} \t{5} \t{6} ", user.user_id, user.firstname, user.nickname, user.email, user.password, user.birth_date, user.joined_date);
            }
 
            Console.Read();
        }
    }
}