using System;
using System.Windows.Forms;

namespace TicTacToeApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ��������� ���������� � MainForm
            Application.Run(new MainForm());
        }
    }
}
