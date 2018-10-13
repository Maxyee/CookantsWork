using CookantsEntity.Model;

namespace CoockantsWeb.Helper
{
    public static class SelectQuery
    {
        public static SecurityUser GetUser(SecurityUser u)
        {
            u.Password = null;
            u.DeviceToken = null;
            u.DeviceType = null;
            u.Access_Token = null;
            u.FileName = null;
            u.FileExtention = null;
            return u;
        }
    }
}