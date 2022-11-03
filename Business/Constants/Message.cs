using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Message
    {
        public static string SuccessAdded = "Ekleme İşlemi Tamamlanmıştır";
        public static string SuccessUpdated = "Güncelleme İşlemi Gerçekleştirilmiştir";
        public static string SuccessDeleted = "Silme İşlemi gerçekleşmiştir";
        public static string SuccessGet = "get işlemi başarıyla gerçekleşmiştir";
        public static string ErrorAdded = "Ekleme İşlemi işleminde sıkıntı oluşmuştur";
        public static string ErrorUpdated = "Güncelleme işleminde sıkıntı oluşmuştur";
        public static string ErrorDeleted = "Silme işleminde sıkıntı oluşmuştur ";
        public static string ErrorGet = "get işleminde sıkıntı oluşmuştur";
    }
}
