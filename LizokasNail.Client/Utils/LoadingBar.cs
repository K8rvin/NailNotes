using LizokasNail.Client.UserControls;
using System;
using System.Windows.Forms;

namespace LizokasNail.Client.Utils
{
    public class LoadingBar
    {
        internal static LoadingBar Instance = new LoadingBar();

        /// <summary>
        /// Показать экран загрузки во время выполнения операции
        /// </summary>
        /// <param name="form">Форма, на которой появится полоска ожидания</param>
        /// <param name="actionInLoading">основная длительная операция для выполнения в другом потоке (часто загрузка данных из бд)
        /// Важно!!! В операции не должно быть обращения к элементам формы, т.к. к ним не будет доступа из другого потока</param>
        /// <param name="actionAfterLoading">операция, следующая за основной, если основная выполнена без ошибок (часто работа с элементами формы)</param>
        public void ShowLoading(Form form, Action actionInLoading, Action actionAfterLoading)
        {
            Exception except = null;
            var frm = new UCLoading(form);
            frm.DoWork = delegate
            {
                try
                {
                    actionInLoading();
                }
                catch (Exception ex)
                {
                    except = ex;
                    return;
                }
            };
            frm.DoEndWork = delegate
            {
                if (except != null)
                {
                    MessageBox.Show($"{except.Message}{(except?.InnerException?.Message != null ? $"\nПодробности: { except?.InnerException?.Message}" : string.Empty)}", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actionAfterLoading();
                }
            };
            frm.Run();
        }
    }
}
