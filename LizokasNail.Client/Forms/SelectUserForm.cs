using LizokasNail.Client.Di;
using LizokasNail.Client.Forms.Edit;
using System;
using System.Windows.Forms;
using Unity;

namespace LizokasNail.Client.Forms
{
    public partial class SelectUserForm : Form
    {
        private readonly IRecordRepo _repo;

        public SelectUserForm()
        {
            InitializeComponent();
            _repo = Di.Container.Instance.Resolve<IRecordRepo>();
        }

        private void simpleButtonNewUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var form = new NewUserForm();            
            DialogResult = form.ShowDialog();
        }

        private void simpleButtonOldUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var form = new EditRecordForm(_repo);
            DialogResult = form.ShowDialog();
        }
    }
}
