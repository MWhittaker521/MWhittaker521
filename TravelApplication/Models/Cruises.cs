﻿using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApplication.Models
{
    public class Cruises: IComparable, INotifyPropertyChanged
    {  

        public object idreader { get; set; }
        public string dcode { get; set; }
        public string dest { get; set; }
        public string locate { get; set; }
        public string descript { get; set; }
        public int Crank { get; set; }
        public int SPA { get; set; }
        public int AMUSE { get; set; }
        public int HISTORIC { get; set; }
        public int CAMP { get; set; }
        public int ENTERTAIN { get; set; }
        public int categor { get; set; }
        public int priceLow { get; set; }
        public int priceHigh { get; set; }
        public int destid { get; set; }
        public string refLink { get; set; }
        public string imageSource { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public int CompareTo(object obj)
        {
            Cruises cruises = obj as Cruises;
            if (cruises == null)
            {
                throw new ArgumentException("Object is not a Cruise Package");
            }
            return this.Crank.CompareTo(cruises.Crank);
        }
    }
}
