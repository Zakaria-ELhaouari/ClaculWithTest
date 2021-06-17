using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClaculWithTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Clicked(object sender, EventArgs e)
        {
            var num1 = Int16.Parse(nm1.Text);
            var num2 = Int16.Parse(nm2.Text);

            var res  = Add(num1, num2);

            result.Text = res.ToString();
        }

        public int Add(int nm1 , int nm2)
        {
            var res = nm1 + nm2;

            return res;
        }
    }
}
