using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string InvalidCarName = "Araba adı en az 2 karakter olmalıdır!";
        public static string InvalidDailyPrice = "Günlük fiyat 0'dan büyük olmalıdır!";
        public static string CarAdded = "Araba eklendi!";
        public static string CarUpdated = "Araba güncellendi!";
        public static string CarDeleted = "Araba silindi!";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated { get; set; }
        public static string UserDeleted { get; set; }
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated { get; set; }
        public static string CustomerDeleted { get; set; }
        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalUpdated { get; set; }
        public static string RentalDeleted { get; set; }
        public static string DefaultImageShown = "Default resim gösterildi";

        public static string ImageDeletedSuccesfully = "Resim silme başarılı";

        public static string ImagesUploadedSuccesfully = "Resim yükleme başarılı";
        public static string ImagesUpdatedSuccesfully = "Resim güncelleme başarılı";

        public static string CarImagesCountFull = "Bir araç için en fazla 5 resim yüklenebilir";

        public static string CarCanBeRented = "Araba kiralanabilir";
        public static string CarAlreadyRented = "Araba zaten kirada";
    }
}
