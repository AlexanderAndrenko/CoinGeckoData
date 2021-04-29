using System;
using System.Collections.Generic;
using System.Text;

namespace CoinGeckoData.Model
{
    /*Класс хранит в себе реквизиты для входа на сервер*/
    class CredentialsForServer
    {      
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string DataSource { get; set; }
        public static string DataBase { get; set; }
        
    }
}
