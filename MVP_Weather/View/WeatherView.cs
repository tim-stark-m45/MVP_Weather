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
            var city = CityListbox.SelectedItem as City;
            CityNameLabel.Text = city.Name;
            TemperatureLabel.Text = city.Weathers[0].Temperature.ToString();
            labelMinTemp.Text = city.Weathers[0].MinTemp.ToString();
            labelMaxTemp.Text = city.Weathers[0].MaxTemp.ToString();
            labelDescription.Text = city.Weathers[0].Description.ToString();
            labelWindSpeed.Text = city.Weathers[0].WindSpeed.ToString();
            //pictureBox1.Image = Properties.Resources._02n;
            //labelIcon.Text = city.Weathers[0].Icon.ToString();
            if (city.Weathers[0].Icon.ToString() == "03n")
            {
                pictureBox1.Image = Properties.Resources._03n;
                //pictureBox1.Image = Properties.Resources._02n;
            }
            else if (city.Weathers[0].Icon.ToString() == "02n")
            {
                pictureBox1.Image = Properties.Resources._02n;
            }
        }

        private void OnCityChanged(object sender, EventArgs e)
        {
            var city = CityListbox.SelectedItem as City;
            Presenter.GetWeather(city);
        }
    }
}
