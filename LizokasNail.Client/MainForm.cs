using LizokasNail.Client.Forms;
using LizokasNail.Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LizokasNail.Client
{
    public partial class MainForm : Form
    {
        #region Ctr

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Ctr

        #region Props

        /// <summary>
        /// экземпляр класса (паттерн Singleton)
        /// </summary>
        private static MainForm _instance;

        /// <summary>
        /// Экземпляр класса (паттерн Singleton)
        /// </summary>
        public static MainForm Instance => _instance ?? (_instance = new MainForm());

        /// <summary>Открытые закладки</summary>
        private readonly Dictionary<string, UserControl> _openedTabSheets = new Dictionary<string, UserControl>();

        #endregion Props

        #region Работа с закладками

        /// <summary>Открыть контрол на таб закладке</summary>
        /// <typeparam name="T">Контрол который надо открыть</typeparam>
        /// <param name="name">Имя закладки</param>
        /// <param name="caption">Текст заголовка закладки</param>
        /// <returns>Ссылка на контрол</returns>
        private T TryOpenTabSheet<T>(string name, string caption) where T : UserControl, new()
        {
            if (_openedTabSheets.ContainsKey(name))
            {
                xtraTabControl.SelectedTabPage = xtraTabControl.TabPages.FirstOrDefault(x => x.Name == name);
                _openedTabSheets[name].Focus();
                _openedTabSheets[name].Select();
                return _openedTabSheets[name] as T;
            }
            else
            {
                var uc = new T();
                var tp = new DevExpress.XtraTab.XtraTabPage() { Name = name, Text = caption };
                tp.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;

                xtraTabControl.TabPages.Add(tp);
                _openedTabSheets.Add(name, uc);

                xtraTabControl.SelectedTabPage = tp;

                _openedTabSheets[name].Focus();
                _openedTabSheets[name].Select();

                return uc;
            }
        }

        /// <summary>Закрыть открытую вкладку</summary>
        /// <param name="name"></param>
        public void CloseTabSheet(string name)
        {
            if (_openedTabSheets.ContainsKey(name))
            {
                var con = _openedTabSheets[name];
                _openedTabSheets.Remove(name);
                var index = xtraTabControl.SelectedTabPageIndex - 1;

                var tab = xtraTabControl.TabPages.FirstOrDefault(x => x.Name == name);
                xtraTabControl.TabPages.Remove(tab);                
                xtraTabControl.SelectedTabPageIndex = index;
            }
            GC.Collect();
        }

        public void SelectMainTab()
        {
            xtraTabControl.SelectedTabPageIndex = 0;
        }

        private void CloseAllTabs()
        {
            while (xtraTabControl.TabPages.Count > 1)
            {
                DevExpress.XtraTab.XtraTabPage ts = xtraTabControl.TabPages[1];
                if (ts.Name != "xtraTabPageMain")
                    CloseTabSheet(ts.Name);
            }
        }

        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            var args = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            if (args?.Page is DevExpress.XtraTab.XtraTabPage && ((DevExpress.XtraTab.XtraTabPage)args.Page).Name != "xtraTabPageMain")
                CloseTabSheet(((DevExpress.XtraTab.XtraTabPage)args.Page).Name);
        }

        #endregion Работа с закладками

        #region Menu

        private void barButtonItemUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var form = new UserForm();
            //form.Show();
            var uc = TryOpenTabSheet<UCUser>("TabPageUser", "Клиенты");
            uc.Init();
        }

        private void barButtonItemRecords_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var uc = TryOpenTabSheet<UCRecord>("TabPageRecord", "Записи");
            uc.Init();
        }

        private void barButtonItemBase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var uc = TryOpenTabSheet<UCBase>("TabPageBase", "Базы");
            uc.Init();
        }

        private void barButtonItemColor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var uc = TryOpenTabSheet<UCColor>("TabPageColor", "Цвета");
            uc.Init();
        }

        private void barButtonItemTop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var uc = TryOpenTabSheet<UCTop>("TabPageTop", "Топы");
            uc.Init();
        }

        private void barButtonItemDesign_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var uc = TryOpenTabSheet<UCDesign>("TabPageDesign", "Дизайны");
            uc.Init();
        }

        private void barButtonItemCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var uc = TryOpenTabSheet<UCCheck>("TabPageCheck", "Расчеты");
            uc.Init();
        }


        #endregion Menu


    }
}
