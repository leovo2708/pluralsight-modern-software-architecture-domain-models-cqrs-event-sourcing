using Module5.Regular.Server.Models;

namespace Module5.Regular.Server.ApplicationLayer.Abstractions
{
    public interface IAdminService
    {
        RegisterViewModel GetAdminViewModel();
        void Register(RegisterInputModel input);
    }
}