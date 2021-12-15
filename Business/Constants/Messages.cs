using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        
        public static string Added = "eklendi.";
        public static string Deleted = "silindi.";
        public static string Updated = "güncellendi.";
        public static string Listed = "listelendi.";
        public static string Detail = "detay getirildi.";
        public static string NameInvalid = "isim geçersiz.";
        public  static string MaintenanceTime = "Sistem Bakımda";

        //Customer
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerDetail = "Müşteri Detayı Getirildi";
        public static string CustomerListed = "Müşteri Listelendi";
        internal static string CustomerNameInvalid = "Müşşteri ismi geçersiz";

        //User
        public static string UserAdded = "Kulanıcı Eklendi";
        public static string UserDeleted = "Kulanıcı Silindi";
        public static string UserUpdate = "Kulanıcı Güncellendi";
        public static string UserDetail = "Kulanıcı Detayı Getirildi";
        public static string UserListed = "Kulanıcı Listelendi";
        internal static string UserNameInvalid = "Kulanıcı ismi geçersiz";

        // Rental
        public static string RentalAdded = "Kiralama Eklendi";
        public static string RentalDeleted = "Kiralama Silindi";
        public static string RentalUpdate = "Kiralama Güncellendi";
        public static string RentalDetail = "Kiralama Detayı Getirildi";
        public static string RentalListed = "Kiralama Listelendi";
        internal static string RentalNameInvalid = "Kiralama ismi geçersiz";

        // Rental
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdate = "Renk Güncellendi";
        public static string ColorDetail = "Renk Detayı Getirildi";
        public static string ColorListed = "Renk Listelendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string  AuthorizationDenied = "Yetkin yok";
    }
}
