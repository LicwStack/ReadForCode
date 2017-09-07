CREATE TABLE global (key varchar(256) NOT NULL PRIMARY KEY, value varchar(1024) NOT NULL);

CREATE TABLE DNA (KeyPath TEXT PRIMARY KEY NOT NULL UNIQUE, Text TEXT, Int64 INTEGER, Float REAL, Blob BLOB);

CREATE TABLE DownSoftTask (KeyPath TEXT PRIMARY KEY NOT NULL UNIQUE, Text TEXT, Int64 INTEGER, Float REAL, Blob BLOB);

//--- SQLite数据类型包括NULL，INTEGER，REAL，TEXT，BLOB
//--- BLOB数据，完全根据它的输入存储

CREATE TABLE [old_items] ( [key] text unique, [tii] blob, [tdi] blob);

CREATE TABLE t1 (c1 uint64 primary key, c2 text, c3 text, c4 INTEGER, c5 text, c6 text, c7 INTEGER,  c8 integer, c9 text);

CREATE TABLE t2 (c1 uint64, c2 uint64, c3 uint64, c4 text, c5 int64, c6 int64, c7 text, c8 integer, c9 integer, c10 integer, c11 integer, c12 text, primary key(c1), foregin key(c3) references t1(c1) ON DELETE CASCADE);  //-- 级联删除，当删除主键表时，外键表也会一起删除

CREATE INDEX t1md5_index ON t1(c2);

CREATE INDEX t2md5_index ON t2(c4);

//--- SQLite亲和类型
//--- INTEGER：INT,INTEGER,TINYINT,SMALLINT,MEDIUMINT,BIGINT,UNSIGNED BIG INT,INT2,INT8
//--- TEXT: CHARACTER(20),VARCHAR(255),VARYING CHARACTER(255),NCHAR(55),NATIVE CHARACTER(70),NVARCHAR(100),TEXT,CLOB
//--- NONE: BLOB,no datatype specified
//--- REAL: REAL,DOUBLE, DOUBLE PRECISION, FLOAT
//--- NUMERIC: NUMERIC,DECIMAL(10,5),BLOOEAN,DATE,DATETIME

CREATE TABLE tab_31 (keySZ char(260) UNIQUE, val blob);

CREATE TABLE devicedownload_file(task_id INTEGER NOT NULL PRIMARY KEY,server_path TEXT COLLATE NOCASE, local_path TEXT COLLATE NOCASE, status INTEGER,file_size INTEGER,finished_size INTEGER,error_code INTEGER, process float, src_deviceid TEXT, des_deviceid TEXT,  reserved1 INTEGER,reserved2 INTEGER,reserved3 INTEGER,reserved4 INTEGER,reserved5 INTEGER, reserved6 TEXT,reserved7 TEXT,reserved8 TEXT,reserved9 TEXT,reserved10 TEXT );
                                                                //-- COLLATE NOCASE: 忽略大小写
CREATE TABLE version (table_name TEXT NOT NULL PRIMARY KEY,version INTEGER );

CREATE INDEX idxdownloadtaskid on devicedownload_file( task_id );

CREATE TABLE BootRecord(dkey int, bootkey char, newborn char, btime int, rmflag int, powerspeedflag int, leakfixflag int, reinstallflag int);

CREATE TABLE NewItems(dp char, description char);

CREATE TABLE MT (Type INTEGER, ModName CHAR, Mask INTEGER, SLev INTEGER,Title CHAR, Icon CHAR, Body CHAR, ExtendAttrib CHAR,ACTIONNUM INTEGER,ACTIONDATA BLOB, TIMESTAMP sqlite3_int64, CS INTEGER, id INTEGER PRIMARY KEY AUTOINCREMENT  );
                                                            //-- 主键自增
CREATE TABLE `http_cache_v9`(id INTEGER PRIMARY KEY, url VARCHAR(4096) UNIQUE NOT NULL, cache_time BIGINT NOT NULL, last_modified BIGINT,etag VARCHAR(256), ark_path VARCHAR(512), file_size BIGINT, max_age BIGINT);

CREATE UNIQUE INDEX `http_cache_v9_url_index` ON `http_cache_v9`(url);

CREATE TABLE meta ( meta_index INT UNIQUE NOT NULL, meta_data VARCHAR(256) );

CREATE TABLE meta(key LONGVARCHAR NOT NULL UNIQUE PRIMARY KEY, value LONGVARCHAR);

CREATE TABLE Databases (id INTEGER PRIMARY KEY AUTOINCREMENT, origin TEXT NOT NULL, name TEXT NOT NULL, description TEXT NOT NULL, estimated_size INTEGER NOT NULL);

CREATE INDEX origin_index ON Databases (origin);

CREATE UNIQUE INDEX unique_index ON Databases (origin, name);

CREATE TABLE previews_v1 (host_name VARCHAR NOT NULL, time INTEGER NOT NULL, opt_out INTEGER NOT NULL, type INTEGER NOT NULL, PRIMARY KEY(host_name, time DESC, opt_out, type));

CREATE TABLE enabled_previews_v1 (type INTEGER NOT NULL, version INTEGER NOT NULL, PRIMARY KEY(type));

CREATE TABLE PageURL (url TEXT NOT NULL ON CONFLICT FAIL UNIQUE ON CONFLICT REPLACE,iconID INTEGER NOT NULL ON CONFLICT FAIL);
CREATE INDEX PageURLIndex ON PageURL (url);
CREATE TABLE IconInfo (iconID INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE ON CONFLICT REPLACE, url TEXT NOT NULL ON CONFLICT FAIL UNIQUE ON CONFLICT FAIL, stamp INTEGER);
CREATE INDEX IconInfoIndex ON IconInfo (url, iconID);
CREATE TABLE IconData (iconID INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE ON CONFLICT REPLACE, data BLOB);
CREATE INDEX IconDataIndex ON IconData (iconID);
CREATE TABLE IconDatabaseInfo (key TEXT NOT NULL ON CONFLICT FAIL UNIQUE ON CONFLICT REPLACE,value TEXT NOT NULL ON CONFLICT FAIL);

CREATE TABLE [cus_annotation] (word text NOT NULL,record_type integer NOT NULL,fake_record_id integer,fake_lib_id integer,time_stamp integer,highlight text,legacy_highlight text, note text, meta text, deleted boolean DEFAULT 0, local_update boolean, server_timestamp integer, local_timestamp integer);

CREATE TABLE upload_file (task_id INTEGER NOT NULL PRIMARY KEY,server_path varchar(1024) COLLATE NOCASE, local_path varchar(1024) COLLATE NOCASE, status INTEGER,file_size INTEGER, isdir INTEGER,error_code INTEGER,add_time INTEGER,status_changetime INTEGER,  reserved1 INTEGER DEFAULT 0,reserved2 INTEGER DEFAULT 0,reserved3 TEXT DEFAULT '',reserved4 TEXT DEFAULT '' );
CREATE TABLE upload_history_file (id INTEGER PRIMARY KEY,server_path varchar(1024) COLLATE NOCASE,  local_path varchar(1024) COLLATE NOCASE, isdir INTEGER,size INTEGER,op_starttime INTEGER,op_endtime INTEGER,  reserved1 INTEGER DEFAULT 0,reserved2 INTEGER DEFAULT 0,reserved3 TEXT DEFAULT '',reserved4 TEXT DEFAULT '',reserved5 TEXT DEFAULT '' );
CREATE TABLE download_file(task_id INTEGER NOT NULL PRIMARY KEY,server_path varchar(1024) COLLATE NOCASE, local_path varchar(1024) COLLATE NOCASE, status INTEGER,file_size INTEGER,isdir INTEGER,error_code INTEGER, add_time INTEGER,status_changetime INTEGER,download_url TEXT,download_type INTEGER,  param1 TEXT,param2 TEXT,param3 TEXT,param4 TEXT,param5 TEXT, reserved1 INTEGER DEFAULT 0,reserved2 INTEGER DEFAULT 0,reserved3 TEXT DEFAULT '',reserved4 TEXT DEFAULT '' );
CREATE TABLE download_history_file (id INTEGER PRIMARY KEY,server_path varchar(1024) COLLATE NOCASE,  local_path varchar(1024) COLLATE NOCASE, isdir INTEGER,size INTEGER,op_starttime INTEGER,op_endtime INTEGER,download_type INTEGER,  reserved1 INTEGER DEFAULT 0,reserved2 INTEGER DEFAULT 0,reserved3 TEXT DEFAULT '',reserved4 TEXT DEFAULT '',reserved5 TEXT DEFAULT '' );
CREATE TABLE backup_file (local_filename varchar(1024) NOT NULL COLLATE NOCASE,  base_dir varchar(1024) NOT NULL COLLATE NOCASE,file_size INTEGER,mtime INTEGER,is_dir INTEGER, reserved1 INTEGER DEFAULT 0,reserved2 INTEGER DEFAULT 0,reserved3 TEXT DEFAULT '',reserved4 TEXT DEFAULT '',reserved5 TEXT DEFAULT '',reserved6 TEXT DEFAULT '',reserved7 TEXT DEFAULT '',CONSTRAINT pk_backupfile PRIMARY KEY(local_filename,base_dir) );
CREATE INDEX idxstatus on upload_file( status );
CREATE INDEX idxaddtime on upload_file( add_time );
CREATE INDEX idxbasedir on backup_file( base_dir );
CREATE INDEX idxdownloadstatus on download_file( status );
CREATE INDEX idxdownloadaddtime on download_file( add_time );
CREATE TABLE version (table_name TEXT NOT NULL PRIMARY KEY,version INTEGER );

CREATE TABLE cache_file(id INTEGER PRIMARY KEY, fid INTEGER, parent_path VARCHAR(1024), server_filename VARCHAR(1024), file_size INTEGER, md5 VARCHAR(32), isdir BOOLEAN, category INTEGER, server_mtime INTEGER, local_mtime INTEGER, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '', reserved3 TEXT DEFAULT '', reserved4 TEXT DEFAULT '', reserved5 TEXT DEFAULT '', reserved6 INTEGER DEFAULT 0, reserved7 INTEGER DEFAULT 0, reserved8 INTEGER DEFAULT 0, reserved9 INTEGER DEFAULT 0);
CREATE UNIQUE INDEX idxserverpath on cache_file(parent_path collate baiduyunsort, server_filename collate baiduyunsort);
CREATE TABLE version (table_name TEXT NOT NULL PRIMARY KEY,version INTEGER );

CREATE TABLE [animals] (
  [NAME] CHAR(10), 
  [SIZE] INTEGER, 
  [WEIGHT] INTEGER, 
  [AREA] CHAR(20), 
  [BMP] BLOB);
CREATE TABLE [clients] (
  [LAST_NAME] CHAR(20), 
  [FIRST_NAME] CHAR(20), 
  [ACCT_NBR] INTEGER, 
  [ADDRESS_1] CHAR(20), 
  [CITY] CHAR(20), 
  [STATE] CHAR(2), 
  [ZIP] CHAR(5), 
  [TELEPHONE] CHAR(12), 
  [DATE_OPEN] DATE, 
  [SS_NUMBER] INTEGER, 
  [PICTURE] CHAR(15), 
  [BIRTH_DATE] DATE, 
  [RISK_LEVEL] CHAR(8), 
  [OCCUPATION] CHAR(20), 
  [OBJECTIVES] CHAR(10), 
  [INTERESTS] CHAR(120), 
  [IMAGE] BLOB);
CREATE TABLE [country] (
  [Name] CHAR(24), 
  [Capital] CHAR(24), 
  [Continent] CHAR(24), 
  [Area] FLOAT, 
  [Population] FLOAT, 
  CONSTRAINT [sqlite_autoindex_country_1] PRIMARY KEY ([Name]));
CREATE TABLE [custoly] (
  [CustNo] INTEGER PRIMARY KEY, 
  [Last_Name] CHAR(30), 
  [First_Name] CHAR(30), 
  [VIP_Status] CHAR(10), 
  [Address1] CHAR(40), 
  [Address2] CHAR(40), 
  [City] CHAR(20), 
  [State/Prov] CHAR(10), 
  [Post_Code] CHAR(10), 
  [Country] CHAR(10), 
  [Phone] CHAR(18), 
  [Fax] CHAR(18), 
  [EMail] CHAR(40), 
  [Remarks] CHAR);
CREATE TABLE [customer] (
  [CustNo] INTEGER PRIMARY KEY, 
  [Company] CHAR(30), 
  [Addr1] CHAR(30), 
  [Addr2] CHAR(30), 
  [City] CHAR(15), 
  [State] CHAR(20), 
  [Zip] CHAR(10), 
  [Country] CHAR(20), 
  [Phone] CHAR(15), 
  [FAX] CHAR(15), 
  [TaxRate] FLOAT, 
  [Contact] CHAR(20), 
  [LastInvoiceDate] DATETIME);
CREATE TABLE [events] (
  [EventNo] INTEGER PRIMARY KEY, 
  [VenueNo] INTEGER, 
  [Event_Name] CHAR(30), 
  [Event_Date] DATE, 
  [Event_Time] TIME, 
  [Event_Description] CHAR, 
  [Ticket_price] CURRENCY, 
  [Event_Photo] GRAPHIC);
CREATE TABLE [industry] (
  [IND_CODE] INTEGER, 
  [IND_NAME] CHAR(5), 
  [LONG_NAME] CHAR(20));
CREATE TABLE [nextcust] (
  [NewCust] INTEGER);
CREATE TABLE [nextitem] (
  [NewKey] INTEGER);
CREATE TABLE [nextord] (
  [NewKey] INTEGER);
CREATE TABLE [reservat] (
  [ResNo] INTEGER PRIMARY KEY, 
  [EventNo] INTEGER, 
  [CustNo] INTEGER, 
  [NumTickets] INTEGER, 
  [Amt_Paid] CURRENCY, 
  [Pay_Method] CHAR(10), 
  [Card_No] CHAR(20), 
  [Card_Exp] DATE, 
  [Pay_Notes] CHAR, 
  [Purge_Date] DATE, 
  [Paid] BOOLEAN);
CREATE TABLE [vendors] (
  [VendorNo] INTEGER PRIMARY KEY, 
  [VendorName] CHAR(30), 
  [Address1] CHAR(30), 
  [Address2] CHAR(30), 
  [City] CHAR(20), 
  [State] CHAR(20), 
  [Zip] CHAR(10), 
  [Country] CHAR(15), 
  [Phone] CHAR(15), 
  [FAX] CHAR(15), 
  [Preferred] BOOLEAN);
CREATE TABLE [venues] (
  [VenueNo] INTEGER PRIMARY KEY, 
  [Venue] CHAR(30), 
  [Capacity] INTEGER, 
  [Venue_Map] GRAPHIC, 
  [Remarks] CHAR);
CREATE TABLE [biolife] (
  [Species No] INTEGER PRIMARY KEY, 
  [Category] CHAR(15), 
  [Common_Name] CHAR(30), 
  [Species Name] CHAR(40), 
  [Length (cm)] FLOAT(0, 2), 
  [Length_In] FLOAT(0, 2), 
  [Notes] CHAR, 
  [Graphic] GRAPHIC);
CREATE TABLE [employee] (
  [EmpNo] INTEGER PRIMARY KEY, 
  [LastName] CHAR(20), 
  [FirstName] CHAR(15), 
  [PhoneExt] CHAR(4), 
  [HireDate] DATETIME, 
  [Salary] CURRENCY);
CREATE TABLE [holdings] (
  [ACCT_NBR] INTEGER, 
  [SYMBOL] CHAR(7), 
  [SHARES] FLOAT, 
  [PUR_PRICE] CURRENCY, 
  [PUR_DATE] DATE);
CREATE TABLE [master] (
  [SYMBOL] CHAR(7), 
  [CO_NAME] CHAR(20), 
  [EXCHANGE] CHAR(8), 
  [CUR_PRICE] CURRENCY, 
  [YRL_HIGH] FLOAT, 
  [YRL_LOW] FLOAT, 
  [P_E_RATIO] FLOAT, 
  [BETA] FLOAT, 
  [PROJ_GRTH] FLOAT, 
  [INDUSTRY] INTEGER, 
  [PRICE_CHG] INTEGER, 
  [SAFETY] INTEGER, 
  [RATING] CHAR(4), 
  [RANK] INTEGER, 
  [OUTLOOK] INTEGER, 
  [RCMNDATION] CHAR(5), 
  [RISK] CHAR(4));
CREATE TABLE [Ψάρια] (
  [Species No] INTEGER PRIMARY KEY, 
  [类别] CHAR(15), 
  [Common_Name] CHAR(30), 
  [Species Name] CHAR(40), 
  [Länge (Zentimeter)] FLOAT(0, 2), 
  [Length_In] FLOAT(0, 2), 
  [Примечания] CHAR, 
  [グラフィック] GRAPHIC);
CREATE INDEX [idx_animals_NAME] ON [animals] ([NAME]);
CREATE INDEX [idx_custoly_City] ON [custoly] ([City]);
CREATE INDEX [idx_custoly_Names] ON [custoly] ([Last_Name], [First_Name]);
CREATE INDEX [idx_customer_ByCompany] ON [customer] ([Company]);
CREATE INDEX [idx_events_Date_Time] ON [events] ([Event_Name], [Event_Date]);
CREATE INDEX [idx_industry_IND_CODE] ON [industry] ([IND_CODE]);
CREATE INDEX [idx_reservat_CustNo] ON [reservat] ([CustNo]);
CREATE INDEX [idx_reservat_EventNo] ON [reservat] ([EventNo]);
CREATE INDEX [idx_employee_ByName] ON [employee] ([LastName], [FirstName]);
CREATE INDEX [idx_holdings_ACCT_NBR] ON [holdings] ([ACCT_NBR]);
CREATE INDEX [idx_holdings_SYMBOL] ON [holdings] ([SYMBOL]);
CREATE INDEX [idx_master_GROWTHASC] ON [master] ([PROJ_GRTH]);
CREATE INDEX [idx_master_GROWTHDESC] ON [master] ([PROJ_GRTH]);
CREATE UNIQUE INDEX [idx_master_SYMBOL] ON [master] ([SYMBOL]);
CREATE TABLE [orders](
  [OrderNo] INTEGER PRIMARY KEY, 
  [CustNo] INTEGER REFERENCES customer([CustNo]), 
  [SaleDate] DATETIME, 
  [ShipDate] DATETIME, 
  [EmpNo] INTEGER, 
  [ShipToContact] CHAR(20), 
  [ShipToAddr1] CHAR(30), 
  [ShipToAddr2] CHAR(30), 
  [ShipToCity] CHAR(15), 
  [ShipToState] CHAR(20), 
  [ShipToZip] CHAR(10), 
  [ShipToCountry] CHAR(20), 
  [ShipToPhone] CHAR(15), 
  [ShipVIA] CHAR(7), 
  [PO] CHAR(15), 
  [Terms] CHAR(6), 
  [PaymentMethod] CHAR(7), 
  [ItemsTotal] CURRENCY, 
  [TaxRate] FLOAT, 
  [Freight] CURRENCY, 
  [AmountPaid] CURRENCY);
CREATE INDEX [idx_orders_CustNo] ON [orders]([CustNo]);
CREATE TABLE [parts](
  [PartNo] INTEGER PRIMARY KEY, 
  [VendorNo] INTEGER REFERENCES vendors([VendorNo]), 
  [Description] CHAR(30), 
  [OnHand] FLOAT, 
  [OnOrder] FLOAT, 
  [Cost] CURRENCY, 
  [ListPrice] CURRENCY);
CREATE INDEX [idx_parts_ByDescription] ON [parts]([Description]);
CREATE INDEX [idx_parts_VendorNo] ON [parts]([VendorNo]);
CREATE TABLE [items](
  [OrderNo] INTEGER REFERENCES orders([OrderNo]), 
  [ItemNo] INTEGER, 
  [PartNo] INTEGER REFERENCES parts([PartNo]), 
  [Qty] INTEGER, 
  [Discount] FLOAT, 
  CONSTRAINT [sqlite_autoindex_items_1] PRIMARY KEY([OrderNo], [ItemNo]));
CREATE INDEX [idx_items_PartNo] ON [items]([PartNo]);
CREATE INDEX [idx_items_ByOrderNo] ON [items]([OrderNo]);

CREATE TABLE blacklist(id INTEGER PRIMARY KEY, uk BIGINT UNIQUE, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '', reserved3 INTEGER DEFAULT 0 );

CREATE TABLE conversations(id INTEGER PRIMARY KEY,group_id_conversation_uk BIGINT, conversation_type INTEGER,conversation_name TEXT DEFAULT '',last_msg_tip TEXT, last_msg_time BIGINT,last_msg_send_sate INTEGER,last_msg_sender_uk BIGINT, notificaton_count INTEGER, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '', reserved3 TEXT DEFAULT '', reserved4 INTEGER DEFAULT 0, reserved5 INTEGER DEFAULT 0);

CREATE TABLE followlist(id INTEGER PRIMARY KEY, uk BIGINT UNIQUE, source INTEGER, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '', reserved3 INTEGER DEFAULT 0 );

CREATE TABLE groups(id INTEGER PRIMARY KEY, group_id BIGINT UNIQUE, name TEXT, description TEXT, announce TEXT, type INTEGER, status INTEGER, ctime BIGINT, owner_uk BIGINT, avatar_part1_url TEXT, avatar_part2_url TEXT, avatar_part3_url TEXT, avatar_part4_url TEXT, member_limit INTEGER, show_in_list INTEGER DEFAULT 0, removed_by_admin INTEGER DEFAULT 0, message_notify INTEGER DEFAULT 1, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '', reserved3 TEXT DEFAULT '', reserved4 INTEGER DEFAULT 0, reserved5 INTEGER DEFAULT 0);

CREATE TABLE group_messages(id INTEGER PRIMARY KEY,group_id BIGINT,msg_id BIGINT, msg_content TEXT,rich_text_title TEXT DEFAULT '',rich_text_content TEXT DEFAULT '', rich_text_url TEXT DEFAULT '',rich_text_thumb_url TEXT DEFAULT '',msg_type INTEGER, sender_uk BIGINT,ctime BIGINT, send_state INTEGER DEFAULT 1,status INTEGER,min_server_ctime_fsid BIGINT, files_count INTEGER,image_prev_url2 TEXT DEFAULT '',image_prev_url3 TEXT DEFAULT '',image_prev_url4 TEXT DEFAULT '',image_prev_url5 TEXT DEFAULT '', image_prev_url6 TEXT DEFAULT '',msg_native_id TEXT, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '', reserved3 TEXT DEFAULT '', reserved4 INTEGER DEFAULT 0, reserved5 INTEGER DEFAULT 0);

CREATE TABLE group_messages_files(id INTEGER PRIMARY KEY,group_id BIGINT, msg_id BIGINT,fsid BIGINT,path TEXT,size BIGINT, server_ctime BIGINT,server_mtime BIGINT,local_ctime BIGINT,local_mtime BIGINT, is_dir INTEGER,thumbnail_big_url TEXT,thumbnail_mid_url TEXT, thumbnail_small_url TEXT, preview_url TEXT, dlink TEXT,md5 TEXT, category INTEGER,file_status INTEGER,dlink_time BIGINT,msg_native_id TEXT, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '', reserved3 TEXT DEFAULT '', reserved4 INTEGER DEFAULT 0, reserved5 INTEGER DEFAULT 0);

CREATE TABLE group_message_last_time(id INTEGER PRIMARY KEY,group_id BIGINT UNIQUE, msg_ctime BIGINT DEFAULT 0,local_fetch_time BIGINT DEFAULT 0, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '');

CREATE TABLE group_people(id INTEGER PRIMARY KEY, group_id BIGINT, uk BIGINT, role INTEGER DEFAULT 0, status INTEGER, ctime BIGINT,name_card TEXT, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '', reserved3 TEXT DEFAULT '', reserved4 INTEGER DEFAULT 0, reserved5 INTEGER DEFAULT 0);

CREATE TABLE miscellaneous(id INTEGER PRIMARY KEY, section TEXT, key TEXT, value TEXT, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '');

CREATE TABLE people(id INTEGER PRIMARY KEY, uk BIGINT UNIQUE, uname TEXT, nick_name TEXT, avatar_url TEXT, introduction TEXT, third INTEGER, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '', reserved3 TEXT DEFAULT '', reserved4 INTEGER DEFAULT 0, reserved5 INTEGER DEFAULT 0);

CREATE TABLE people_extend_infos(id INTEGER PRIMARY KEY, uk BIGINT UNIQUE, remark TEXT, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '', reserved3 TEXT DEFAULT '', reserved4 INTEGER DEFAULT 0, reserved5 INTEGER DEFAULT 0);

CREATE TABLE people_messages(id INTEGER PRIMARY KEY,conversation_uk BIGINT,msg_id BIGINT, msg_content TEXT,rich_text_title TEXT DEFAULT '',rich_text_content TEXT DEFAULT '', rich_text_url TEXT DEFAULT '',rich_text_thumb_url TEXT DEFAULT '',msg_type INTEGER, sender_uk BIGINT,ctime BIGINT, send_state INTEGER DEFAULT 1,status INTEGER,min_server_ctime_fsid BIGINT, files_count INTEGER,image_prev_url2 TEXT DEFAULT '',image_prev_url3 TEXT DEFAULT '',image_prev_url4 TEXT DEFAULT '',image_prev_url5 TEXT DEFAULT '', image_prev_url6 TEXT DEFAULT '',msg_native_id TEXT, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '', reserved3 TEXT DEFAULT '', reserved4 INTEGER DEFAULT 0, reserved5 INTEGER DEFAULT 0);

CREATE TABLE people_messages_files(id INTEGER PRIMARY KEY,conversation_uk BIGINT, msg_id BIGINT,fsid BIGINT,path TEXT,size BIGINT, server_ctime BIGINT,server_mtime BIGINT,local_ctime BIGINT,local_mtime BIGINT, is_dir INTEGER,thumbnail_big_url TEXT,thumbnail_mid_url TEXT, thumbnail_small_url TEXT, preview_url TEXT, dlink TEXT,md5 TEXT, category INTEGER,file_status INTEGER,dlink_time BIGINT, msg_native_id TEXT, reserved1 TEXT DEFAULT '', reserved2 TEXT DEFAULT '', reserved3 TEXT DEFAULT '', reserved4 INTEGER DEFAULT 0, reserved5 INTEGER DEFAULT 0);

CREATE TABLE version (table_name TEXT NOT NULL PRIMARY KEY,version INTEGER );

CREATE VIEW v_friends AS SELECT people.uk, uname, nick_name, avatar_url, introduction, third, remark, source FROM followlist LEFT JOIN people ON followlist.uk=people.uk LEFT JOIN people_extend_infos ON followlist.uk=people_extend_infos.uk WHERE NOT EXISTS(SELECT blacklist.uk FROM blacklist WHERE blacklist.uk=followlist.uk);

CREATE VIEW v_people_detail AS SELECT people.uk,uname,nick_name,avatar_url,introduction, third,remark,source,CASE WHEN blacklist.uk IS NOT NULL THEN 1 ELSE 0 END AS blocked, CASE WHEN followlist.uk IS NOT NULL THEN 1 ELSE 0 END AS followed FROM people LEFT JOIN followlist ON people.uk=followlist.uk LEFT JOIN people_extend_infos ON people.uk=people_extend_infos.uk LEFT JOIN blacklist ON people.uk=blacklist.uk;

CREATE UNIQUE INDEX i_conversation_idtype on conversations(group_id_conversation_uk,conversation_type);

CREATE UNIQUE INDEX i_group_messsages_files_gidnativemsgid on group_messages_files(group_id,msg_native_id,fsid) WHERE msg_native_id IS NOT NULL;

CREATE UNIQUE INDEX i_group_messsages_gidmsgid on group_messages(group_id,msg_id);

CREATE UNIQUE INDEX i_group_messsages_gidnativemsgid on group_messages(group_id,msg_native_id) WHERE msg_native_id IS NOT NULL;

CREATE UNIQUE INDEX i_group_messsage_files_gidmsgid on group_messages_files( group_id,msg_id,fsid);

CREATE UNIQUE INDEX i_group_people_giduk on group_people(group_id,uk);

CREATE UNIQUE INDEX i_misc_seckey on miscellaneous(section,key);

CREATE UNIQUE INDEX i_people_messsages_files_uknativemsgid on people_messages_files(conversation_uk,msg_native_id,fsid) WHERE msg_native_id IS NOT NULL;

CREATE UNIQUE INDEX i_people_messsages_ukmsgid on people_messages(conversation_uk,msg_id);

CREATE UNIQUE INDEX i_people_messsages_uknativemsgid on people_messages(conversation_uk,msg_native_id) WHERE msg_native_id IS NOT NULL;

CREATE UNIQUE INDEX i_people_messsage_files_ukmsgid on people_messages_files( conversation_uk,msg_id,fsid);

CREATE TRIGGER tr_group_delete_for_lastmsgtime AFTER DELETE ON groups FOR EACH ROW BEGIN DELETE FROM group_message_last_time WHERE group_message_last_time.group_id = OLD.group_id ; END;

CREATE TRIGGER tr_group_insert_for_lastmsgtime AFTER INSERT ON groups FOR EACH ROW WHEN NEW.removed_by_admin=0 BEGIN INSERT OR IGNORE INTO group_message_last_time(group_id) values(NEW.group_id); END;

CREATE TRIGGER tr_group_message_delete_for_conversation AFTER DELETE ON conversations FOR EACH ROW WHEN OLD.conversation_type=1 BEGIN DELETE FROM group_messages WHERE group_id=OLD.group_id_conversation_uk; END;

CREATE TRIGGER tr_group_message_files_delete_for_group_message AFTER DELETE ON group_messages FOR EACH ROW BEGIN DELETE FROM group_messages_files WHERE group_id=OLD.group_id AND (msg_id=OLD.msg_id OR msg_native_id=OLD.msg_native_id); END;

CREATE TRIGGER tr_group_people_del_for_groupid AFTER DELETE ON groups FOR EACH ROW BEGIN DELETE FROM group_people WHERE group_people.group_id = OLD.group_id ; END;

CREATE TRIGGER tr_group_update_for_lastmsgtime AFTER INSERT ON groups FOR EACH ROW WHEN NEW.removed_by_admin<>0 BEGIN DELETE FROM group_message_last_time WHERE group_message_last_time.group_id = NEW.group_id ; END;

CREATE TRIGGER tr_people_message_delete_for_conversation AFTER DELETE ON conversations FOR EACH ROW WHEN OLD.conversation_type=2 BEGIN DELETE FROM people_messages WHERE conversation_uk=OLD.group_id_conversation_uk; END;

CREATE TRIGGER tr_people_message_files_delete_for_people_message AFTER DELETE ON people_messages FOR EACH ROW BEGIN DELETE FROM people_messages_files WHERE conversation_uk=OLD.conversation_uk AND (msg_id=OLD.msg_id OR msg_native_id=OLD.msg_native_id); END;

