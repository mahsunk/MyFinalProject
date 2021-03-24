using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = ("Ürün eklendi");
        public static string ProductUpdate = ("Ürün Güncellendi");
        public static string ProductNameInvalid = ("Ürün ismi geçersiz");
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";

        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 3 Ürün Olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "15 kategoriden fazla kategori olamaz";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered= "Kullanıcı Kayıtlı";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatası";
        public static string SuccessfulLogin= "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Token başarıyla oluşturuldu";
    }
}
