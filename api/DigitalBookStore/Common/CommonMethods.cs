
using System;
using System.Text;

namespace DigitalBookStore.Common
{
    public static class CommonMethods
    {
        public static string getRoleType(int id)
        {
            switch (id)
            {
                case 0:
                    return "owner";
                    break;

                case 1:
                    return "visitor";
                    break;
                case 2:
                    return "coowner";
                    break;

                default:
                    return "";

            }
        }
    }
}
