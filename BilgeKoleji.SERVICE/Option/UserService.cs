using BilgeKoleji.MODEL.Entities;
using BilgeKoleji.SERVICE.Base;


namespace BilgeKoleji.SERVICE.Option
{
    public class UserService: BaseService<User>
    {
        public bool CheckUser(string _username, string _password)
        {
            return Any(x => x.UserName == _username && x.Password == _password && x.IsActive == true);
        }
    }
}
