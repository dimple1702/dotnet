using FoodAppEntity.CustomModel;
using FoodAppEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAppDO.Interface
{
    public interface IFoodAppDataAccess
    {
        User AuthenticateUser(User user);
        List<Menu> GetMenuList();
        List<OrderCategoryModel> GetMenuItemById(long menuId);
        int AddTableReservation(ReservationDetails details);
        int AddPaymentDetails(PaymentDetails details);
        List<OrderHistoryModel> ShowOrderHistory(long userId);
        List<Menu> Pagination(int PageNumber, int PageSize, List<Menu> menu);
        Menu GetFoodItemById(long menuId);
        List<PaymentMethod> GetPaymentMethodList();
    }
}
