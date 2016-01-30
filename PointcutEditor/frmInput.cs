using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.XPath;

namespace PointcutEditor
{
    public partial class frmInput : Form
    {
        //private static string specFolder = @"C:\Java\aspect\specs\";
        private FormType formType;
        private FormMode formMode;

        public enum FormType {mdAspect, mdAdvice, mdPointcut};
        public enum FormMode {mdInsert, mdEdit};
        public static string text1, text2, text3;

        public frmInput(FormType formType, FormMode formMode)
        {
            InitializeComponent();

            this.formType = formType;
            this.formMode = formMode;

            label1.Visible = textBox1.Visible = true;
            label2.Visible = textBox2.Visible = (formType != FormType.mdAspect);
            label3.Visible = textBox3.Visible = (formType != FormType.mdAspect);

            if (formMode == FormMode.mdInsert)
                textBox1.Text = textBox2.Text = textBox3.Text = "";
            else
            {
                textBox1.Text = text1;
                textBox2.Text = text2;
                textBox3.Text = text3;
            }

            switch (formType)
            {
                case FormType.mdAspect:
                    this.Text = (formMode == FormMode.mdInsert ? "New Aspect" : "Edit Aspect");
                    label1.Text = "Name:";
                    this.MaximumSize = this.Size = this.MinimumSize = new Size(346, 140);
                    break;
                case FormType.mdAdvice:
                    this.Text = (formMode == FormMode.mdInsert ? "New Advice" : "Edit Advice");
                    label1.Text = "Name:";
                    label2.Text = "Process:";
                    label3.Text = "Goal:";
                    this.MaximumSize = this.Size = this.MinimumSize = new Size(346, 185);
                    break;
                case FormType.mdPointcut:
                    this.Text = (formMode == FormMode.mdInsert ? "New Pointcut" : "Edit Pointcut");
                    label1.Text = "Process:";
                    label2.Text = "Task:";
                    label3.Text = "Condition:";
                    this.MaximumSize = this.Size = this.MinimumSize = new Size(346, 185);
                    break;
                default:
                    break;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            text1 = textBox1.Text.Trim();
            text2 = textBox2.Text.Trim();
            text3 = textBox3.Text.Trim();

            DialogResult = (text1 == "" ? System.Windows.Forms.DialogResult.None : System.Windows.Forms.DialogResult.OK);

            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                switch (formType)
                {
                    case FormType.mdPointcut:
                        DialogResult = (text2 == "" ? System.Windows.Forms.DialogResult.None : System.Windows.Forms.DialogResult.OK);
                        DialogResult = (text3 == "" ? System.Windows.Forms.DialogResult.None : System.Windows.Forms.DialogResult.OK);
                        break;
                    case FormType.mdAdvice:
                        DialogResult = (text2 == "" ? System.Windows.Forms.DialogResult.None : System.Windows.Forms.DialogResult.OK);
                        DialogResult = (text3 == "" ? System.Windows.Forms.DialogResult.None : System.Windows.Forms.DialogResult.OK);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
