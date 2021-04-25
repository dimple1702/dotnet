using FoodAppDO.Interface;
using FoodAppEntity.CustomModel;
using FoodAppEntity.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodAppDO
{
    public class FoodAppDataAccess : IFoodAppDataAccess
    {
        private readonly FoodAppDbContext _foodAppDbContext;

        public FoodAppDataAccess(FoodAppDbContext foodAppDataAccess)
        {
            _foodAppDbContext = foodAppDataAccess;
        }

        public User AuthenticateUser(User user)
        {
            User userObj = (User)_foodAppDbContext.Users.FirstOrDefault(x => x.UserEmail == user.UserEmail && x.Password == user.Password);
            if (userObj != null)
            {
                return userObj;
            }
            return null;
        }
        public List<Menu> GetMenuList()
        {
            return _foodAppDbContext.Menus.ToList();
        }

        public List<OrderCategoryModel> GetMenuItemById(long menuId)
        {
            List<OrderCategoryModel> model;
            try
            {
                model = _foodAppDbContext.OrderCategoryModel.FromSqlRaw("[dbo].[spGetMenuCategoryDetailById] @menuId",
                    new SqlParameter("@menuId", menuId)).ToList();
            }
            catch (Exception e)
            {
                model = null;
                Console.WriteLine(e);
            }
            return model;
        }

        public int AddTableReservation(ReservationDetails details)
        {
            if(details == null)
            {
                return 0;
            }
            _foodAppDbContext.ReservationDetails.Add(details);
            return _foodAppDbContext.SaveChanges();
        }

        public int AddPaymentDetails(PaymentDetails details)
        {
            //details.UserId = 1;
            _foodAppDbContext.PaymentDetails.Add(details);
            return _foodAppDbContext.SaveChanges();
        }

        public List<OrderHistoryModel> ShowOrderHistory(long userId)
        { 
            List<OrderHistoryModel> model;
            try
            {
                model = _foodAppDbContext.OrderHistoryModel.FromSqlRaw("[dbo].[spGetOrderHistoryById] @userId",
                    new SqlParameter("@userId", userId)).ToList();
            }
            catch (Exception e)
            {
                model = null;
                Console.WriteLine(e);
            }
            return model;
        }

        //Pagination using Stored Procedure
        public List<Menu> Pagination(int PageNumber, int PageSize, List<Menu> menu)
        {
            try
            {
                menu = _foodAppDbContext.Menus.FromSqlRaw("exec [dbo].[spMenuPagination] " + PageNumber + "," + PageSize).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return menu;
        }

        public Menu GetFoodItemById(long menuId)
        {
            return _foodAppDbContext.Menus.FirstOrDefault(m => m.MenuId == menuId);
        }

        public List<PaymentMethod> GetPaymentMethodList()
        {
            return _foodAppDbContext.PaymentMethods.ToList();
        }
    }
}
