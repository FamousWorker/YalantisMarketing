using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes.DataContexts
{
   public class ProgressPanelDataContex : PropertyChancher
    {
        public ProgressPanelDataContex()
        {
            _files = "0/0";
            _time = "0 min.";
            _maxValue = 1;
            _currentValue = 0;
        }
        private int _currentValue;
        public int CurrentValue
        {
            get { return _currentValue; }
            set
            {
                _currentValue = value;
                OnPropertyChanged("CurrentValue");
            }
        }
        private int _maxValue;
        public int MaxValue
        {
            get { return _maxValue; }
            set
            {
                _maxValue = value;
                OnPropertyChanged("MaxValue");
            }
        }
        private string _files;
        public string Files
        {
            get { return _files; }
            set
            {
                _files = value;
                OnPropertyChanged("Files");
            }
        }
        private string _time;
        public string Time
        {
            get { return _time; }
            set
            {
                _time = value;
                OnPropertyChanged("Time");
            }
        }
    }
}
