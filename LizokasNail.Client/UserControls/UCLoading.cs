using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LizokasNail.Client.UserControls
{
    public delegate void DoSimpleDelegate();

    public partial class UCLoading : UserControl
    {
        private Form _frm;
        private BackgroundWorker _bw = new BackgroundWorker();
        private Timer _timer = new Timer();
        private DateTime _timeStart;

        public delegate void SimplDelegate();
        public SimplDelegate myDelegateAddControl;
        public SimplDelegate myDelegateVisible;
        public SimplDelegate myDelegateInVisible;

        public UCLoading(Form frm)
        {
            InitializeComponent();
            myDelegateAddControl = new SimplDelegate(AddControl);
            myDelegateVisible = new SimplDelegate(SetVisible);
            myDelegateInVisible = new SimplDelegate(SetInVisible);

            Visible = false;
            _timer.Tick += Timer_Tick;
            _frm = frm;
            AddControl();
        }

        public UCLoading(Form frm, string message)
        {
            InitializeComponent();
            labelMsg.Text = message;
            myDelegateAddControl = new SimplDelegate(AddControl);
            myDelegateVisible = new SimplDelegate(SetVisible);
            myDelegateInVisible = new SimplDelegate(SetInVisible);

            Visible = false;
            _timer.Tick += Timer_Tick;
            _frm = frm;
            AddControl();
        }

        private void AddControl()
        {
            try
            {
                _frm.Controls.Add(this);
                this.Location = new Point((_frm.Width / 2) - (Width / 2), (_frm.Height / 2) - (Height / 2));
                this.BringToFront();
            }
            catch (Exception)
            {
                _frm.Invoke(myDelegateAddControl);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var diff = DateTime.Now - _timeStart;
            labelControl1.Text = (diff.Hours < 10 ? "0" : "") + diff.Hours + " ч "
                + (diff.Minutes < 10 ? "0" : "") + diff.Minutes + " м "
                + (diff.Seconds < 10 ? "0" : "") + diff.Seconds + " c";
        }

        public DoSimpleDelegate DoWork
        {
            set { _bw.DoWork += delegate { value(); }; }
        }

        public DoSimpleDelegate DoEndWork
        {
            set
            {
                _bw.RunWorkerCompleted += delegate
                {
                    _timer.Stop();
                    SetVisible();
                    _frm.Controls.Remove(this);
                    value();
                };
            }
        }

        public void Run()
        {
            SetInVisible();
            _timeStart = DateTime.Now;
            _timer.Start();
            _bw.RunWorkerAsync();
        }

        private void SetVisible()
        {
            try
            {
                this.Visible = false;
                if (_frm.Controls != null)
                {
                    foreach (var con in _frm.Controls)
                    {
                        if (con is Control && con != this)
                        {
                            ((Control)con).Enabled = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                _frm.Invoke(myDelegateVisible);
            }
        }

        private void SetInVisible()
        {
            try
            {
                this.Visible = true;
                if (_frm.Controls != null)
                {
                    foreach (var con in _frm.Controls)
                    {
                        if (con is Control && con != this)
                        {
                            ((Control)con).Enabled = false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                _frm.Invoke(myDelegateInVisible);
            }
        }
    }
}
