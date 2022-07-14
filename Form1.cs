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
            string SeniorHighgraduated = Resume.seniorhighschoolgraduated;
            string Highschool = Resume.highschool;
            string Highschoolgraduated = Resume.highschoolgraduated;
            //Achievement
            string Achievement = Resume.achievement;
            string Achievement1 = Resume.achievement1;
            string Achievement2 = Resume.achievement2;
            string Achievement3 = Resume.achievement3;
            string Achievement4 = Resume.achievement4;

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
            Achievement_LBL.Text = Resume.achievement;
            Achievement1_LBL.Text = Resume.achievement1;
            Achievement2_LBL.Text = Resume.achievement2;
            Achievement3_LBL.Text = Resume.achievement3;
            Achievement4_LBL.Text = Resume.achievement;
            Experience_LBL.Text = "Exprience: " + Resume.experience;
            Experience1_LBL.Text =  Resume.contain;
            Experience2_LBL.Text = Resume.contain1;
            Experience3_LBL.Text = Resume.contain2;
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
            string SeniorHighgraduated = Resume.seniorhighschoolgraduated;
            string Highschool = Resume.highschool;
            string Highschoolgraduated = Resume.highschoolgraduated;
            //Achievement
            string Achievement = Resume.achievement;
            string Achievement1 = Resume.achievement1;
            string Achievement2 = Resume.achievement2;
            string Achievement3 = Resume.achievement3;
            string Achievement4 = Resume.achievement4;
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

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.InitialDirectory = @"C:\Users\pc\Desktop\OOP\Resume";
                dlg.FileName = Lastname + Firstname + ".pdf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    PdfPage page = pdf.AddPage();

                    XGraphics graph = XGraphics.FromPdfPage(page);

                    XFont bigfont = new XFont("Bebas Neue Regular", 18, XFontStyle.Regular);
                    XFont smallfont = new XFont("Open Sans Light", 12, XFontStyle.Regular);
                    XFont titlefont = new XFont("Bebas Neue Regular", 45, XFontStyle.Bold);

                    XPen pen = new XPen(XColors.White, 20);

                    graph.DrawRoundedRectangle(XBrushes.DarkSlateGray, 0, 0, page.Width.Point, page.Height.Point, 0, 0);

                    graph.DrawRectangle(pen, 0, 0, page.Width.Point, page.Height.Point);

                    int marginleft = 25;
                    int initialleft = 200;
                    int marginright = 430;
                    int initialmiddle = 200;

                    string png = @"C:\Users\pc\Desktop\OOP\Resume\Gerald.png";
                    XImage image = XImage.FromFile(png);
                    graph.DrawImage(image, marginright, 50, 150, 150);

                    graph.DrawString(Firstname + " " + Middlename + " " + Lastname, titlefont, XBrushes.White, new XRect(marginleft, initialleft - 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString("PROFILE", bigfont, XBrushes.White, new XRect(marginright, initialleft + 20, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Firstname, smallfont, XBrushes.White, new XRect(marginright, initialleft + 50, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Middlename, smallfont, XBrushes.White, new XRect(marginright, initialleft + 65, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Lastname, smallfont, XBrushes.White, new XRect(marginright, initialleft + 80, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Email, smallfont, XBrushes.White, new XRect(marginright, initialleft + 95, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Phonenumber, smallfont, XBrushes.White, new XRect(marginright, initialleft + 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("ADDRESS", smallfont, XBrushes.White, new XRect(marginright, initialleft + 145, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Homeaddress, smallfont, XBrushes.White, new XRect(marginright, initialleft + 160, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Postalcode, smallfont, XBrushes.White, new XRect(marginright, initialleft + 175, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Municipality, smallfont, XBrushes.White, new XRect(marginright, initialleft + 190, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Province, smallfont, XBrushes.White, new XRect(marginright, initialleft + 205, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("HOBBY", smallfont, XBrushes.White, new XRect(marginright, initialmiddle + 235, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Hobby1, smallfont, XBrushes.White, new XRect(marginright, initialmiddle + 250, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Hobby2, smallfont, XBrushes.White, new XRect(marginright, initialmiddle + 265, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Hobby3, smallfont, XBrushes.White, new XRect(marginright, initialmiddle + 280, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Hobby4, smallfont, XBrushes.White, new XRect(marginright, initialmiddle + 295, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString("EDUCATION", bigfont, XBrushes.White, new XRect(marginleft, initialmiddle, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(College, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Course, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 45, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Collegegraduated, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(Seniorhighschool, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Strand, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 105, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SeniorHighgraduated, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 120, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(Highschool, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 150, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Highschoolgraduated, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 165, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    initialmiddle = initialmiddle + 200;

                    graph.DrawString("EXPERIENCE", bigfont, XBrushes.White, new XRect(marginleft, initialmiddle, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Experience, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Contain, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 45, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Contain1, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Contain2, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 75, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    initialmiddle = initialmiddle + 100;
                    graph.DrawString("ACHIEVEMENT", bigfont, XBrushes.White, new XRect(marginleft, initialmiddle, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Achievement, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Achievement1, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 45, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Achievement2, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Achievement3, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 75, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    initialmiddle = initialmiddle + 100;
                    graph.DrawString("SKILLS", bigfont, XBrushes.White, new XRect(marginleft, initialmiddle, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Skills1, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Skills2, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 45, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Skills3, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Skills4, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 75, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Skills5, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Skills6, smallfont, XBrushes.White, new XRect(marginleft, initialmiddle + 105, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    pdf.Save(dlg.FileName);
                }
            }
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
        public string achievement2 { get; set; }
        public string achievement3 { get; set; }
        public string achievement4 { get; set; }
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
