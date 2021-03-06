﻿using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace CandleStick2DChart {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
    }
    public class ChartViewModel {
        public ObservableCollection<DataPoint> Data { get; private set; }
        public ChartViewModel() {
            Data = new ObservableCollection<DataPoint> {
                new DataPoint(new DateTime(2019,1,1), 25, 28, 24, 27),
                new DataPoint(new DateTime(2019,1,2), 27, 35, 26, 32),
                new DataPoint(new DateTime(2019,1,3), 32, 35, 27, 29),
                new DataPoint(new DateTime(2019,1,4), 29, 37, 29, 36),
                new DataPoint(new DateTime(2019,1,5), 36, 37, 32, 33),
                new DataPoint(new DateTime(2019,1,6), 36, 37, 33, 35),

                new DataPoint(new DateTime(2019,1,8), 31, 37, 30, 33),
                new DataPoint(new DateTime(2019,1,9), 32, 38, 29, 37),
                new DataPoint(new DateTime(2019,1,10), 34, 35, 32, 33),
            };
        }
    }
    public class DataPoint {
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public DataPoint(DateTime arg, double open, double high, double low, double close) {
            this.Date = arg;
            this.Open = open;
            this.High = high;
            this.Low = low;
            this.Close = close;
        }
    }
}
