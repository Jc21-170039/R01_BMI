using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        double cm,kg,bmi;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender,EventArgs e)
        {
        

            cm=double.Parse(cm.Text)/100;
            kg=double.Parse(kg.Text);

            bmi=Math.Round(kg/(cm*cm));

            BMI.text=bmi.ToString();
        }
    }
}
