using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistic_Table
{
    internal class PartialProsecution
    {
        public int ID { get; set; }
        public int Code { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }   // الحقل "None" (bit) → نستخدمه كـ Status/مفعل
        public byte[] Note { get; set; }     // varbinary(100) → يمكن استخدامه لحفظ بيانات إضافية
    }
}
