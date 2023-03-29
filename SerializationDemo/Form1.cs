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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SerializationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\deptJson.json", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptId.Text);
                dept.Name = txtDeptName.Text;
                dept.Locatiom = txtLocation.Text;
                JsonSerializer.Serialize<Department>(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\DotNet20DecBatch\deptBinary.dat", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptId.Text);
                dept.Name = txtDeptName.Text;
                dept.Locatiom = txtLocation.Text;
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, dept);
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
                Department dept = new Department();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                dept = (Department)binaryFormatter.Deserialize(fs);
                txtDeptId.Text = dept.Id.ToString();
                txtDeptName.Text = dept.Name;
                txtLocation.Text = dept.Locatiom;
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
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptId.Text);
                dept.Name = txtDeptName.Text;
                dept.Locatiom = txtLocation.Text;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
                xmlSerializer.Serialize(fs, dept);
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
                Department dept = new Department();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
                dept = (Department)xmlSerializer.Deserialize(fs);
                txtDeptId.Text = dept.Id.ToString();
                txtDeptName.Text = dept.Name;
                txtLocation.Text = dept.Locatiom;
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
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\deptsoap.soap", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtDeptId.Text);
                dept.Name = txtDeptName.Text;
                dept.Locatiom = txtLocation.Text;
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, dept);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\deptsoap.soap", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                SoapFormatter soapFormatter = new SoapFormatter();
                dept = (Department)soapFormatter.Deserialize(fs);
                txtDeptId.Text = dept.Id.ToString();
                txtDeptName.Text = dept.Name;
                txtLocation.Text = dept.Locatiom;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\deptJson.json", FileMode.Open, FileAccess.Read);
                Department dept = new Department();

                dept = JsonSerializer.Deserialize<Department>(fs);
                txtDeptId.Text = dept.Id.ToString();
                txtDeptName.Text = dept.Name;
                txtLocation.Text = dept.Locatiom;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
