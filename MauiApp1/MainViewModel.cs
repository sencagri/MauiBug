using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Patient> Patients { get; set; }
        public ObservableCollection<BloodworkStatus> BloodworkStatuses { get; set; }

        public MainViewModel()
        {
            Patients = new ObservableCollection<Patient>();
            BloodworkStatuses = new ObservableCollection<BloodworkStatus>();

            BloodworkStatus status = new BloodworkStatus();
            status.Id = 1;
            status.Name = "Not started";
            BloodworkStatuses.Add(status);
            
            status = new BloodworkStatus();
            status.Id = 2;
            status.Name = "In Progress";
            BloodworkStatuses.Add(status);
            
            status = new BloodworkStatus();
            status.Id = 3;
            status.Name = "Completed";
            BloodworkStatuses.Add(status);

            var selectedstatus = BloodworkStatuses[1];

            Patient patient = new Patient();
            patient.Id = 1;
            patient.Name = "John Nameless";
            patient.MedicalHistory = "Loves to develop MAUI :/ ";
            patient.BloodworkStatus = BloodworkStatuses[2];
            Patients.Add(patient);
            
            patient = new Patient();
            patient.Id = 2;
            patient.Name = "Patrick Schlover";
            patient.MedicalHistory = "Hail Microsoft";
            patient.BloodworkStatus = BloodworkStatuses[0];
            Patients.Add(patient);
            
            patient = new Patient();
            patient.Id = 2;
            patient.Name = "Layla McKanzi";
            patient.MedicalHistory = "Seeking for a Mecnun";
            patient.BloodworkStatus = BloodworkStatuses[0];
            Patients.Add(patient);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
