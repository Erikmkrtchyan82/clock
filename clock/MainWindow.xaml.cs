using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer Timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;

            second.RenderTransform = new RotateTransform(2* d.Second/60.0 *180);
            var h = d.Hour > 12 ? d.Hour - 12 : d.Hour;
            hour.RenderTransform = new RotateTransform(2*h/12.0*180);
            minuite.RenderTransform = new RotateTransform(2*d.Minute/60.0*180);
            box.Text = d.Hour + ":" + d.Minute + ":" + d.Second;
        }

    }
}
