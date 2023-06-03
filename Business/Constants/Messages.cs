using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Bakımda";
        public static string ProductListed="Ürünler Listelendi";
        public static string OrderListed = "Siparişler Listelendi";
        public static string CustomerListed = "Müşteriler Listelendi";
        public static string CategoryListed = "Kategoriler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";

        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün bulunuyor";

        public static string CategoryLimitExceded = "Kategory limiti aşıldığı için yeni ürün eklenemiyor";
        internal static string AuthorizationDenied="Yetkiniz Yok";
        internal static string UserRegistered="Kayıt olundu";
        internal static string UserNotFound="Kullanıcı bulunamadı";
        internal static string PasswordError="Parola Hatası";
        internal static string SuccessfulLogin="Başarılı giriş";
        internal static string UserAlreadyExists="Kullanıcı Mevcut";
        internal static string AccessTokenCreated="Token oluşturuldu";
    }
}
