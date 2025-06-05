using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BID_Demirbas
{
    public static class FormManager
    {
        public static Login LoginForm { get; set; }
        public static Form1 Form1Instance { get; set; }
        public static StaffList StaffInstance { get; set; }
        public static ItemList ItemInstance { get; set; }
        public static DeleteItemFromStaff DeleteStaffInstance { get; set; }
        public static AddItemToStaff AddItemStaffInstance { get; set; }
        public static ChangeStaffInfo ChangeStaffInfoInstance { get; set; }
        public static AddItem AddItemInstance { get; set; }
        public static DeleteItem DeleteItemInstance { get; set; }
        // This method ensures that the form is shown and not disposed.
        public static void ShowForm(Form form)
        {
            if (form.IsDisposed)
            {
                form = (Form)Activator.CreateInstance(form.GetType());
            }
            form.Show();
        }
    }
}
