using GameNet_Management.DataLayer;
using GameNet_Management.DataLayer.Context;
using GameNet_Management.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNet_Management.App
{
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
        }

        private void FailedMessage(string messageTitle)
        {
            RtlMessageBox.Show("عملیات ناموفق", messageTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void SuccessMessage(string messageTitle)
        {
            RtlMessageBox.Show("عملیات با موفقیت انجام شد", messageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BindServicesGrid()
        {
            dgvServices.AutoGenerateColumns = false;
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    dgvServices.DataSource = db.ServicesRepository.Get();
                }
            }
            catch
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void BindServiceOptionsGrid(int serviceID)
        {
            try
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var optionsList = db.ServiceOptionsRepository.Get(so => so.ServiceID == serviceID);
                    var optionsDataList = optionsList.Select(o => new ServiceOptionsDataViewModel()
                    {
                        OptionID = o.OptionID,
                        Description = o.Description,
                        PricePerHour = (int)o.PricePerHour
                    }
                    ).ToList();
                    dgvServiceOptions.AutoGenerateColumns = false;
                    dgvServiceOptions.DataSource = optionsDataList;
                }
            }
            catch
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void FormServices_Load(object sender, EventArgs e)
        {
            BindServicesGrid();
        }

        private void dgvServices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServices.CurrentRow != null)
            {
                int selectedServiceID = int.Parse(dgvServices.CurrentRow.Cells["ServiceID"].Value.ToString());
                BindServiceOptionsGrid(selectedServiceID);
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (dgvServices.CurrentRow != null)
            {
                FormAddOrEditServices formAddServices = new FormAddOrEditServices(null);
                if (formAddServices.ShowDialog() == DialogResult.OK)
                {
                    SuccessMessage("افزودن سرویس");
                    BindServicesGrid();
                }
            }
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            PerformServiceEdit();
        }

        private void PerformServiceEdit()
        {
            if (dgvServices.CurrentRow != null)
            {
                int serviceID = int.Parse(dgvServices.CurrentRow.Cells["ServiceID"].Value.ToString());
                FormAddOrEditServices formEditServices = new FormAddOrEditServices(serviceID);               
                if (formEditServices.ShowDialog() == DialogResult.OK)
                {
                    SuccessMessage("ویرایش سرویس");
                    BindServicesGrid();
                }
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (dgvServices.CurrentRow != null)
            {
                try
                {
                    var selectedServiceID = int.Parse(dgvServices.CurrentRow.Cells["ServiceID"].Value.ToString());
                    var selectedServiceName = dgvServices.CurrentRow.Cells["ServiceName"].Value.ToString();

                    if (RtlMessageBox.Show($"آیا از حذف کردن این سرویس اطمینان دارید؟ \n {selectedServiceName}", "حذف کردن سرویس", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            if (db.ServiceOptionsRepository.Get(so => so.ServiceID == selectedServiceID).Any())
                            {
                                RtlMessageBox.Show("شما نمی‌توانید این سرویس را حذف کنید، این سرویس دارای مقدار در تعرفه ها می‌باشد" + "\n" + "لطفا ابتدا اقدام به حذف تعرفه(ها) کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                db.ServicesRepository.Delete(selectedServiceID);
                                db.Save();
                                BindServicesGrid();
                            }
                        }
                    }
                }
                catch
                {
                    FailedMessage("حذف کردن سرویس");
                    return;
                }
            }
        }

        private void btnAddOption_Click(object sender, EventArgs e)
        {
            if (dgvServiceOptions.CurrentRow != null)
            {
                FormAddOrEditOptions formAddOptions = new FormAddOrEditOptions(null);
                if (formAddOptions.ShowDialog() == DialogResult.OK)
                {
                    SuccessMessage("افزودن تعرفه");
                    BindServicesGrid();
                }
            }
        }

        private void btnEditOption_Click(object sender, EventArgs e)
        {
            PerformOptionEdit();
        }

        private void PerformOptionEdit()
        {
            if (dgvServiceOptions.CurrentRow != null)
            {
                int optionID = int.Parse(dgvServiceOptions.CurrentRow.Cells["OptionID"].Value.ToString());
                FormAddOrEditOptions formEditOptions = new FormAddOrEditOptions(optionID);
                if (formEditOptions.ShowDialog() == DialogResult.OK)
                {
                    SuccessMessage("ویرایش تعرفه");
                    int selectedServiceID = int.Parse(dgvServices.CurrentRow.Cells["ServiceID"].Value.ToString());
                    BindServiceOptionsGrid(selectedServiceID);
                }
            }
        }

        private void btnDeleteOption_Click(object sender, EventArgs e)
        {
            if (dgvServiceOptions.CurrentRow != null)
            {
                try
                {
                    var selectedOptionID = int.Parse(dgvServiceOptions.CurrentRow.Cells["OptionID"].Value.ToString());
                    var selectedOptionName = dgvServiceOptions.CurrentRow.Cells["OptionDescription"].Value.ToString();

                    if (RtlMessageBox.Show($"آیا از حذف کردن این گزینه اطمینان دارید؟ \n {selectedOptionName}", "حذف کردن تعرفه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            if (db.SessionsRepository.Get(s => s.OptionID == selectedOptionID).Any())
                            {
                                RtlMessageBox.Show("شما نمی‌توانید این گزینه را حذف کنید، این نوع تعرفه در گزارش ها مورد استفاده قرار گرفته است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                db.ServiceOptionsRepository.Delete(selectedOptionID);
                                db.Save();
                                int selectedServiceID = int.Parse(dgvServices.CurrentRow.Cells["ServiceID"].Value.ToString());
                                BindServiceOptionsGrid(selectedServiceID);
                            }
                        }
                    }
                }
                catch
                {
                    FailedMessage("حذف کردن تعرفه");
                    return;
                }
            }
        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PerformServiceEdit();
        }

        private void dgvServiceOptions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PerformOptionEdit();
        }
    }
}
