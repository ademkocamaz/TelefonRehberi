﻿using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi.DataAccess.Concrete.Dapper
{
    public class Database
    {
        public static readonly string connectionString = new FbConnectionStringBuilder
        {
            Database = @"data\db.fdb",
            ServerType = FbServerType.Embedded,
            UserID = "SYSDBA",
            Password = "masterkey",
            ClientLibrary = @"lib\fbclient.dll"
        }.ToString();


    }
}
