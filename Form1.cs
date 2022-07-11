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
            string filename = "resumeinformation.json";
            string JSONFILE = File.ReadAllText(filename);
            ResumeInformation Resume = JsonSerializer.Deserialize<ResumeInformation>(JSONFILE);

            //Basic Information
            string FirstName = Resume.FirstName;
            string LastName = Resume.LastName;
            string MiddleName = Resume.MiddleName;
            //Address
            string HomeAdress = Resume.HomeAddress;
            string PostalCode = Resume.PostalCode;
            string Municipality = Resume.Municipality;
            string Province = Resume.Province;
            //Education
            string College = Resume.College;
            string Courge = Resume.Course;
            string CollegeGraduated = Resume.CollegeGraduated;
            string SeniorHighSchool = Resume.SeniorHighSchool;
            string Strand = Resume.Strand;
            string SeniorHighSchoolGraduated = Resume.SeniorHighSchoolGraduated;
            string HighSchool = Resume.HighSchool;
            //Achievement
            string Achievement = Resume.Achievement;
            string Achievement1 = Resume.Achievement1;
            //Experience
            string Experience = Resume.Experience;
            string Contain = Resume.Contain;
            string Contain1 = Resume.Contain1;
            string Contain2 = Resume.Contain2;
            //Skills
            string Skills = Resume.Skills;
            string Skills1 = Resume.Skills1;
            string Skills2 = Resume.Skills2;
            string Skills3 = Resume.Skills3;
            string Skills4 = Resume.Skills4;
            string Skills5 = Resume.Skills5;
            //Hobby
            string Hobby = Resume.Hobby;
            string Hobby1 = Resume.Hobby1;
            string Hobby2 = Resume.Hobby2;
            string Hobby3 = Resume.Hobby3;
        }
    }
    public class ResumeInformation
    {
        //Basic Information
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        //Address
        public string HomeAddress { get; set; }
        public string PostalCode { get; set; }
        public string Municipality { get; set; }
        public string Province { get; set; }
        //Education
        public string College { get; set; }
        public string Course { get; set; }
        public string CollegeGraduated { get; set; }
        public string SeniorHighSchool { get; set; }
        public string Strand { get; set; }
        public string SeniorHighSchoolGraduated { get; set; }
        public string HighSchool { get; set; }
        public string HighSchoolGraduated { get; set; }
        //Achievement
        public string Achievement { get; set; }
        public string Achievement1 { get; set; }
        //Experience
        public string Experience { get; set; }
        public string Contain { get; set; }
        public string Contain1 { get; set; }
        public string Contain2 { get; set; }
        //Skills
        public string Skills { get; set; }
        public string Skills1 { get; set; }
        public string Skills2 { get; set; }
        public string Skills3 { get; set; }
        public string Skills4 { get; set; }
        public string Skills5 { get; set; }
        //Hobby
        public string Hobby { get; set; }
        public string Hobby1 { get; set; }
        public string Hobby2 { get; set; }
        public string Hobby3 { get; set; }
    }
}
