﻿using FISCA;
using FISCA.Presentation;

namespace JHSchool.Affair
{
    public static class Program
    {
        [MainMethod("JHSchool.Affair")]
        public static void Main()
        {
            RegisterTab();
        }

        public static void RegisterTab()
        {
            MotherForm.AddPanel(EduAdmin.Instance);
            MotherForm.AddPanel(StuAdmin.Instance);
        }
    }
}