using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace EmailClient
{
    public partial class Form1 : Form
    {
        MailMessage mail = new MailMessage();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EmailClient.frmAddAttachment frm = new EmailClient.frmAddAttachment();
            frm.ShowDialog(this);
            if (frm.txtFile.Text.Trim() != "")
                listBox1.Items.Add(frm.txtFile.Text);
            frm.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            using (MailMessage mailMessage = new MailMessage(new MailAddress(textBox1.Text),
            new MailAddress(textBox1.Text)))
            {
                mailMessage.Body = textBox5.Text;
                mailMessage.Subject = textBox4.Text;
                try
                {
                    SmtpClient SmtpServer = new SmtpClient();
                    SmtpServer.Credentials = new System.Net.NetworkCredential(textBox2.Text, textBox3.Text);
                    SmtpServer.Port = 587;
                    if (checkBox1.Checked == true)
                        try
                        {
                            SmtpServer.Host = "smtp.gmail.com";
                            SmtpServer.EnableSsl = true;
                        }
                        catch
                        {                            
                            SmtpServer.Host = "smtp.gmail.com";
                            SmtpServer.EnableSsl = true;
                        }
                    if (checkBox2.Checked == true)
                        try
                        {
                            SmtpServer.Host = "smtp.mail.yahoo.com";
                            SmtpServer.EnableSsl = false;
                        }
                        catch
                        {
                            SmtpServer.Host = "smtp.mail.yahoo.com";
                            SmtpServer.EnableSsl = false;
                        }
                    if (checkBox3.Checked == true)
                        try
                        {
                            SmtpServer.Host = "smtp.aol.com";
                            SmtpServer.EnableSsl = false;
                        }
                        catch
                        {
                            SmtpServer.Host = "smtp.aol.com";
                            SmtpServer.EnableSsl = false;
                        }
                    if (checkBox4.Checked == true)
                        try
                        {
                            SmtpServer.Credentials = new System.Net.NetworkCredential(textBox2.Text, textBox3.Text);
                            SmtpServer.Host = "smtp.live.com";
                            SmtpServer.EnableSsl = true;
                        }
                        catch
                        {
                            SmtpServer.Credentials = new System.Net.NetworkCredential(textBox2.Text, textBox3.Text);
                            SmtpServer.Host = "smtp.live.com";
                            SmtpServer.EnableSsl = true;
                        }
                   if (checkBox1.Checked && checkBox2.Checked == true)
                        try
                        {
                            MessageBox.Show("Please Choose Only One Email Client At A Time");
                        }
                        catch
                        {
                            MessageBox.Show("Please Choose Only One Email Client At A Time");
                        }
                    mail = new MailMessage();
                    String[] addr = textBox1.Text.Split(',');
                    mail.From = new MailAddress(textBox2.Text);
                    Byte i;
                    for (i = 0; i < addr.Length; i++)
                        mail.To.Add(addr[i]);
                    mail.Subject = textBox4.Text;

                    string message = textBox5.Text;
                                     
                    string[] a = new string[message.Length];
                    string[] b = new string[message.Length];
                      for(int z = 0; z < message.Length; z++) {
                      a[z] = message [z].ToString();
                      if (a[z] == "a")
                      {
                          b[z] = "k";
                      }
                      if (a[z] == "b")
                      {
                          b[z] = "m";
                      } if (a[z] == "c")
                      {
                          b[z] = "o";
                      }
                      if (a[z] == "d")
                      {
                          b[z] = "q";
                      }
                      if (a[z] == "e")
                      {
                          b[z] = "s";
                      }
                      if (a[z] == "f")
                      {
                          b[z] = "u";
                      }
                      if (a[z] == "g")
                      {
                          b[z] = "w";
                      }
                      if (a[z] == "h")
                      {
                          b[z] = "y";
                      }
                      if (a[z] == "i")
                      {
                          b[z] = "a";
                      }
                      if (a[z] == "j")
                      {
                          b[z] = "c";
                      }
                      if (a[z] == "k")
                      {
                          b[z] = "e";
                      }
                      if (a[z] == "l")
                      {
                          b[z] = "g";
                      }
                      if (a[z] == "m")
                      {
                          b[z] = "i";
                      }
                      if (a[z] == "n")
                      {
                          b[z] = "j";
                      }
                      if (a[z] == "o")
                      {
                          b[z] = "l";
                      }
                      if (a[z] == "p")
                      {
                          b[z] = "n";
                      }
                      if (a[z] == "q")
                      {
                          b[z] = "p";
                      }
                      if (a[z] == "r")
                      {
                          b[z] = "r";
                      }
                      if (a[z] == "s")
                      {
                          b[z] = "t";
                      }
                      if (a[z] == "t")
                      {
                          b[z] = "v";
                      }
                      if (a[z] == "u")
                      {
                          b[z] = "x";
                      }
                      if (a[z] == "v")
                      {
                          b[z] = "z";
                      }
                      if (a[z] == "w")
                      {
                          b[z] = "b";
                      } if (a[z] == "x")
                      {
                          b[z] = "d";
                      }
                      if (a[z] == "y")
                      {
                          b[z] = "f";
                      }
                      if (a[z] == "z")
                      {
                          b[z] = "h";
                      }
                      if (a[z] == " ")
                      {
                          b[z] = ",";
                      }
                       }
                      string s = string.Join(" ", b);


                  

                    mail.Body = s ;
                    if (listBox1.Items.Count != 0)
                    {
                        for (i = 0; i < listBox1.Items.Count; i++)
                            mail.Attachments.Add(new Attachment(listBox1.Items[i].ToString()));
                    }
                    mail.IsBodyHtml = true;
                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    mail.ReplyTo = new MailAddress(textBox1.Text);
                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "EMail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}

