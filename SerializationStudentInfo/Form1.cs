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


namespace SerializationStudentInfo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {

            try
            {
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\DotNet20DecBatch\deptBinary.dat", FileMode.Create, FileAccess.Write);
                student2 stu = new student2();
                stu.stuid = Convert.ToInt32(txtstuid.Text);
                stu.stuname = txtstuname.Text;
                stu.RegestrationNo = Convert.ToInt32(txtRegNo.Text);
                stu.FinalYearPer = Convert.ToInt32(txtFinalPer.Text);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fs, stu);
                MessageBox.Show("Data Saved");
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
                FileStream fs = new FileStream(@"C:\Users\nsb98\Documents\stusoap.soap", FileMode.Create, FileAccess.Write);
                student2 stu = new student2();
                stu.stuid = Convert.ToInt32(txtstuid.Text);
                stu.stuname = txtstuname.Text;
                stu.RegestrationNo = Convert.ToInt32(txtRegNo.Text);
                stu.FinalYearPer = Convert.ToInt32(txtFinalPer.Text);
                SoapFormatter soapFormatter = new SoapFormatter();

                soapFormatter.Serialize(fs, stu);
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
                student2 stu = new student2();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                stu = (student2)binaryFormatter.Deserialize(fs);
                txtstuid.Text = stu.stuid.ToString();
                txtstuname.Text = stu.stuname;
                txtRegNo.Text = stu.RegestrationNo.ToString();
                txtFinalPer.Text = stu.FinalYearPer.ToString();
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
                student2 stu = new student2();
                stu.stuid = Convert.ToInt32(txtstuid.Text);
                stu.stuname = txtstuname.Text;
                stu.RegestrationNo = Convert.ToInt32(txtRegNo.Text); ;
                stu.FinalYearPer = Convert.ToInt32(txtFinalPer.Text); ;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(student2));
                xmlSerializer.Serialize(fs, stu);
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
                student2 stu = new student2();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(student2));
                stu = (student2)xmlSerializer.Deserialize(fs);
                txtstuid.Text = stu.stuid.ToString();
                txtstuname.Text = stu.stuname;
                txtRegNo.Text = stu.RegestrationNo.ToString();
                txtFinalPer.Text = stu.FinalYearPer.ToString();

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
                student2 stu = new student2();
                SoapFormatter soapFormatter = new SoapFormatter();
                stu = (student2)soapFormatter.Deserialize(fs);
                txtstuid.Text = stu.stuid.ToString();
                txtstuname.Text = stu.stuname;
                txtRegNo.Text = stu.RegestrationNo.ToString();
                txtFinalPer.Text = stu.FinalYearPer.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DotNet20DecBatch\StudJson.json", FileMode.Create, FileAccess.Write);
                student2 stu = new student2();
                stu.stuid = Convert.ToInt32(txtstuid.Text);
                stu.stuname = txtstuname.Text;
                stu.RegestrationNo = Convert.ToInt32(txtRegNo.Text);
                stu.FinalYearPer = Convert.ToInt32(txtFinalPer.Text);

                 JsonSerializer.Serialize<student2>(fs, stu);
                MessageBox.Show("Data Saved");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
