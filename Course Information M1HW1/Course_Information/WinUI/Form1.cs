using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* 9/10/2023
* CSC 253
* David McCarthy
* Takes the course number entered by the user and searches through three seperate dictionarys to find the instructor, room number, and meeting time.
*/
namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findCourseInfoButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> RoomNumber = new Dictionary<string, int>()
            {
                {"CS101", 3004},
                {"CS102", 4501},
                {"CS103", 6755},
                {"NT110", 1244},
                {"CM241", 1411}
            };
            Dictionary<string, string> InstructorName = new Dictionary<string, string>()
            {
                {"CS101", "Haynes"},
                {"CS102", "Alvarado"},
                {"CS103", "Rich"},
                {"NT110", "Burke"},
                {"CM241", "Lee"}
            };
            Dictionary<string, string> MeetingTime = new Dictionary<string, string>()
            {
                 {"CS101", "8:00 AM"},
                {"CS102", "9:00 AM"},
                {"CS103", "10:00 AM"},
                {"NT110", "11:00 AM"},
                {"CM241", "1:00 PM"}
            };

            string courseKey = "";
            int courseRoomNum;
            string courseInstructor;
            string meetingTime;
            courseKey = courseInfoTextBox.Text;

            if (RoomNumber.TryGetValue(courseKey, out courseRoomNum))
            {
                roomNumberLabel.Text = ("Room Number: " + courseRoomNum);
            }
            else
            {
                roomNumberLabel.Text = ("Course " + courseKey + " does not exist");
            }

            if(InstructorName.TryGetValue(courseKey, out courseInstructor))
            {
                instructorLabel.Text = ("Instructor: " + courseInstructor);
            }
            else
            {
                instructorLabel.Text = ("Course " + courseKey + " does not exist");
            }

            if(MeetingTime.TryGetValue(courseKey, out meetingTime))
            {
                meetingTimeLabel.Text = ("Meeting Time : " + meetingTime);
            }
            else
            {
                meetingTimeLabel.Text = ("Course " + courseKey + " does not exist");
            }
        }
    }
}
