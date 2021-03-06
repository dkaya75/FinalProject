﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";

        public static string ProductCountOfCategoryError = "En fazla 10 ürün alabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten isim var";

        public static string CategoryLimitExceed = "Limit aşıldı";
    }
}
