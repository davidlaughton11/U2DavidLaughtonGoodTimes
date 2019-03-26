//David Laughton
//March 25th 2019
//Good times program to generate timezones
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

namespace U2DavidLaughtonGoodTimes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        //intigers for timezones 
        int MountainTime;
        int EasternTime;        
        int PaciﬁcTime;
        int CentralTime;
        int AtlanticTime;
        int NewfoundlandTime;
        int timeott;

        private void BtnRun_Click(object sender, RoutedEventArgs e)
        {            
            int.TryParse(txtInput.Text, out timeott);
             
            //Main if statement that applys when all numbers will be in the range 0-2400 when adgusted
            if (timeott >= 300 && timeott <= 2230)
            {
                AtlanticTime = timeott + 100;
                NewfoundlandTime = timeott + 130;
                CentralTime = timeott - 100;
                MountainTime = timeott - 200;
                PaciﬁcTime = timeott - 300;
                EasternTime = timeott;
            }
            //All other else if statements address the idividual changes the timezones they would become a fake time
            else if (timeott >= 2300 && timeott <= 2359)
            {
                AtlanticTime = timeott - 2300;
                NewfoundlandTime = timeott - 2230;
                CentralTime = timeott - 100;
                MountainTime = timeott - 200;
                PaciﬁcTime = timeott - 300;
                EasternTime = timeott;
            }
            else if (timeott >= 2230 && timeott <= 2300)
            {
                AtlanticTime = timeott + 100;
                NewfoundlandTime = timeott - 2230;
                CentralTime = timeott - 100;
                MountainTime = timeott - 200;
                PaciﬁcTime = timeott - 300;
                EasternTime = timeott;
            }
            else if (timeott <= 59 && timeott >= 0)
            {
                AtlanticTime = timeott + 100;
                NewfoundlandTime = timeott + 130;
                CentralTime = timeott + 2300;
                MountainTime = timeott + 2200;
                PaciﬁcTime = timeott + 2100;
                EasternTime = timeott;
            }
            else if (timeott <= 159 && timeott >= 59)
            {
                AtlanticTime = timeott + 100;
                NewfoundlandTime = timeott - 2330;
                CentralTime = timeott - 100;
                MountainTime = timeott + 2200;
                PaciﬁcTime = timeott + 2100;
                EasternTime = timeott;
            }
            else if (timeott <= 259 && timeott >= 159)
            {
                AtlanticTime = timeott + 100;
                NewfoundlandTime = timeott + 130;
                CentralTime = timeott - 100;
                MountainTime = timeott - 200;
                PaciﬁcTime = timeott + 2100;
                EasternTime = timeott;
            }
            //output times 
            lblOutput.Content = 
                EasternTime + "in Ottawa" + Environment.NewLine 
                + PaciﬁcTime + " in Victoria" + Environment.NewLine 
                + MountainTime + " in Edmonton" + Environment.NewLine
                + CentralTime + " in Winnipeg" + Environment.NewLine
                + EasternTime + " in Toronto" + Environment.NewLine
                + AtlanticTime + " in Halifax" + Environment.NewLine
                + NewfoundlandTime + "in St. John’s" + Environment.NewLine;
        }
    }
}
