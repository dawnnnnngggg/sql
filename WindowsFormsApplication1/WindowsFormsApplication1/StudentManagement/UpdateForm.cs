using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.StudentManagement
{
    public partial class UpdateForm : Form
    {
        private int StudentId;
        private LogicLayer Business;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.StudentId = id;
            this.Business = new LogicLayer();
            this.Load += UpdateForm_Load;
        }

        void UpdateForm_Load(object sender, EventArgs e)
        {
            var student = this.Business.GetStudent(this.StudentId);
            this.cpbClass.DataSource = this.Business.GetClasses();
            this.cpbClass.DisplayMember = "Name";
            this.cpbClass.ValueMember = "id";
            this.cpbClass.SelectedValue = student.Class_id;
        }
    }
}
