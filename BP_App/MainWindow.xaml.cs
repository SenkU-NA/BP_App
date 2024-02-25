using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

namespace BP_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int totalBP = 0;
        SolidColorBrush ForeEn = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
        SolidColorBrush ForeDis = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f1d4d4"));
        SolidColorBrush BackEn = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#80e31e"));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //zero
            if (zero.IsChecked == true)
            {
                zeroText.Background = BackEn;
                zeroText.Foreground = ForeEn;
                totalBP += 2;
                if (vip.IsChecked == true)
                    totalBP += 2;
            }
            else if (zero.IsChecked == false)
            {
                zeroText.Background = Brushes.Transparent;
                zeroText.Foreground = ForeDis;
                totalBP += -2;
                if (vip.IsChecked == true)
                    totalBP -= 2;
            }

            TotalOut.Text = totalBP.ToString();
        }

        private void lottery_Checked(object sender, RoutedEventArgs e)
        {
            //lottery
            if (lottery.IsChecked == true)
            {
                lotteryText.Background = BackEn;
                lotteryText.Foreground = ForeEn;
                totalBP += 1;
                if (vip.IsChecked == true)
                    totalBP += 1;
            }
            else if (lottery.IsChecked == false)
            {
                lotteryText.Background = Brushes.Transparent;
                lotteryText.Foreground = ForeDis;
                totalBP += -1;
                if (vip.IsChecked == true)
                    totalBP -= 1;
            }
            TotalOut.Text = totalBP.ToString();
        }

        int dbcount = 0;
        private void dbadd_Click(object sender, RoutedEventArgs e)
        {
            dbcount++;
            dbcounter.Text = dbcount.ToString();
            if (dbcount >= 3)
            {
                dbText.Background = BackEn;
                dbText.Foreground = ForeEn;
            }
            if (dbcount == 3)
            {
                totalBP += 2;
                if (vip.IsChecked == true)
                    totalBP += 2;
            }
            TotalOut.Text = totalBP.ToString();
        }
        int gymcount = 0;
        private void gymadd_Click(object sender, RoutedEventArgs e)
        {
            gymcount++;
            gymcounter.Text = gymcount.ToString();
            if (gymcount >= 20)
            {
                gymText.Background = BackEn;
                gymText.Foreground = ForeEn;
            }
            if (gymcount == 20)
            {
                totalBP += 1;
                if (vip.IsChecked == true)
                    totalBP += 1;
            }
            TotalOut.Text = totalBP.ToString();
        }

        private void shooting_Checked(object sender, RoutedEventArgs e)
        {
            if (shooting.IsChecked == true)
            {
                shootingGalleryText.Background = BackEn;
                shootingGalleryText.Foreground = ForeEn;
                totalBP += 1;
                if (vip.IsChecked == true)
                    totalBP += 1;
            }
            else if (shooting.IsChecked == false)
            {
                shootingGalleryText.Background = Brushes.Transparent;
                shootingGalleryText.Foreground = ForeDis;
                totalBP += -1;
                if (vip.IsChecked == true)
                    totalBP -= 1;
            }
            TotalOut.Text = totalBP.ToString();
        }

        private void cinema_Checked(object sender, RoutedEventArgs e)
        {
            if (cinema.IsChecked == true)
            {
                cinemaText.Background = BackEn;
                cinemaText.Foreground = ForeEn;
                totalBP += 1; 
                if (vip.IsChecked == true)
                    totalBP += 1;
            }
            else if (cinema.IsChecked == false)
            {
                cinemaText.Background = Brushes.Transparent;
                cinemaText.Foreground = ForeDis;
                totalBP += -1;
                if (vip.IsChecked == true)
                    totalBP -= 1;
            }
            TotalOut.Text = totalBP.ToString();
        }

        private void kart_Checked(object sender, RoutedEventArgs e)
        {
            if (kart.IsChecked == true)
            {
                kartText.Background = BackEn;
                kartText.Foreground = ForeEn;
                totalBP += 1;
                if (vip.IsChecked == true)
                    totalBP += 1;
            }
            else if (kart.IsChecked == false)
            {
                kartText.Background = Brushes.Transparent;
                kartText.Foreground = ForeDis;
                totalBP += -1;
                if (vip.IsChecked == true)
                    totalBP += -1;
            }
            TotalOut.Text = totalBP.ToString();
        }
        int farmcount = 0;
        private void farmadd_Click(object sender, RoutedEventArgs e)
        {
            farmcount++;
            farmcounter.Text = farmcount.ToString();
            if (farmcount >= 10)
            {
                farmText.Background = BackEn;
                farmText.Foreground = ForeEn;
            }
            if (farmcount == 10)
            {
                totalBP += 1;
                if (vip.IsChecked == true)
                    totalBP += 1;
            }
            TotalOut.Text = totalBP.ToString();
        }

        int ffcount = 0;
        private void ffcounter_Click(object sender, RoutedEventArgs e)
        {
            ffcount++;
            firefighters.Text = ffcount.ToString();
            if (ffcount >= 25)
            {
                firefightersText.Background = BackEn;
                firefightersText.Foreground = ForeEn;
            }
            if (ffcount == 25)
            {
                totalBP += 1;
                if (vip.IsChecked == true)
                    totalBP += 1;
            }
            TotalOut.Text = totalBP.ToString();
        }

        private void mail_Checked(object sender, RoutedEventArgs e)
        {
            if (mail.IsChecked == true)
            {
                mailText.Background = BackEn;
                mailText.Foreground = ForeEn;
                totalBP += 1;
                if (vip.IsChecked == true)
                    totalBP += 1;
            }
            else if (mail.IsChecked == false)
            {
                mailText.Background = Brushes.Transparent;
                mailText.Foreground = ForeDis;
                totalBP += -1;
                if (vip.IsChecked == true)
                    totalBP += -1;
            }
            TotalOut.Text = totalBP.ToString();
        }

        private void studio_Checked(object sender, RoutedEventArgs e)
        {
            if (studio.IsChecked == true)
            {
                studioText.Background = BackEn;
                studioText.Foreground = ForeEn;
                totalBP += 2;
                if (vip.IsChecked == true)
                    totalBP += 2;
            }
            else if (studio.IsChecked == false)
            {
                studioText.Background = Brushes.Transparent;
                studioText.Foreground = ForeDis;
                totalBP += -2;
                if (vip.IsChecked == true)
                    totalBP += 2;
            }
            TotalOut.Text = totalBP.ToString();
        }

        private void streetrace_Checked(object sender, RoutedEventArgs e)
        {
            if (streetrace.IsChecked == true)
            {
                streetraceText.Background = BackEn;
                streetraceText.Foreground = ForeEn;
                totalBP += 1;
                if (vip.IsChecked == true)
                    totalBP += 1;
            }
            else if (streetrace.IsChecked == false)
            {
                streetraceText.Background = Brushes.Transparent;
                streetraceText.Foreground = ForeDis;
                totalBP += -1;
                if (vip.IsChecked == true)
                    totalBP += -1;
            }
            TotalOut.Text = totalBP.ToString();
        }
        int tccount = 0;
        private void tcadd_Click(object sender, RoutedEventArgs e)
        {
            tccount++;
            tccounter.Text = tccount.ToString();
            if (tccount >= 5)
            {
                TCText.Background = BackEn;
                TCText.Foreground = ForeEn;
            }
            if (tccount == 5)
            {
                totalBP += 1;
                if (vip.IsChecked == true)
                    totalBP += 1;
            }
            TotalOut.Text = totalBP.ToString();
        }

        private void arena_Checked(object sender, RoutedEventArgs e)
        {
            if (arena.IsChecked == true)
            {
                arenaText.Background = BackEn;
                arenaText.Foreground = ForeEn;
                totalBP += 1;
                if (vip.IsChecked == true)
                    totalBP += 1;
            }
            else if (arena.IsChecked == false)
            {
                arenaText.Background = Brushes.Transparent;
                arenaText.Foreground = ForeDis;
                totalBP += -1;
                if (vip.IsChecked == true)
                    totalBP += -1;
            }
            TotalOut.Text = totalBP.ToString();
        }

        private void DropAllButton_Click(object sender, RoutedEventArgs e)
        {
            zero.IsChecked = lottery.IsChecked = shooting.IsChecked = mail.IsChecked = 
                studio.IsChecked = kart.IsChecked = streetrace.IsChecked = cinema.IsChecked = arena.IsChecked = false;
            dbcount = tccount = farmcount = ffcount = gymcount = 0;
            dbcounter.Text = tccounter.Text = farmcounter.Text = firefighters.Text = gymcounter.Text = "0";
            TotalOut.Text = "0";
            totalBP = 0;

            dbText.Background = gymText.Background = farmText.Background = firefightersText.Background = TCText.Background = Brushes.Transparent;
            dbText.Foreground = gymText.Foreground = farmText.Foreground = firefightersText.Foreground = TCText.Foreground = ForeDis;
        }

        private void vip_Checked(object sender, RoutedEventArgs e)
        {
            if (vip.IsChecked == true)
                vipstat.Text = "Enable";
            else
                vipstat.Text = "Disable";
        }
    }
}
