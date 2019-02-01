using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes.WhoisPackage
{
    public class WhoisParameters : PropertyChancher
    {
        private bool _creationDate;
        public bool CreationDate
        {
            get { return _creationDate; }
            set
            {
                _creationDate = value;
                OnPropertyChanged("CreationDate");
            }
        }
        private bool _expiryDate;
        public bool ExpiryDate
        {
            get { return _expiryDate; }
            set
            {
                _expiryDate = value;
                OnPropertyChanged("ExpiryDate");
            }
        }

        private bool _domainAge;
        public bool DomainAge
        {
            get { return _domainAge; }
            set
            {
                _domainAge = value;
                OnPropertyChanged("DomainAge");
            }
        }

        private bool _serverName1;
        public bool ServerName1
        {
            get { return _serverName1; }
            set
            {
                _serverName1 = value;
                OnPropertyChanged("ServerName1");
            }
        }
        private bool _serverName2;
        public bool ServerName2
        {
            get { return _serverName2; }
            set
            {
                _serverName2 = value;
                OnPropertyChanged("ServerName2");
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
