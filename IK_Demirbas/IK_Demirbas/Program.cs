namespace BID_Demirbas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            FormManager.LoginForm = new Login();
            FormManager.Form1Instance = new Form1();
            FormManager.StaffInstance = new StaffList();
            FormManager.DeleteStaffInstance = new DeleteItemFromStaff();
            FormManager.ItemInstance = new ItemList();
            FormManager.ChangeStaffInfoInstance = new ChangeStaffInfo();
            FormManager.AddItemStaffInstance = new AddItemToStaff();
            FormManager.AddItemInstance = new AddItem();
            FormManager.DeleteItemInstance = new DeleteItem();
            Application.Run(FormManager.LoginForm);
        }
    }
}