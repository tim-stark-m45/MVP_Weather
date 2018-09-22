using MVP_Weather.Presenter;
using MVP_Weather.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Weather
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var weatherView = new WeatherView();
            var weatherPresenter = new WeatherPresenter();

            weatherView.Presenter = weatherPresenter;
            weatherPresenter.View = weatherView;

            Application.Run(weatherView);
        }
    }
}
