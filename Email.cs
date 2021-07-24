using System;
using System.Collections.Generic;
using System.Text;

namespace Email_Application
{
    public class Email
    {
        //Attributes for Email Application
        private string firstName;
        private string LastName;
        public string email;
        private string department;
        private int Capacity = 1000;
        private string alternateEmail;
        private string companySuffix = "tcs.com";

        public Email(string firstName, string LastName)
        {
            //Enter your Name for the Email application
            this.firstName = firstName;
            this.LastName = LastName;
            Console.WriteLine("Email Created: \nYour First Name is: " + this.firstName + "\nYour last Name is: " + this.LastName);

            //Set Department for the Email Application
            this.department = Setting_Department();
            Console.WriteLine("Your Department is: " +this.department);


            email = firstName.ToLower() + "." + LastName.ToLower() + "@" + this.department.ToLower() + "." + this.companySuffix;
            Console.WriteLine("Your Email is: " + email);

        }
        //User input for setting the Department
        private string Setting_Department()
        {
            Console.WriteLine("Choose your own Department: \n1 For Sales \n2 For Development \n3 For Accounting");
            int department_code = Convert.ToInt32(Console.ReadLine());
            if (department_code == 1)
            {
                return "Sales";
            }
            else if (department_code == 2)
            {
                return "Development";
            }
            else if (department_code == 3)
            {
                return "Accounting";
            }
            else
            {
                return "Please select a valid department code";
            }

        }

        //Setting Mailbox Capacity
        public void setcapacity(int capacity)
        {
            this.Capacity = capacity;
        }

        //Setting Alternate Email Address
        public void setalternateEmail(string alternameEmail)
        {
            this.alternateEmail = alternameEmail;
        }

        //Getters for the above methods
        public int getCapacity()
        {
            return Capacity;
        }

        public string getalternateEmail()
        {
            return alternateEmail;
        }


        //Show info 
        public string Show_Info()
        {
            return "Name: " + firstName + " " + LastName + "\nEmail: " + email + "\nMailbox Capacity: " +Capacity;   
        }
    }
}
