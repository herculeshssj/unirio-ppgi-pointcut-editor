using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace PointcutEditor
{
    public partial class frmPointcutEditor : Form
    {
        private List<Aspect> aspects = new List<Aspect>();

        public frmPointcutEditor()
        {
            InitializeComponent();
        }

        private void chooseSpecificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlTextReader textReader = new XmlTextReader(openFileDialog1.FileName);
                textReader.Read();
                // If the node has value
                while (textReader.Read())
                {
                    /*
                    // Move to fist element
                    textReader.MoveToElement();
                    Console.WriteLine("XmlTextReader Properties Test");
                    Console.WriteLine("===================");
                    // Read this element's properties and display them on console
                    Console.WriteLine("Name:" + textReader.Name);
                    Console.WriteLine("Base URI:" + textReader.BaseURI);
                    Console.WriteLine("Local Name:" + textReader.LocalName);
                    Console.WriteLine("Attribute Count:" + textReader.AttributeCount.ToString());
                    Console.WriteLine("Depth:" + textReader.Depth.ToString());
                    Console.WriteLine("Line Number:" + textReader.LineNumber.ToString());
                    Console.WriteLine("Node Type:" + textReader.NodeType.ToString());
                    Console.WriteLine("Attribute Count:" + textReader.Value.ToString());
                     */
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aspects = ReadRules.readAspects();
            updateGridViewAspect();
        }

        private void gvAspect_SelectionChanged(object sender, EventArgs e)
        {
            updateGridViewAdvice();
        }

        private void updateGridViewAspect()
        {
            gvAspect.DataSource = null;
            gvAdvice.DataSource = null;
            gvPointcut.DataSource = null;

            gvAspect.DataSource = aspects;
        }

        private void updateGridViewAdvice()
        {
            gvAdvice.DataSource = null;
            gvPointcut.DataSource = null;

            if (existAdvice())
                gvAdvice.DataSource = aspects[gvAspect.CurrentRow.Index].Advices;
        }

        private bool existAspect()
        {
            return (gvAspect.DataSource != null);
        }

        private bool existAdvice()
        {
            return existAspect() &&
                (aspects[gvAspect.CurrentRow.Index].Advices != null)
                    && (aspects[gvAspect.CurrentRow.Index].Advices.Count > 0);
        }

        private bool existPointcut()
        {
            return existAdvice() &&
                (aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Pointcuts != null)
                    && (aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Pointcuts.Count > 0);
        }

        private void updateGridViewPointcut()
        {
            gvPointcut.DataSource = null;

            if (existPointcut())
                gvPointcut.DataSource = aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Pointcuts;
        }

        private void gvAdvice_SelectionChanged(object sender, EventArgs e)
        {
            updateGridViewPointcut();
        }

        private void tsbAspectNew_Click(object sender, EventArgs e)
        {
            frmInput inp = new frmInput(frmInput.FormType.mdAspect, frmInput.FormMode.mdInsert);
            inp.ShowDialog();
            if (inp.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                aspects.Add(new Aspect(frmInput.text1));
                updateGridViewAspect();
            }
        }
            
        private void tsbAspectEdit_Click(object sender, EventArgs e)
        {
            if (existAspect())
            {
                frmInput.text1 = aspects[gvAspect.CurrentRow.Index].Name;
                frmInput inp = new frmInput(frmInput.FormType.mdAspect, frmInput.FormMode.mdEdit);

                inp.ShowDialog();

                if (inp.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    aspects[gvAspect.CurrentRow.Index].Name = frmInput.text1;
                    updateGridViewAspect();
                }
            }
        }

        private void tsbAspectDelete_Click(object sender, EventArgs e)
        {
            if (existAspect()
                && MessageBox.Show("Are you sure to delete this aspect?", "Delete an aspect", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                aspects.Remove(aspects[gvAspect.CurrentRow.Index]);
                updateGridViewAspect();
            }
        }

        private void tsbAdviceNew_Click(object sender, EventArgs e)
        {
            if (existAspect())
            {                
                frmInput inp = new frmInput(frmInput.FormType.mdAdvice, frmInput.FormMode.mdInsert);
                inp.ShowDialog();
                if (inp.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    aspects[gvAspect.CurrentRow.Index].addAdvice(new Advice(frmInput.text1, frmInput.text2, frmInput.text3));
                    updateGridViewAdvice();
                }
            }
        }

        private void tsbAdviceEdit_Click(object sender, EventArgs e)
        {
            if (existAdvice())
            {
                frmInput.text1 = aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Name;
                frmInput.text2 = aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Process;
                frmInput.text3 = aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Goal;
                frmInput inp = new frmInput(frmInput.FormType.mdAdvice, frmInput.FormMode.mdEdit);

                inp.ShowDialog();

                if (inp.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Name = frmInput.text1;
                    aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Process = frmInput.text2;
                    aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Goal = frmInput.text3;
                    updateGridViewAdvice();
                }
            }
        }

        private void tsbAdviceDelete_Click(object sender, EventArgs e)
        {
            if (existAdvice()
                && MessageBox.Show("Are you sure to delete this advice?", "Delete an advice", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                aspects[gvAspect.CurrentRow.Index].Advices.Remove(aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index]);
                updateGridViewAdvice();
            }
        }

        private void tsbPointcutNew_Click(object sender, EventArgs e)
        {
            if (existAdvice())
            {
                frmInput inp = new frmInput(frmInput.FormType.mdPointcut, frmInput.FormMode.mdInsert);
                inp.ShowDialog();
                if (inp.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].addPointcut(
                        new Pointcut(frmInput.text1, frmInput.text2, frmInput.text3)
                        );
                    updateGridViewPointcut();
                }
            }
        }

        private void tsbPointcutEdit_Click(object sender, EventArgs e)
        {
            if (existPointcut())
            {
                frmInput.text1 = aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Pointcuts[gvPointcut.CurrentRow.Index].Process;
                frmInput.text2 = aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Pointcuts[gvPointcut.CurrentRow.Index].Task;
                frmInput.text3 = aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Pointcuts[gvPointcut.CurrentRow.Index].Condition;

                frmInput inp = new frmInput(frmInput.FormType.mdPointcut, frmInput.FormMode.mdEdit);

                inp.ShowDialog();

                if (inp.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Pointcuts[gvPointcut.CurrentRow.Index].Process = frmInput.text1;
                    aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Pointcuts[gvPointcut.CurrentRow.Index].Task = frmInput.text2;
                    aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Pointcuts[gvPointcut.CurrentRow.Index].Condition = frmInput.text3;

                    updateGridViewPointcut();
                }
            }
        }

        private void tsbPointcutDelete_Click(object sender, EventArgs e)
        {
            if (existPointcut()
                && MessageBox.Show("Are you sure to delete this pointcut?", "Delete a pointcut", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Pointcuts.Remove(
                    aspects[gvAspect.CurrentRow.Index].Advices[gvAdvice.CurrentRow.Index].Pointcuts[gvPointcut.CurrentRow.Index]);
                updateGridViewPointcut();
            }
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pointcut Editor version 1.0", "About ...");
        }

        private void frmPointcutEditor_Load(object sender, EventArgs e)
        {
            reloadToolStripMenuItem_Click(sender, e);
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            string result = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n";
            result += "<aspects>\n";
            foreach (Aspect a in aspects)
            {
                result += "  <aspect name=\"" + a.Name + "\">\n";
                result += "    <advices>\n";
                foreach (Advice b in a.Advices)
                {
                    result += "      <advice name=\"" + b.Name + "\" process=\"" + b.Process + "\" goal=\"" + b.Goal + "\" >\n";
                    result += "        <pointcuts>\n";
                    foreach (Pointcut p in b.Pointcuts)
                    {
                        result += "          <pointcut process=\"" + p.Process + "\" task=\"" + p.Task + "\" condition=\"" + p.Condition + "\" />\n";
                    }
                    result += "        </pointcuts>\n";
                    result += "      </advice>\n";
                }
                result += "    </advices>\n";
                result += "  </aspect>\n";
            }

            result += "</aspects>\n";

            System.IO.StreamWriter file = new System.IO.StreamWriter(ReadRules.fileName);
            file.WriteLine(result);
            file.Close();
        }

        private void gvPointcut_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbPointcutEdit_Click(sender, e);
        }

        private void gvAdvice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbAdviceEdit_Click(sender, e);
        }

        private void gvAspect_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbAspectEdit_Click(sender, e);
        }
    }
}
