using System.Data.Common;

namespace 영상뷰어.Interfaces
{
    public interface IDataBase
    {
        void Connect();
        void Disconnect();
        DbDataReader ExcuteSql(string sql); 
    }
}
