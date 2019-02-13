using MeteostationStatisticsObserver.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MeteostationStatisticsObserver
{
    public partial class StatisticsForm : Form
    {
        public HttpService _httpService { get; set; } = new HttpService();
        public UserInfo[] usersInfo { get; set; }
        public bool isChartUpdateNeeded { get; set; } = false;
        public StatisticsForm()
        {
            InitializeComponent();

            // Set up chart props
            var s = chart1.Series.Add("temperature");
            s.XValueType = ChartValueType.DateTime;
            s.ChartType = SeriesChartType.Line;
            s.Color = Color.Red;

            var chartArea = new ChartArea("ca");
            chart1.ChartAreas.Add(chartArea);
            chartArea.AxisX.LabelStyle.Format = "MM/dd HH:mm:ss";

            // Set up dateTimePickes
            dateTimePickerStartTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartTime.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dateTimePickerEndTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndTime.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            labelInfo.Text = "";

            // Set up sample size UI
            numericUpDownSampleSize.Value = 0.1M;
        }

        private async void StatisticsForm_Load(object sender, EventArgs e)
        {
            try
            {
                labelInfo.Text = "Loading users list";
                usersInfo = await _httpService.GetUserInfo();
                comboBoxUsers.Items.AddRange(usersInfo);
                comboBoxUsers.ValueMember = "username";
            }
            catch
            {
                MessageBox.Show("An error occured while loading users");
            }
            finally
            {
                labelInfo.Text = "";
            }
            
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load user info for given username
            var userInfo = (UserInfo)comboBoxUsers.Items[comboBoxUsers.SelectedIndex];

            // Update UI for date pickers
            // Setting flag in order to get rid of unnecessary api calls
            isChartUpdateNeeded = false;
            dateTimePickerStartTime.MinDate = userInfo.MinDate;
            dateTimePickerStartTime.MaxDate = userInfo.MaxDate;
            dateTimePickerStartTime.Value = userInfo.MinDate;
            dateTimePickerEndTime.MinDate = userInfo.MinDate;
            dateTimePickerEndTime.MaxDate = userInfo.MaxDate;
            dateTimePickerEndTime.Value = userInfo.MaxDate;
            isChartUpdateNeeded = true;

            updateChartUI();    
        }

        private void dateTimePickerStartTime_ValueChanged(object sender, EventArgs e)
        {
            updateChartUI();
        }

        private void dateTimePickerEndTime_ValueChanged(object sender, EventArgs e)
        {
            updateChartUI();
        }

        /// <summary>
        /// Updates chart UI based on combobox, dateTimePicker and sampleSize values
        /// </summary>
        private async void updateChartUI()
        {
            if (!isChartUpdateNeeded) return;

            if (comboBoxUsers.SelectedIndex < 0) return;
            var userInfo = (UserInfo)comboBoxUsers.Items[comboBoxUsers.SelectedIndex];

            labelInfo.Text = "Loading chart..";

            try
            {
                var stats = await _httpService.GetStatistics(
                userInfo.Username,
                dateTimePickerStartTime.Value,
                dateTimePickerEndTime.Value,
                numericUpDownSampleSize.Value
            );

                var series = chart1.Series.FindByName("temperature");
                series.Points.Clear();
                foreach (var stat in stats)
                {
                    series.Points.AddXY(stat.MeasurementTime, Double.Parse(stat.Temperature));
                }
            }
            catch
            {
                MessageBox.Show("An error occured while loading chart data");
            }
            finally
            {
                labelInfo.Text = "";
            } 
        }

        private void numericUpDownSampleSize_ValueChanged(object sender, EventArgs e)
        {
            updateChartUI();
        }
    }
}
