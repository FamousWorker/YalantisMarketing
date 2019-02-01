using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes.RankParserPackage
{
   public  class RankParserParams : PropertyChancher
    {
        public RankParserParams()
        {
            _cftf = _dapa = false;
            _threadCount = 1;
            _timeOut = 5;
            _filepath = "";
        }
        private bool _cftf;
        public bool CF_TF
        {
            get { return _cftf; }
            set
            {
                _cftf = value;
                OnPropertyChanged("CF_TF");
            }
        }
        private bool _dapa;
        public bool DA_PA
        {
            get { return _dapa; }
            set
            {
                _dapa = value;
                OnPropertyChanged("DA_PA");
            }
        }
        private int _threadCount;
        public int ThreadCount
        {
            get { return _threadCount; }
            set
            {
                _threadCount = value;
                OnPropertyChanged("ThreadCount");
            }
        }
        private int _timeOut;
        public int TimeOut
        {
            get { return _timeOut; }
            set
            {
                _timeOut = value;
                OnPropertyChanged("TimeOut");
            }
        }
        private string _filepath;
        public string FilePath
        {
            get { return _filepath; }
            set
            {
                _filepath = value;
                OnPropertyChanged("FilePath");
            }
        }
    }
}
