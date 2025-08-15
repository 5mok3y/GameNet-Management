using GameNet_Management.DataLayer;
using GameNet_Management.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNet_Management.App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            bool isFirstRun;

            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    isFirstRun = !db.PersonnelRepository.Get().Any();
                }
            }
            catch (Exception)
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد، برنامه بسته می‌شود", "خطای بحرانی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            if (isFirstRun)
            {
                using (FormAuth formFirstAdmin = new FormAuth())
                {
                    formFirstAdmin.isInsert = true;
                    formFirstAdmin.isFirstUser = true;                   

                    if (formFirstAdmin.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                }
            }


            while (true)
            {                
                using (FormAuth formLogin = new FormAuth())
                {
                    if (formLogin.ShowDialog() != DialogResult.OK)
                    {
                        break;
                    }
                }

                using (FormMain formMain = new FormMain())
                {
                    if (formMain.ShowDialog() != DialogResult.Retry)
                    {
                        break;
                    }
                }
            }
        }
    }
}
