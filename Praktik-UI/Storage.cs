using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StorageClass
{
    static class Storage
    {
    public static SupplierClass.Supplier Auto_Doc = new SupplierClass.Supplier("Auto-Doc","г. Москва, ул. Новорежская, д.14, к. 1", "+74997410240");
    public static SupplierClass.Supplier CarHelp = new SupplierClass.Supplier("Carhelp" , "г. Ростов-на-Дону, ул. Центральная д. 3" , "+79538881234");
    public static SupplierClass.Supplier Vehicle_Tuning = new SupplierClass.Supplier("Vehicle-Tuning" , "г. Краснодар, ул. Володи Головатого д. 91" , "+79208886899");
    public static List<PartClass.Part> PartList = new List<PartClass.Part> { };
    public static List<PartClass.Part> Cart = new List<PartClass.Part> { };
        public static List<PartClass.Part> IDCheck=new List<PartClass.Part> { };
        public static List<PartClass.Part>SupplierCheck=new List<PartClass.Part> { };
    }
}