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
using MahApps.Metro.Controls;
using OWI535.Library;
using OWI535.Test.WPF.Properties;

namespace OWI535.Test.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public static readonly int VendorID = Settings.Default.VendorID;
        public static readonly int ProductID = Settings.Default.ProductID;
        public static readonly int ArmID = Settings.Default.ArmID;
        public static ArmController arm = new ArmController(VendorID, ProductID, ArmID);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Light_Checked(object sender, RoutedEventArgs e)
        {
            arm.LightOn();
        }

        private void Light_Unchecked(object sender, RoutedEventArgs e)
        {
            arm.LightOff();
        }

        private void ClawUpBtn_Click(object sender, RoutedEventArgs e)
        {
            arm.ClawUp(getArmSeconds(SecondsTxtBox.Text));
        }

        private void ClawDownBtn_Click(object sender, RoutedEventArgs e)
        {
            arm.ClawDown(getArmSeconds(SecondsTxtBox.Text));
        }

        private void ElbowUpBtn_Click(object sender, RoutedEventArgs e)
        {
            arm.ElbowUp(getArmSeconds(SecondsTxtBox.Text));
        }

        private void ElbowownBtn_Click(object sender, RoutedEventArgs e)
        {
            arm.ElbowDown(getArmSeconds(SecondsTxtBox.Text));
        }

        private void ArmUpBtn_Click(object sender, RoutedEventArgs e)
        {
            arm.ArmUp(getArmSeconds(SecondsTxtBox.Text));
        }

        private void ArmDownBtn_Click(object sender, RoutedEventArgs e)
        {
            arm.ArmDown(getArmSeconds(SecondsTxtBox.Text));
        }

        private void ArmRotateLeftBtn_Click(object sender, RoutedEventArgs e)
        {
            arm.RotateLeft(getArmSeconds(SecondsTxtBox.Text));
        }

        private void ArmRotateRightBtn_Click(object sender, RoutedEventArgs e)
        {
            arm.RotateRight(getArmSeconds(SecondsTxtBox.Text));
        }

        private int getArmSeconds(string armsSecondsStringValue)
        {
            int seconds;
            Int32.TryParse(armsSecondsStringValue, out seconds);
            return (seconds * 1000);
        }
    }
}
