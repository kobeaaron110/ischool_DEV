using System;
using System.Collections.Generic;
using System.Text;
using SmartSchool.Customization.PlugIn.Report;
using SmartSchool.Customization.PlugIn;
using FISCA.Presentation;


namespace 特殊學生清單
{
    public class SpecicalStudent
    {
        public SpecicalStudent()
        {
            MotherForm.RibbonBarItems["班級", "資料統計"]["報表"]["高苑報表"]["德行特殊學生清單"].Click += new EventHandler(SpecicalStudent_Click);
        }

        void SpecicalStudent_Click(object sender, EventArgs e)
        {
            frmSpecialStudent SpecialStudentForm = new frmSpecialStudent();
            SpecialStudentForm.ShowDialog();
        }
    }
}
