using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.Json;
using System.IO;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace Resume_Creator
{
    public partial class MainForm : Form
    {
        private readonly string path = @"C:\Users\pc\Desktop\Resume Creator\ResumeInformation.json";
        public MainForm()
        {
            InitializeComponent();
        }
        private void Read_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonFromFile;
                using (var readr = new StreamReader(path))
                {
                    jsonFromFile = readr.ReadToEnd();
                }
                ResumeInformation Resume = JsonSerializer.Deserialize<ResumeInformation>(jsonFromFile);
                //Basic Information
                string firstname = Resume.firstname;
                string lastname = Resume.lastname;
                string middlename = Resume.middlename;
                string Email = Resume.email;
                string phonenumber = Resume.phonenumber;
                //Address
                string homeaddress = Resume.homeaddress;
                string postalcode = Resume.postalcode;
                string municipality = Resume.municipality;
                string province = Resume.province;
                //Education
                string college = Resume.college;
                string courge = Resume.course;
                string collegegraduated = Resume.collegegraduated;
                string seniorhighschool = Resume.seniorhighschool;
                string strand = Resume.strand;
                string seniorhighschoolgraduated = Resume.seniorhighschoolgraduated;
                string highschool = Resume.highschool;
                //Achievement
                string achievement = Resume.achievement;
                string achievement1 = Resume.achievement1;
                //Experience
                string experience = Resume.experience;
                string contain = Resume.contain;
                string contain1 = Resume.contain1;
                string contain2 = Resume.contain2;
                //Skills
                string skills = Resume.skills;
                string skills1 = Resume.skills1;
                string skills2 = Resume.skills2;
                string skills3 = Resume.skills3;
                string skills4 = Resume.skills4;
                string skills5 = Resume.skills5;
                //Hobby
                string hobby = Resume.hobby;
                string hobby1 = Resume.hobby1;
                string hobby2 = Resume.hobby2;
                string hobby3 = Resume.hobby3;

                FirstName_LBL.Text = "First Name: " + Resume.firstname;
                LastName_LBL.Text = "Last Name: " + Resume.lastname;
                MiddleName_LBL.Text = "MiddleName: " + Resume.middlename;
                Email_LBL.Text = "Email: " + Resume.email;
                PhoneNumber_LBL.Text = "PhoneNumber: " + Resume.phonenumber;
                HomeAddress_LBL.Text = "HomeAddress: " + Resume.homeaddress;
                Postal_LBL.Text = "Postal: " + Resume.postalcode;
                Municipality_LBL.Text = "Municipality: " + Resume.municipality;
                Province_LBL.Text = "Provicne: " + Resume.province;
                College_LBL.Text = "College: " + Resume.college;
                Course_LBL.Text = "Course: " + Resume.course;
                GraduatedYear_LBL.Text = "GreaduatedYear: " + Resume.collegegraduated;
                SHS_LBL.Text = "SeniorHighSchool: " + Resume.seniorhighschool;
                Strand_LBL.Text = "Strand: " + Resume.strand;
                GraduatedYear1_LBL.Text = "GreaduatedYear: " + Resume.seniorhighschoolgraduated;
                HS_LBL.Text = "High School: " + Resume.highschool;
                GraduatedYear2_LBL.Text = "GraduatedYear: " + Resume.highschoolgraduated;
                Achievement_LBL.Text = "Achievement: " + Resume.achievement;
                Achievement1_LBL.Text = "Achievement: " + Resume.achievement1;
                Experience_LBL.Text = "Exprience: " + Resume.experience;
                Contain_LBL.Text = "Contain: " + Resume.contain;
                Contain1_LBL.Text = "Contain: " + Resume.contain1;
                Contain2_LBL.Text = "Contain: " + Resume.contain2;
                Skills_LBL.Text = "Skills: " + Resume.skills;
                Skills1_LBL.Text = "Skills: " + Resume.skills1;
                Skills2_LBL.Text = "Skills: " + Resume.skills2;
                Skills3_LBL.Text = "Skills: " + Resume.skills3;
                Skills4_LBL.Text = "Skills: " + Resume.skills4;
                Skills5_LBL.Text = "Skills: " + Resume.skills5;
                Hobby_LBL.Text = "Hobby: " + Resume.hobby;
                Hobby1_LBL.Text = "Hobby: " + Resume.hobby1;
                Hobby2_LBL.Text = "Hobby: " + Resume.hobby2;
                Hobby3_LBL.Text = "Hobby: " + Resume.hobby3;
            }
            catch
            {

            }
        }
        private void Generate_BTN_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Users\pc\Desktop\Resume Creator\ResumeInformation.json";
            string JSONFILE = File.ReadAllText(filename);
            ResumeInformation Resume = JsonSerializer.Deserialize<ResumeInformation>(JSONFILE);
            //Basic Information
            string firstname = Resume.firstname;
            string lastname = Resume.lastname;
            string middlename = Resume.middlename;
            string Email = Resume.email;
            string phonenumber = Resume.phonenumber;
            //Address
            string homeaddress = Resume.homeaddress;
            string postalcode = Resume.postalcode;
            string municipality = Resume.municipality;
            string province = Resume.province;
            //Education
            string college = Resume.college;
            string courge = Resume.course;
            string collegegraduated = Resume.collegegraduated;
            string seniorhighschool = Resume.seniorhighschool;
            string strand = Resume.strand;
            string seniorhighschoolgraduated = Resume.seniorhighschoolgraduated;
            string highschool = Resume.highschool;     
            //Achievement
            string achievement = Resume.achievement;
            string achievement1 = Resume.achievement1;
            //Experience
            string experience = Resume.experience;
            string contain = Resume.contain;
            string contain1 = Resume.contain1;
            string contain2 = Resume.contain2;
            //Skills
            string skills = Resume.skills;
            string skills1 = Resume.skills1;
            string skills2 = Resume.skills2;
            string skills3 = Resume.skills3;
            string skills4 = Resume.skills4;
            string skills5 = Resume.skills5;
            //Hobby
            string hobby = Resume.hobby;
            string hobby1 = Resume.hobby1;
            string hobby2 = Resume.hobby2;
            string hobby3 = Resume.hobby3;

            FirstName_LBL.Text = "First Name: " + Resume.firstname;
            LastName_LBL.Text = "Last Name: " + Resume.lastname;
            MiddleName_LBL.Text = "MiddleName: " + Resume.middlename;
            Email_LBL.Text = "Email: " + Resume.email;
            PhoneNumber_LBL.Text = "PhoneNumber: " + Resume.phonenumber;
            HomeAddress_LBL.Text = "HomeAddress: " + Resume.homeaddress;
            Postal_LBL.Text = "Postal: " + Resume.postalcode;
            Municipality_LBL.Text = "Municipality: " + Resume.municipality;
            Province_LBL.Text = "Provicne: " + Resume.province;
            College_LBL.Text = "College: " + Resume.college;
            Course_LBL.Text = "Course: " + Resume.course;
            GraduatedYear_LBL.Text = "GreaduatedYear: " + Resume.collegegraduated;
            SHS_LBL.Text = "SeniorHighSchool: " + Resume.seniorhighschool;
            Strand_LBL.Text = "Strand: " + Resume.strand;
            GraduatedYear1_LBL.Text = "GreaduatedYear: " + Resume.seniorhighschoolgraduated;
            HS_LBL.Text = "High School: " + Resume.highschool;
            GraduatedYear2_LBL.Text = "GraduatedYear: " + Resume.highschoolgraduated;
            Achievement_LBL.Text = "Achievement: " + Resume.achievement;
            Achievement1_LBL.Text = "Achievement: " + Resume.achievement1;
            Experience_LBL.Text = "Exprience: " + Resume.experience;
            Contain_LBL.Text = "Contain: " + Resume.contain;
            Contain1_LBL.Text = "Contain: " + Resume.contain1;
            Contain2_LBL.Text = "Contain: " + Resume.contain2;
            Skills_LBL.Text = "Skills: " + Resume.skills;
            Skills1_LBL.Text = "Skills: " + Resume.skills1;
            Skills2_LBL.Text = "Skills: " + Resume.skills2;
            Skills3_LBL.Text = "Skills: " + Resume.skills3;
            Skills4_LBL.Text = "Skills: " + Resume.skills4;
            Skills5_LBL.Text = "Skills: " + Resume.skills5;
            Hobby_LBL.Text = "Hobby: " + Resume.hobby;
            Hobby1_LBL.Text = "Hobby: " + Resume.hobby1;
            Hobby2_LBL.Text = "Hobby: " + Resume.hobby2;
            Hobby3_LBL.Text = "Hobby: " + Resume.hobby3;
        }
    }
    public class ResumeInformation
    {
        //Basic Information
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
        //Address
        public string homeaddress { get; set; }
        public string postalcode { get; set; }
        public string municipality { get; set; }
        public string province { get; set; }
       // Education
        public string college { get; set; }
        public string course { get; set; }
        public string collegegraduated { get; set; }
        public string seniorhighschool { get; set; }
        public string strand { get; set; }
        public string seniorhighschoolgraduated { get; set; }
        public string highschool { get; set; }
        public string highschoolgraduated { get; set; }
        //Achievement
        public string achievement { get; set; }
        public string achievement1 { get; set; }
        //Experience
        public string experience { get; set; }
        public string contain { get; set; }
        public string contain1 { get; set; }
        public string contain2 { get; set; }
       // Skills
        public string skills { get; set; }
        public string skills1 { get; set; }
        public string skills2 { get; set; }
        public string skills3 { get; set; }
        public string skills4 { get; set; }
        public string skills5 { get; set; }
       // Hobby
        public string hobby { get; set; }
        public string hobby1 { get; set; }
        public string hobby2 { get; set; }
        public string hobby3 { get; set; }
    }
}
