using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI.Docking;

namespace meditic
{
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        private Patient p;
        private Medecin med;
        private Personnel pers;

        private RDV rdv;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radButtonElement4_Click(object sender, EventArgs e)
        {
            p = new Patient();
            Telerik.WinControls.UI.Docking.DocumentWindow docWindow = new Telerik.WinControls.UI.Docking.DocumentWindow("Ajouter Patient");
            p.Height = docWindow.Height = this.Height;
            p.Width = docWindow.Width = this.Width;
            docWindow.Controls.Add(p);
            this.radDock1.AddDocument(docWindow);

            this.radDock1.ActiveWindow = docWindow;
            docWindow.CloseAction = DockWindowCloseAction.Close;
        }

        private void radButtonElement7_Click(object sender, EventArgs e)
        {
            med = new Medecin();
            Telerik.WinControls.UI.Docking.DocumentWindow docWindow = new Telerik.WinControls.UI.Docking.DocumentWindow("Ajouter Médecin");
            med.Height = docWindow.Height = this.Height;
            med.Width = docWindow.Width = this.Width;
            docWindow.Controls.Add(med);
            this.radDock1.AddDocument(docWindow);

            this.radDock1.ActiveWindow = docWindow;
            docWindow.CloseAction = DockWindowCloseAction.Close;
        }

        private void radButtonElement14_Click(object sender, EventArgs e)
        {
            this.pers = new Personnel();
            Telerik.WinControls.UI.Docking.DocumentWindow docWindow = new Telerik.WinControls.UI.Docking.DocumentWindow("Ajouter Personnel");
           pers.Height= docWindow.Height = this.Height;
          pers.Width=  docWindow.Width = this.Width;
            docWindow.Controls.Add(pers);
            this.radDock1.AddDocument(docWindow);

            this.radDock1.ActiveWindow = docWindow;
            docWindow.CloseAction = DockWindowCloseAction.Close;
        }

        private void radButtonElement9_Click(object sender, EventArgs e)
        {
            this.rdv = new RDV();
            Telerik.WinControls.UI.Docking.DocumentWindow docWindow = new Telerik.WinControls.UI.Docking.DocumentWindow("Ajouter RDVs à une date");
            rdv.Height = docWindow.Height = this.Height;
            rdv.Width = docWindow.Width = this.Width;
            docWindow.Controls.Add(rdv);
            this.radDock1.AddDocument(docWindow);

            this.radDock1.ActiveWindow = docWindow;
            docWindow.CloseAction = DockWindowCloseAction.Close;
        }

        private void radButtonElement24_Click(object sender, EventArgs e)
        {
            RDV_TODAY rdv_day = new RDV_TODAY();
            Telerik.WinControls.UI.Docking.DocumentWindow docWindow = new Telerik.WinControls.UI.Docking.DocumentWindow("Ajouter RDVs à une date");
            docWindow.Height = this.Height;
            docWindow.Width = this.Width;
            docWindow.Controls.Add(rdv_day);
            this.radDock1.AddDocument(docWindow);

            this.radDock1.ActiveWindow = docWindow;
            docWindow.CloseAction = DockWindowCloseAction.Close;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            radDock1.Width = this.Width;
            radDock1.Height = this.Height;
            if (p != null)
            {
                p.Width = radDock1.Width;
                p.Height = radDock1.Height;
            }
            if (med != null)
            {
                med.Width = radDock1.Width;
                med.Height = radDock1.Height;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
        
        }
    }
}
