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
            _lefFiles = "0/0";
            _leftTime = "0 min.";
            _maxValue = 1;
            _currentValue = 0;
        }
        int _streams, _timeout;
        void GetLeftTime()
        {
            int timeleft = ((_maxValue - _currentValue) * _timeout) / _streams;
            int minleft = timeleft / 60;
            leftTime = minleft.ToString() + " min.";
        }
        void GetLeftFiles()
        {
            leftFiles = _currentValue.ToString() + @"/" + _maxValue.ToString();
        }
        public void Init(int maxcount, int streamscount, int timeout)
        {
            MaxValue = maxcount;
            _streams = streamscount;
            _timeout = timeout;
            CurrentValue = 0;
        }
        int i = 0;
        public void Update()
        {
            leftFiles = (++i).ToString();
        }
        #region Propertys
        private int _currentValue;
        public int CurrentValue
        {
            get { return _currentValue; }
            set
            {
                _currentValue = value;
                GetLeftTime();
                GetLeftFiles();
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
        private string _lefFiles;
        public string leftFiles
        {
            get { return _lefFiles; }
            set
            {
                _lefFiles = value;
                OnPropertyChanged("leftFiles");
            }
        }
        private string _leftTime;
        public string leftTime
        {
            get { return _leftTime; }
            set
            {
                _leftTime = value;
                OnPropertyChanged("leftTime");
            }
        }
        #endregion

    }
}
