using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Patient : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MedicalHistory { get; set; }
        public BloodworkStatus BloodworkStatus { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
