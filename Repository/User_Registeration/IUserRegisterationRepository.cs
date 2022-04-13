using bearing_catalog.Models;

namespace bearing_catalog.Repository.User_Registeration
{
    public interface IUserRegisterationRepository
    {
        Response AddUserRegisteration(user_registeration obj_user_registeration);
        Response GetUserRegisteration();
    }
}