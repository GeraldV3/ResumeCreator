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
        public MainForm()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }
        private void Read_BTN_Click(object sender, EventArgs e)
        {
            string filename = "ResumeInformation.json";
            string jsonInfo = File.ReadAllText(filename);
            ResumeInformation Resume = JsonSerializer.Deserialize<ResumeInformation>(jsonInfo);
            MessageBox.Show(jsonInfo);
            //Basic Information
            string Firstname = Resume.firstname;
            string Lastname = Resume.lastname;
            string Middlename = Resume.middlename;
            string Email = Resume.email;
            string Phonenumber = Resume.phonenumber;
            //Address
            string Homeaddress = Resume.homeaddress;
            string Postalcode = Resume.postalcode;
            string Municipality = Resume.municipality;
            string Province = Resume.province;
            //Education
            string College = Resume.college;
            string Course = Resume.course;
            string Collegegraduated = Resume.collegegraduated;
            string Seniorhighschool = Resume.seniorhighschool;
            string Strand = Resume.strand;
            string Seniorhighschoolgraduated = Resume.seniorhighschoolgraduated;
            string Highschool = Resume.highschool;
            string Highschoolgraduated = Resume.highschoolgraduated;
            //Achievement
            string Achievement = Resume.achievement;
            string Achievement1 = Resume.achievement1;
            //Experience
            string Experience = Resume.experience;
            string Contain = Resume.contain;
            string Contain1 = Resume.contain1;
            string Contain2 = Resume.contain2;
           // Skills
            string Skills1 = Resume.skills1;
            string Skills2 = Resume.skills2;
            string Skills3 = Resume.skills3;
            string Skills4 = Resume.skills4;
            string Skills5 = Resume.skills5;
            string Skills6 = Resume.skills6;
           // Hobby
            string Hobby1 = Resume.hobby1;
            string Hobby2 = Resume.hobby2;
            string Hobby3 = Resume.hobby3;
            string Hobby4 = Resume.hobby4;
            FirstName_LBL.Text = "First Name: " + Firstname;
            LastName_LBL.Text = "Last Name: " + Resume.lastname;
            MiddleName_LBL.Text = "Middle Name: " + Resume.middlename;
            Email_LBL.Text = "Email: " + Resume.email;
            PhoneNumber_LBL.Text = "Phone Number: " + Resume.phonenumber;
            HomeAddress_LBL.Text = "Home Address: " + Resume.homeaddress;
            Postal_LBL.Text = "Postal: " + Resume.postalcode;
            Municipality_LBL.Text = "Municipality: " + Resume.municipality;
            Province_LBL.Text = "Province: " + Resume.province;
            College_LBL.Text = "College: " + Resume.college;
            Course_LBL.Text = "Course: " + Resume.course;
            GraduatedYear_LBL.Text = "GraduatedYear: " + Resume.collegegraduated;
            SHS_LBL.Text = "Senior High School: " + Resume.seniorhighschool;
            Strand_LBL.Text = "Strand: " + Resume.strand;
            GraduatedYear1_LBL.Text = "GraduatedYear: " + Resume.seniorhighschoolgraduated;
            HS_LBL.Text = "High School: " + Resume.highschool;
            GraduatedYear2_LBL.Text = "GraduatedYear: " + Resume.highschoolgraduated;
            Achievement_LBL.Text = "Achievement: " + Resume.achievement;
            Achievement1_LBL.Text = "Achievement: " + Resume.achievement1;
            Experience_LBL.Text = "Experience: " + Resume.experience;
            Contain_LBL.Text = "Contain: " + Resume.contain;
            Contain1_LBL.Text = "Contain: " + Resume.contain1;
            Contain2_LBL.Text = "Contain: " + Resume.contain2;
            Skills_LBL.Text = "Skills: " + Resume.skills1;
            Skills1_LBL.Text = "Skills: " + Resume.skills2;
            Skills2_LBL.Text = "Skills: " + Resume.skills3;
            Skills3_LBL.Text = "Skills: " + Resume.skills4;
            Skills4_LBL.Text = "Skills: " + Resume.skills5;
            Skills5_LBL.Text = "Skills: " + Resume.skills6;
            Hobby_LBL.Text = "Hobby: " + Resume.hobby1;
            Hobby1_LBL.Text = "Hobby: " + Resume.hobby2;
            Hobby2_LBL.Text = "Hobby: " + Resume.hobby3;
            Hobby3_LBL.Text = "Hobby: " + Resume.hobby4;
        }
        private void Generate_BTN_Click(object sender, EventArgs e)
        {
            string filename = "ResumeInformation.json";
            string jsonInfo = File.ReadAllText(filename);
            ResumeInformation Resume = JsonSerializer.Deserialize<ResumeInformation>(jsonInfo);
            //Basic Information
            string Firstname = Resume.firstname;
            string Lastname = Resume.lastname;
            string Middlename = Resume.middlename;
            string Email = Resume.email;
            string Phonenumber = Resume.phonenumber;
            //Address
            string Homeaddress = Resume.homeaddress;
            string Postalcode = Resume.postalcode;
            string Municipality = Resume.municipality;
            string Province = Resume.province;
            //Education
            string College = Resume.college;
            string Course = Resume.course;
            string Collegegraduated = Resume.collegegraduated;
            string Seniorhighschool = Resume.seniorhighschool;
            string Strand = Resume.strand;
            string Seniorhighschoolgraduated = Resume.seniorhighschoolgraduated;
            string Highschool = Resume.highschool;
            string Highschoolgraduated = Resume.highschoolgraduated;
            //Achievement
            string Achievement = Resume.achievement;
            string Achievement1 = Resume.achievement1;
            //Experience
            string Experience = Resume.experience;
            string Contain = Resume.contain;
            string Contain1 = Resume.contain1;
            string Contain2 = Resume.contain2;
            // Skills
            string Skills1 = Resume.skills1;
            string Skills2 = Resume.skills2;
            string Skills3 = Resume.skills3;
            string Skills4 = Resume.skills4;
            string Skills5 = Resume.skills5;
            string Skills6 = Resume.skills6;
            // Hobby
            string Hobby1 = Resume.hobby1;
            string Hobby2 = Resume.hobby2;
            string Hobby3 = Resume.hobby3;
            string Hobby4 = Resume.hobby4;
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
        public string skills1 { get; set; }
        public string skills2 { get; set; }
        public string skills3 { get; set; }
        public string skills4 { get; set; }
        public string skills5 { get; set; }
        public string skills6 { get; set; }
       // Hobby
        public string hobby1 { get; set; }
        public string hobby2 { get; set; }
        public string hobby3 { get; set; }
        public string hobby4 { get; set; }
    }
}
