using SerializationDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap; 
using System.Text;
//using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace SerializationEmployee
{
    public partial class Form1 : Form
    {
        private object soapFormatter;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\DotNet20DecBatch\deptBinary.dat", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.empid = Convert.ToInt32(txtempid.Text);
                emp.empname = txtempname.Text;
                emp.city = txtcity.Text;
                emp.Salary = txtsalary.Text;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, emp);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\deptBinary.dat", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                emp = (Employee)binaryFormatter.Deserialize(fs);
                txtempid.Text = emp.empid.ToString();
                txtempname.Text = emp.empname;
                txtcity.Text = emp.city;
                txtsalary.Text = emp.Salary;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\deptxml.xml", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.empid = Convert.ToInt32(txtempid.Text);
                emp.empname =txtempname.Text;
                emp.city = txtcity.Text;
                emp.Salary=txtsalary.Text;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                xmlSerializer.Serialize(fs, emp);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\deptxml.xml", FileMode.Open, FileAccess.Read);
                Employee emp = new Employee();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                emp = (Employee)xmlSerializer.Deserialize(fs);
                txtempid.Text = emp.empid.ToString();
                txtempname.Text = emp.empname;
                txtcity.Text = emp.city;
                txtsalary.Text = emp.Salary;

                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\empsoap.soap", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                emp.empid = Convert.ToInt32(txtempid.Text);
                emp.empname = txtempname.Text;
                emp.city =txtcity.Text;
                emp.Salary = txtsalary.Text;
                SoapFormatter soapFormatter = new SoapFormatter();

                soapFormatter.Serialize(fs, emp);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {

        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {

        }
    }
}

