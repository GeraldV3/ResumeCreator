using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace Resume_Creator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string filname = "resumeinformation.json";
            string jsonstring = File.ReadAllText(filname);
            ResumeInformation resume = JsonSerializer.Deserialize<ResumeInformation>(jsonstring);
        }
    }
    public class ResumeInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Picture { get; set; }
        public string HomeAddress { get; set; }
        public string PostalCode { get; set; }
        public string Municipality { get; set; }
        public string Province { get; set; }
        public string College { get; set; }
        public string Course { get; set; }
        public string CollegeGraduated { get; set; }
        public string SeniorHighSchool { get; set; }
        public string Strand { get; set; }
        public string SeniorHighSchoolGraduated { get; set; }
        public string HighSchool { get; set; }
        public string HighSchoolGraduated { get; set; }
        public string Achievement { get; set; }
        public string Achievement1 { get; set; }
        public string Experience { get; set; }
        public string Contain { get; set; }
        public string Contain1 { get; set; }
        public string Contain2 { get; set; }
        public string Skills { get; set; }
        public string Skills1 { get; set; }
        public string Skills2 { get; set; }
        public string Skills3 { get; set; }
        public string Skills4 { get; set; }
        public string Skills5 { get; set; }
        public string Hobby { get; set; }
        public string Hobby1 { get; set; }
        public string Hobby2 { get; set; }
        public string Hobby3 { get; set; }
    }
}
