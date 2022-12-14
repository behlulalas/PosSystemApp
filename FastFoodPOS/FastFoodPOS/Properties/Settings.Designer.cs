//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FastFoodPOS.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\FastFoodDatabase.ac" +
            "cdb;Persist Security Info=True")]
        public string FastFoodDatabaseConnectionString {
            get {
                return ((string)(this["FastFoodDatabaseConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\r\nCREATE TABLE IF NOT EXISTS  orders  (\r\n   id  int(11) NOT NULL AUTO_INCREMENT,\r" +
            "\n   product_id  int(11) NOT NULL,\r\n   transaction_id  varchar(256) NOT NULL,\r\n  " +
            " quantity  int(11) NOT NULL,\r\n   price  decimal(10,2) NOT NULL,\r\n  PRIMARY KEY(i" +
            "d)\r\n) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;\r\n\r\n\r\nCRE" +
            "ATE TABLE IF NOT EXISTS  products  (\r\n   id  int(11) NOT NULL AUTO_INCREMENT,\r\n " +
            "  name  varchar(256) NOT NULL,\r\n   category  varchar(256) NOT NULL,\r\n   price  d" +
            "ecimal(10,2) NOT NULL,\r\n   is_available  tinyint(1) NOT NULL,\r\n   image  varchar" +
            "(256) NOT NULL,\r\n   IsDeleted  tinyint(1) NOT NULL DEFAULT \'0\',\r\n  PRIMARY KEY(i" +
            "d)\r\n) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;\r\n\r\n\r\nCRE" +
            "ATE TABLE IF NOT EXISTS  transactions  (\r\n   id  varchar(256) NOT NULL,\r\n   user" +
            "_id  int(11) NOT NULL,\r\n   date_created  datetime NOT NULL DEFAULT CURRENT_TIMES" +
            "TAMP,\r\n   cash  decimal(10,2) NOT NULL,\r\n  PRIMARY KEY(id)\r\n) ENGINE=InnoDB DEFA" +
            "ULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;\r\n\r\n\r\nCREATE TABLE IF NOT EXISTS " +
            " users  (\r\n   id  int(11) NOT NULL AUTO_INCREMENT,\r\n   fullname  varchar(256) NO" +
            "T NULL,\r\n   email  varchar(256) NOT NULL,\r\n   role  varchar(256) NOT NULL,\r\n   p" +
            "assword  varchar(256) NOT NULL,\r\n   image  varchar(256) NOT NULL,\r\n   IsDeleted " +
            " tinyint(1) NOT NULL DEFAULT \'0\',\r\n  PRIMARY KEY(id)\r\n) ENGINE=InnoDB DEFAULT CH" +
            "ARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;\r\n\r\n\r\nCREATE OR REPLACE VIEW  OrderTota" +
            "l  AS\r\nSELECT transaction_id, SUM(price*quantity) AS total, Sum(quantity) AS ord" +
            "ers\r\nFROM orders\r\nGROUP BY transaction_id;\r\n\r\n\r\nCREATE OR REPLACE VIEW  Transact" +
            "ionsView  AS\r\nSELECT transactions.*, OrderTotal.total, OrderTotal.orders\r\nFROM t" +
            "ransactions INNER JOIN OrderTotal ON transactions.id=OrderTotal.transaction_id;\r" +
            "\n\r\n\r\nCREATE OR REPLACE VIEW  SalesView  AS\r\nSELECT Sum(TransactionsView.total) A" +
            "S Sale, date_created AS day, Sum(TransactionsView.orders) AS total_order, Count(" +
            "TransactionsView.id) AS total_customer\r\nFROM TransactionsView\r\nGROUP BY day\r\nORD" +
            "ER BY day;\r\n\r\n")]
        public string MySQLTables {
            get {
                return ((string)(this["MySQLTables"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("IF  NOT EXISTS (SELECT * FROM sys.objects \r\n\tWHERE object_id = OBJECT_ID(N\'[dbo]." +
            "[CafeTables]\') AND type in (N\'U\'))\r\n\r\nBEGIN\r\nCREATE TABLE [dbo].[CafeTables](\r\n\t" +
            "[TableID] [int] IDENTITY(1,1) NOT NULL,\r\n\t[TableCode] [nvarchar](max) NULL,\r\n\t[T" +
            "ableName] [nvarchar](max) NULL,\r\n\t[TransactionCode] [nvarchar](max) NULL,\r\n\t[IsA" +
            "vailable] [bit] NOT NULL DEFAULT (1),\r\n\tCONSTRAINT [PK_dbo.CafeTables] PRIMARY K" +
            "EY CLUSTERED \r\n\t(\r\n\t\t[TableID] ASC\r\n\t\t)WITH (PAD_INDEX = OFF, STATISTICS_NORECOM" +
            "PUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) O" +
            "N [PRIMARY]\r\n) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]\r\nEND\r\nIF  NOT EXISTS (SELECT " +
            "* FROM sys.objects \r\n\tWHERE object_id = OBJECT_ID(N\'[dbo].[Logs]\') AND type in (" +
            "N\'U\'))\r\n\r\nBEGIN\r\nCREATE TABLE [dbo].[Logs](\r\n\t[Id] [int] IDENTITY(1,1) NOT NULL," +
            "\r\n\t[user_id] [int] NOT NULL,\r\n\t[date_created] [datetime] NOT NULL,\r\n\t[activity] " +
            "[nvarchar](max) NULL,\r\n CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED \r\n(\r\n\t[Id] AS" +
            "C\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, A" +
            "LLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY] TEXTIMA" +
            "GE_ON [PRIMARY]\r\nEND\r\nIF  NOT EXISTS (SELECT * FROM sys.objects \r\n\tWHERE object_" +
            "id = OBJECT_ID(N\'[dbo].[Orders]\') AND type in (N\'U\'))\r\n\r\nBEGIN\r\nCREATE TABLE [db" +
            "o].[Orders](\r\n\t[Id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[ProductId] [int] NOT NULL,\r" +
            "\n\t[TransactionCode] [nvarchar](max) NULL,\r\n\t[Quantity] [int] NOT NULL,\r\n\t[Price]" +
            " [decimal](18, 2) NOT NULL,\r\n\tCONSTRAINT [PK_dbo.Orders] PRIMARY KEY CLUSTERED \r" +
            "\n\t(\r\n\t\t[Id] ASC\r\n\t\t)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_" +
            "DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [" +
            "PRIMARY] TEXTIMAGE_ON [PRIMARY]\r\nEND\r\nIF  NOT EXISTS (SELECT * FROM sys.objects " +
            "\r\n\tWHERE object_id = OBJECT_ID(N\'[dbo].[Products]\') AND type in (N\'U\'))\r\n\r\nBEGIN" +
            "\r\n\r\nCREATE TABLE [dbo].[Products](\r\n\t[Id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[Name]" +
            " [nvarchar](max) NULL,\r\n\t[Category] [nvarchar](max) NULL,\r\n\t[Price] [decimal](18" +
            ", 2) NOT NULL,\r\n\t[IsAvailable] [bit] NOT NULL,\r\n\t[Image] [nvarchar](max) NULL,\r\n" +
            "\t[IsDeleted] [bit] NOT NULL DEFAULT (0),\r\n\tCONSTRAINT [PK_dbo.Products] PRIMARY " +
            "KEY CLUSTERED \r\n\t(\r\n\t\t[Id] ASC\r\n\t\t)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE" +
            " = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [P" +
            "RIMARY]\r\n) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]\r\nEND\r\nIF  NOT EXISTS (SELECT * FR" +
            "OM sys.objects \r\n\tWHERE object_id = OBJECT_ID(N\'[dbo].[Sales]\') AND type in (N\'U" +
            "\'))\r\n\r\nBEGIN\r\nCREATE TABLE [dbo].[Sales](\r\n\t[Value] [decimal](18, 2) NOT NULL,\r\n" +
            "\t[OrderCount] [int] NOT NULL,\r\n\t[CustomerCount] [int] NOT NULL,\r\n\t[Date] [dateti" +
            "me] NOT NULL,\r\n\tCONSTRAINT [PK_dbo.Sales] PRIMARY KEY CLUSTERED \r\n\t(\r\n\t\t[Value] " +
            "ASC\r\n\t\t)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OF" +
            "F, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY]\r\nEN" +
            "D\r\nIF  NOT EXISTS (SELECT * FROM sys.objects \r\n\tWHERE object_id = OBJECT_ID(N\'[d" +
            "bo].[Transactions]\') AND type in (N\'U\'))\r\n\r\nBEGIN\r\n\r\nCREATE TABLE [dbo].[Transac" +
            "tions](\r\n\t[Id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[TransactionCode] [nvarchar](max)" +
            " NULL,\r\n\t[Date] [datetime] NOT NULL DEFAULT GETDATE(),\r\n\t[Cash] [decimal](18, 2)" +
            " NOT NULL,\r\n\t[CashierId] [int] NOT NULL,\r\n\t[CafeTableId] [int] NOT NULL,\r\n\tCONST" +
            "RAINT [PK_dbo.Transactions] PRIMARY KEY CLUSTERED \r\n\t(\r\n\t\t[Id] ASC\r\n\t\t)WITH (PAD" +
            "_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCK" +
            "S = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY]\r\nEND\r\nIF  NOT EXISTS" +
            " (SELECT * FROM sys.objects \r\n\tWHERE object_id = OBJECT_ID(N\'[dbo].[Users]\') AND" +
            " type in (N\'U\'))\r\n\r\nBEGIN\r\nCREATE TABLE [dbo].[Users](\r\n\t[Id] [int] IDENTITY(1,1" +
            ") NOT NULL,\r\n\t[Email] [nvarchar](max) NULL,\r\n\t[Fullname] [nvarchar](max) NULL,\r\n" +
            "\t[Role] [nvarchar](max) NULL,\r\n\t[Password] [nvarchar](max) NULL,\r\n\t[Image] [nvar" +
            "char](max) NULL,\r\n\t[IsDeleted] [bit] NOT NULL DEFAULT (0),\r\n\tCONSTRAINT [PK_dbo." +
            "Users] PRIMARY KEY CLUSTERED \r\n\t(\r\n\t\t[Id] ASC\r\n\t\t)WITH (PAD_INDEX = OFF, STATIST" +
            "ICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LO" +
            "CKS = ON) ON [PRIMARY]\r\n) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]\r\nEND")]
        public string MSSQLTables {
            get {
                return ((string)(this["MSSQLTables"]));
            }
            set {
                this["MSSQLTables"] = value;
            }
        }
    }
}
