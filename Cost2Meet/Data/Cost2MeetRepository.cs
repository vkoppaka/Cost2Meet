using System;
using SQLite.Net.Async;
using SQLite.Net.Interop;
using SQLite.Net;

namespace Cost2Meet
{
	public class Cost2MeetRepository
	{
		private SQLiteAsyncConnection dbConn;

		public Cost2MeetRepository ( ISQLitePlatform platform, string dbPath )
		{
			var connectionFunc = new Func<SQLiteConnectionWithLock> ( ( ) =>
				new SQLiteConnectionWithLock (
					platform,
					new SQLiteConnectionString ( dbPath, false )
				)
			);

			dbConn = new SQLiteAsyncConnection ( connectionFunc );
			dbConn.CreateTableAsync<MeetingHistory>( );
		}
	}
}