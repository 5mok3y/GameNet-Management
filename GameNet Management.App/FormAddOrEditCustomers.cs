using GameNet_Management.DataLayer;
using GameNet_Management.DataLayer.Context;
using GameNet_Management.Utilities.Convertors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace GameNet_Management.App
{
    public partial class FormAddOrEditCustomers : Form
    {

        DateTime customerRegDate;
        private int? _customerID; // null for add customer and else for edit the customer(ID)
        public FormAddOrEditCustomers(int? customerID)
        {
            InitializeComponent();
            _customerID = customerID;
        }

        private void txtCustomerPhone_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                int firstPosition = 0;
                if (this.txtCustomerPhone.MaskCompleted == false)
                {
                    this.txtCustomerPhone.Select(firstPosition, 0);
                }
            });
        }

        private void FormAddOrEditCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                if (!_customerID.HasValue) // add mode
                {
                    this.lblCustomerRegDate.Visible = false;
                    this.lblCustomerRegDateValue.Visible = false;
                    this.chbIsActive.Checked = true;
                }
                else
                {
                    this.btnSubmit.Text = "ویرایش";
                    Customers selectedCustomer = new Customers();
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        selectedCustomer = db.CustomerRepository.GetByID(_customerID.Value);
                    }
                    this.txtCustomerName.Text = selectedCustomer.FullName;
                    this.txtCustomerPhone.Text = selectedCustomer.Phone;
                    this.txtCustomerDescription.Text = selectedCustomer.Description;
                    this.chbIsActive.Checked = selectedCustomer.IsActive;
                    this.lblCustomerRegDateValue.Text = selectedCustomer.RegisterDate.ToShamsi();
                    customerRegDate = selectedCustomer.RegisterDate;
                }
            }
            catch
            {
                RtlMessageBox.Show("خطای غیرمنتظره‌ای رخ داد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                try
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        string phoneNumber = "09" + txtCustomerPhone.Text;

                        if (db.CustomerRepository.IsPhoneExists(phoneNumber))
                        {

                            if (!_customerID.HasValue)
                            {
                                RtlMessageBox.Show("این شماره تلفن قبلاً برای شخص دیگری ثبت شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                var selectedCustomer = db.CustomerRepository.GetByPhone(phoneNumber);
                                if (selectedCustomer.CustomerID != _customerID.Value)
                                {
                                    RtlMessageBox.Show("این شماره تلفن قبلاً برای شخص دیگری ثبت شده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        if (!_customerID.HasValue) //add mode
                        {
                            Customers customerToAdd = new Customers()
                            {
                                FullName = txtCustomerName.Text,
                                Phone = phoneNumber,
                                Description = txtCustomerDescription.Text,
                                IsActive = chbIsActive.Checked,
                                RegisterDate = DateTime.Now
                            };
                            db.CustomerRepository.Insert(customerToAdd);
                        }

                        else //edit mode
                        {
                            var customerToUpdate = db.CustomerRepository.GetByID(_customerID.Value);
                            customerToUpdate.FullName = txtCustomerName.Text;
                            customerToUpdate.Phone = phoneNumber;
                            customerToUpdate.Description = txtCustomerDescription.Text;
                            customerToUpdate.IsActive = chbIsActive.Checked;
                            customerToUpdate.RegisterDate = customerRegDate;
                            db.CustomerRepository.Update(customerToUpdate);
                        }
                        db.Save();
                    }

                    DialogResult = DialogResult.OK;
                }

                catch
                {
                    RtlMessageBox.Show("خطا در ثبت اطلاعات مشتری", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void ValidPhone_OnValidate(object sender, EventArgs e)
        {
            if (this.txtCustomerPhone.MaskCompleted)
            {
                ValidPhone.IsValidated = true;
            }
            else
            {
                ValidPhone.IsValidated = false;
            }
        }
    }
}