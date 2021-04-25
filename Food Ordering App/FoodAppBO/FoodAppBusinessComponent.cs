using FoodAppBO.Interface;
using FoodAppDO.Interface;
using FoodAppEntity.CustomModel;
using FoodAppEntity.Entities;
using System;
using System.Collections.Generic;

namespace FoodAppBO
{
    public class FoodAppBusinessComponent : IFoodAppBusinessComponent
    {
        private readonly IFoodAppDataAccess _foodAppDataAccess;

        public FoodAppBusinessComponent(IFoodAppDataAccess foodAppDataAccess)
        {
            _foodAppDataAccess = foodAppDataAccess;
        }

        public int AddPaymentDetails(PaymentDetails details)
        {
            return _foodAppDataAccess.AddPaymentDetails(details);
        }

        public int AddTableReservation(ReservationDetails details)
        {
            return _foodAppDataAccess.AddTableReservation(details);
        }

        public User AuthenticateUser(User user)
        {
            return _foodAppDataAccess.AuthenticateUser(user);
        }

        public Menu GetFoodItemById(long menuId)
        {
            return _foodAppDataAccess.GetFoodItemById(menuId);
        }

        public List<OrderCategoryModel> GetMenuItemById(long menuId)
        {
            return _foodAppDataAccess.GetMenuItemById(menuId);
        }

        public List<Menu> GetMenuList()
        {
            return _foodAppDataAccess.GetMenuList();
        }

        public List<PaymentMethod> GetPaymentMethodList()
        {
            return _foodAppDataAccess.GetPaymentMethodList();
        }

        public List<Menu> Pagination(int PageNumber, int PageSize, List<Menu> menu)
        {
            return _foodAppDataAccess.Pagination(PageNumber, PageSize, menu);
        }

        public List<OrderHistoryModel> ShowOrderHistory(long userId)
        {
            return _foodAppDataAccess.ShowOrderHistory(userId);
        }
    }
}
