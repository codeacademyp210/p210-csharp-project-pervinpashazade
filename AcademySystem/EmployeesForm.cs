using AcademySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademySystem
{
    public partial class EmployeesForm : Form
    {
        EmployeesForm newEmployees = new EmployeesForm();
        public EmployeesForm()
        {
            InitializeComponent();
            GenerateEmpForm();
            FillEmpForm();
        }

        private void GenerateEmpForm()
        {
            dgvEmpForm.Rows.Clear();

            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                List<Employee> employeesForm = db.Employees.Where(e => e.Status == true).ToList();

                foreach (var empForm in employeesForm)
                {
                    dgvEmpForm.Rows.Add(empForm.ID,
                                        empForm.Name,
                                        empForm.Surname,
                                        empForm.Email,
                                        empForm.Phone,
                                        empForm.PositionID);
                }
            }

            btnDeleteEdu.Enabled = false;
        }

        private void FillEmpForm()
        {
            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {
                db.Employees.ToList();
            }
        }

        private bool CreateEmployees()
        {
            int affectRows = 0;
            using (AcademySystemEntities1 db = new AcademySystemEntities1())
            {

                Employee employee = new Employee()
                {
                    Name = txtNameEmp.Text,
                    Surname = txtSurnameEmp.Text,
                    Email = txtEmailEmp.Text,
                    Phone = txtPhoneEmp.Text,
                    //PositionID = cmbPositionEmp.Text.ToString();
                    StartTime = dateTimeStartTime.Value,
                    Status = true
                };

                db.Employees.Add(employee);

                affectRows = db.SaveChanges();
            }
            if (affectRows > 0)
            {
                return true;
            }

            return false;
        }

        //private bool UpdateEduProg()
        //{
        //    int affectRows = 0;
        //    using (AcademySystemEntities1 db = new AcademySystemEntities1())
        //    {
        //        Models.Employee newEmpProg = db.EducationPrograms.Where(e => e.ID == newEmployees.ID).FirstOrDefault();

        //        newEmpProg.Name = txtNameEmp.Text;

        //        affectRows = db.SaveChanges();
        //    }
        //    if (affectRows > 0)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

    }
}
