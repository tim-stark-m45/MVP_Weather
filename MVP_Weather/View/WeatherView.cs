using MVP_Weather.Model;
using MVP_Weather.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Weather.View
{
    public partial class WeatherView : Form
    {
        public WeatherPresenter Presenter { get; set; }

        public WeatherView()
        {
            InitializeComponent();
        }

        private void OnAddButtonClick(object sender, EventArgs e)
        {
            var city = new City { Name = CityNameTextbox.Text };

            try
            {
                Presenter.AddCity(city);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowCities(IEnumerable<City> cities)
        {
            CityListbox.DataSource = null;
            CityListbox.SelectionMode = SelectionMode.None;
            CityListbox.SelectionMode = SelectionMode.One;
            CityListbox.DataSource = cities;
            CityNameTextbox.Text = "";
        }

        public void ShowWeather()
        {
            int n = 0;
            var city = CityListbox.SelectedItem as City;
            CityNameLabel.Text = city.Name;
            TemperatureLabel.Text = city.Weathers[n].Temperature.ToString();
            labelMinTemp.Text = city.Weathers[n].MinTemp.ToString();
            labelMaxTemp.Text = city.Weathers[n].MaxTemp.ToString();
            labelDescription.Text = city.Weathers[n].Description.ToString();
            labelWindSpeed.Text = city.Weathers[n].WindSpeed.ToString();
            labelDate2.Text = city.Weathers[n].Date.ToString();
            if (city.Weathers[n].Icon.ToString() == "03n")
            {
                pictureBox1.Image = Properties.Resources._03n;
            }
            if (city.Weathers[n].Icon.ToString() == "03d")
            {
                pictureBox1.Image = Properties.Resources._03d;
            }
            else if (city.Weathers[n].Icon.ToString() == "02n")
            {
                pictureBox1.Image = Properties.Resources._02n;
            }
            else if (city.Weathers[n].Icon.ToString() == "01n")
            {
                pictureBox1.Image = Properties.Resources._01n;
            }
            else if (city.Weathers[n].Icon.ToString() == "01d")
            {
                pictureBox1.Image = Properties.Resources._01d;
            }
            else if (city.Weathers[n].Icon.ToString() == "02d")
            {
                pictureBox1.Image = Properties.Resources._02d;
            }
            else if (city.Weathers[n].Icon.ToString() == "50d")
            {
                pictureBox1.Image = Properties.Resources._50d;
            }
            if (city.Weathers[n].Icon.ToString() == "50n")
            {
                pictureBox1.Image = Properties.Resources._50n;
            }
            else if (city.Weathers[n].Icon.ToString() == "04d")
            {
                pictureBox1.Image = Properties.Resources._04d;
            }
            if (city.Weathers[n].Icon.ToString() == "04n")
            {
                pictureBox1.Image = Properties.Resources._04n;
            }
            else if (city.Weathers[n].Icon.ToString() == "09d")
            {
                pictureBox1.Image = Properties.Resources._09d;
            }
            if (city.Weathers[n].Icon.ToString() == "09n")
            {
                pictureBox1.Image = Properties.Resources._09n;
            }
            else if (city.Weathers[n].Icon.ToString() == "10d")
            {
                pictureBox1.Image = Properties.Resources._10d;
            }
            else if (city.Weathers[n].Icon.ToString() == "10n")
            {
                pictureBox1.Image = Properties.Resources._10n;
            }
            else if (city.Weathers[n].Icon.ToString() == "11d")
            {
                pictureBox1.Image = Properties.Resources._11d;
            }
            if (city.Weathers[n].Icon.ToString() == "11n")
            {
                pictureBox1.Image = Properties.Resources._11n;
            }
            else if (city.Weathers[n].Icon.ToString() == "13d")
            {
                pictureBox1.Image = Properties.Resources._13d;
            }
            if (city.Weathers[n].Icon.ToString() == "13n")
            {
                pictureBox1.Image = Properties.Resources._13n;
            }
        }

        public void ShowWeather2(int m=0,int n=7,string s="2 день")
        {
            if (tabControl1.TabPages[m].Text == s)
            {
                var city = CityListbox.SelectedItem as City;
                label1.Text = city.Name;
                label2.Text = city.Weathers[n].Temperature.ToString();
                label3.Text = city.Weathers[n].MinTemp.ToString();
                label4.Text = city.Weathers[n].MaxTemp.ToString();
                label5.Text = city.Weathers[n].Description.ToString();
                label6.Text = city.Weathers[n].WindSpeed.ToString();
                labelDate.Text = city.Weathers[n].Date.ToString();
                if (city.Weathers[n].Icon.ToString() == "03n")
                {
                    pictureBox2.Image = Properties.Resources._03n;
                }
                if (city.Weathers[n].Icon.ToString() == "03d")
                {
                    pictureBox2.Image = Properties.Resources._03d;
                }
                else if (city.Weathers[n].Icon.ToString() == "02n")
                {
                    pictureBox2.Image = Properties.Resources._02n;
                }
                else if (city.Weathers[n].Icon.ToString() == "01n")
                {
                    pictureBox2.Image = Properties.Resources._01n;
                }
                else if (city.Weathers[n].Icon.ToString() == "01d")
                {
                    pictureBox2.Image = Properties.Resources._01d;
                }
                else if (city.Weathers[n].Icon.ToString() == "02d")
                {
                    pictureBox2.Image = Properties.Resources._02d;
                }
                else if (city.Weathers[n].Icon.ToString() == "50d")
                {
                    pictureBox2.Image = Properties.Resources._50d;
                }
                if (city.Weathers[n].Icon.ToString() == "50n")
                {
                    pictureBox2.Image = Properties.Resources._50n;
                }
                else if (city.Weathers[n].Icon.ToString() == "04d")
                {
                    pictureBox2.Image = Properties.Resources._04d;
                }
                if (city.Weathers[n].Icon.ToString() == "04n")
                {
                    pictureBox2.Image = Properties.Resources._04n;
                }
                else if (city.Weathers[n].Icon.ToString() == "09d")
                {
                    pictureBox2.Image = Properties.Resources._09d;
                }
                if (city.Weathers[n].Icon.ToString() == "09n")
                {
                    pictureBox2.Image = Properties.Resources._09n;
                }
                else if (city.Weathers[n].Icon.ToString() == "10d")
                {
                    pictureBox2.Image = Properties.Resources._10d;
                }
                else if (city.Weathers[n].Icon.ToString() == "10n")
                {
                    pictureBox2.Image = Properties.Resources._10n;
                }
                else if (city.Weathers[n].Icon.ToString() == "11d")
                {
                    pictureBox2.Image = Properties.Resources._11d;
                }
                if (city.Weathers[n].Icon.ToString() == "11n")
                {
                    pictureBox2.Image = Properties.Resources._11n;
                }
                else if (city.Weathers[n].Icon.ToString() == "13d")
                {
                    pictureBox2.Image = Properties.Resources._13d;
                }
                if (city.Weathers[n].Icon.ToString() == "13n")
                {
                    pictureBox2.Image = Properties.Resources._13n;
                }
            }
        }

        public void ShowWeather3(int m = 1, int n = 15, string s = "3 день")
        {
            if (tabControl1.TabPages[m].Text == s)
            {
                var city = CityListbox.SelectedItem as City;
                label12.Text = city.Name;
                label11.Text = city.Weathers[n].Temperature.ToString();
                label10.Text = city.Weathers[n].MinTemp.ToString();
                label9.Text = city.Weathers[n].MaxTemp.ToString();
                label8.Text = city.Weathers[n].Description.ToString();
                label7.Text = city.Weathers[n].WindSpeed.ToString();
                label25.Text = city.Weathers[n].Date.ToString();
                if (city.Weathers[n].Icon.ToString() == "03n")
                {
                    pictureBox3.Image = Properties.Resources._03n;
                }
                if (city.Weathers[n].Icon.ToString() == "03d")
                {
                    pictureBox3.Image = Properties.Resources._03d;
                }
                else if (city.Weathers[n].Icon.ToString() == "02n")
                {
                    pictureBox3.Image = Properties.Resources._02n;
                }
                else if (city.Weathers[n].Icon.ToString() == "01n")
                {
                    pictureBox3.Image = Properties.Resources._01n;
                }
                else if (city.Weathers[n].Icon.ToString() == "01d")
                {
                    pictureBox3.Image = Properties.Resources._01d;
                }
                else if (city.Weathers[n].Icon.ToString() == "02d")
                {
                    pictureBox3.Image = Properties.Resources._02d;
                }
                else if (city.Weathers[n].Icon.ToString() == "50d")
                {
                    pictureBox3.Image = Properties.Resources._50d;
                }
                if (city.Weathers[n].Icon.ToString() == "50n")
                {
                    pictureBox3.Image = Properties.Resources._50n;
                }
                else if (city.Weathers[n].Icon.ToString() == "04d")
                {
                    pictureBox3.Image = Properties.Resources._04d;
                }
                if (city.Weathers[n].Icon.ToString() == "04n")
                {
                    pictureBox3.Image = Properties.Resources._04n;
                }
                else if (city.Weathers[n].Icon.ToString() == "09d")
                {
                    pictureBox3.Image = Properties.Resources._09d;
                }
                if (city.Weathers[n].Icon.ToString() == "09n")
                {
                    pictureBox3.Image = Properties.Resources._09n;
                }
                else if (city.Weathers[n].Icon.ToString() == "10d")
                {
                    pictureBox3.Image = Properties.Resources._10d;
                }
                else if (city.Weathers[n].Icon.ToString() == "10n")
                {
                    pictureBox3.Image = Properties.Resources._10n;
                }
                else if (city.Weathers[n].Icon.ToString() == "11d")
                {
                    pictureBox3.Image = Properties.Resources._11d;
                }
                if (city.Weathers[n].Icon.ToString() == "11n")
                {
                    pictureBox3.Image = Properties.Resources._11n;
                }
                else if (city.Weathers[n].Icon.ToString() == "13d")
                {
                    pictureBox3.Image = Properties.Resources._13d;
                }
                if (city.Weathers[n].Icon.ToString() == "13n")
                {
                    pictureBox3.Image = Properties.Resources._13n;
                }
            }
        }

        public void ShowWeather4(int m = 2, int n = 23, string s = "4 день")
        {
            if (tabControl1.TabPages[m].Text == s)
            {
                var city = CityListbox.SelectedItem as City;
                label18.Text = city.Name;
                label17.Text = city.Weathers[n].Temperature.ToString();
                label16.Text = city.Weathers[n].MinTemp.ToString();
                label15.Text = city.Weathers[n].MaxTemp.ToString();
                label14.Text = city.Weathers[n].Description.ToString();
                label13.Text = city.Weathers[n].WindSpeed.ToString();
                label26.Text = city.Weathers[n].Date.ToString();
                if (city.Weathers[n].Icon.ToString() == "03n")
                {
                    pictureBox4.Image = Properties.Resources._03n;
                }
                if (city.Weathers[n].Icon.ToString() == "03d")
                {
                    pictureBox4.Image = Properties.Resources._03d;
                }
                else if (city.Weathers[n].Icon.ToString() == "02n")
                {
                    pictureBox4.Image = Properties.Resources._02n;
                }
                else if (city.Weathers[n].Icon.ToString() == "01n")
                {
                    pictureBox4.Image = Properties.Resources._01n;
                }
                else if (city.Weathers[n].Icon.ToString() == "01d")
                {
                    pictureBox4.Image = Properties.Resources._01d;
                }
                else if (city.Weathers[n].Icon.ToString() == "02d")
                {
                    pictureBox4.Image = Properties.Resources._02d;
                }
                else if (city.Weathers[n].Icon.ToString() == "50d")
                {
                    pictureBox4.Image = Properties.Resources._50d;
                }
                if (city.Weathers[n].Icon.ToString() == "50n")
                {
                    pictureBox4.Image = Properties.Resources._50n;
                }
                else if (city.Weathers[n].Icon.ToString() == "04d")
                {
                    pictureBox4.Image = Properties.Resources._04d;
                }
                if (city.Weathers[n].Icon.ToString() == "04n")
                {
                    pictureBox4.Image = Properties.Resources._04n;
                }
                else if (city.Weathers[n].Icon.ToString() == "09d")
                {
                    pictureBox4.Image = Properties.Resources._09d;
                }
                if (city.Weathers[n].Icon.ToString() == "09n")
                {
                    pictureBox4.Image = Properties.Resources._09n;
                }
                else if (city.Weathers[n].Icon.ToString() == "10d")
                {
                    pictureBox4.Image = Properties.Resources._10d;
                }
                else if (city.Weathers[n].Icon.ToString() == "10n")
                {
                    pictureBox4.Image = Properties.Resources._10n;
                }
                else if (city.Weathers[n].Icon.ToString() == "11d")
                {
                    pictureBox4.Image = Properties.Resources._11d;
                }
                if (city.Weathers[n].Icon.ToString() == "11n")
                {
                    pictureBox4.Image = Properties.Resources._11n;
                }
                else if (city.Weathers[n].Icon.ToString() == "13d")
                {
                    pictureBox4.Image = Properties.Resources._13d;
                }
                if (city.Weathers[n].Icon.ToString() == "13n")
                {
                    pictureBox4.Image = Properties.Resources._13n;
                }
            }
        }

        public void ShowWeather5(int m = 3, int n = 31, string s = "5 день")
        {
            if (tabControl1.TabPages[m].Text == s)
            {
                var city = CityListbox.SelectedItem as City;
                label24.Text = city.Name;
                label23.Text = city.Weathers[n].Temperature.ToString();
                label22.Text = city.Weathers[n].MinTemp.ToString();
                label21.Text = city.Weathers[n].MaxTemp.ToString();
                label20.Text = city.Weathers[n].Description.ToString();
                label19.Text = city.Weathers[n].WindSpeed.ToString();
                label27.Text = city.Weathers[n].Date.ToString();
                if (city.Weathers[n].Icon.ToString() == "03n")
                {
                    pictureBox5.Image = Properties.Resources._03n;
                }
                if (city.Weathers[n].Icon.ToString() == "03d")
                {
                    pictureBox5.Image = Properties.Resources._03d;
                }
                else if (city.Weathers[n].Icon.ToString() == "02n")
                {
                    pictureBox5.Image = Properties.Resources._02n;
                }
                else if (city.Weathers[n].Icon.ToString() == "01n")
                {
                    pictureBox5.Image = Properties.Resources._01n;
                }
                else if (city.Weathers[n].Icon.ToString() == "01d")
                {
                    pictureBox5.Image = Properties.Resources._01d;
                }
                else if (city.Weathers[n].Icon.ToString() == "02d")
                {
                    pictureBox5.Image = Properties.Resources._02d;
                }
                else if (city.Weathers[n].Icon.ToString() == "50d")
                {
                    pictureBox5.Image = Properties.Resources._50d;
                }
                if (city.Weathers[n].Icon.ToString() == "50n")
                {
                    pictureBox5.Image = Properties.Resources._50n;
                }
                else if (city.Weathers[n].Icon.ToString() == "04d")
                {
                    pictureBox5.Image = Properties.Resources._04d;
                }
                if (city.Weathers[n].Icon.ToString() == "04n")
                {
                    pictureBox5.Image = Properties.Resources._04n;
                }
                else if (city.Weathers[n].Icon.ToString() == "09d")
                {
                    pictureBox5.Image = Properties.Resources._09d;
                }
                if (city.Weathers[n].Icon.ToString() == "09n")
                {
                    pictureBox5.Image = Properties.Resources._09n;
                }
                else if (city.Weathers[n].Icon.ToString() == "10d")
                {
                    pictureBox5.Image = Properties.Resources._10d;
                }
                else if (city.Weathers[n].Icon.ToString() == "10n")
                {
                    pictureBox5.Image = Properties.Resources._10n;
                }
                else if (city.Weathers[n].Icon.ToString() == "11d")
                {
                    pictureBox5.Image = Properties.Resources._11d;
                }
                if (city.Weathers[n].Icon.ToString() == "11n")
                {
                    pictureBox5.Image = Properties.Resources._11n;
                }
                else if (city.Weathers[n].Icon.ToString() == "13d")
                {
                    pictureBox5.Image = Properties.Resources._13d;
                }
                if (city.Weathers[n].Icon.ToString() == "13n")
                {
                    pictureBox5.Image = Properties.Resources._13n;
                }
            }
        }

        private void OnCityChanged(object sender, EventArgs e)
        {
            var city = CityListbox.SelectedItem as City;
            Presenter.GetWeather(city);
        }
    }
}
