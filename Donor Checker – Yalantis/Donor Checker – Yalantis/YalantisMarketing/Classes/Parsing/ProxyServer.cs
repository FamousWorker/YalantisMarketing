using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YalantisMarketing.Classes.Parsing
{
    public class ProxyServer : PropertyChancher
    {
        public ProxyServer(int port, string IP, string user, string password)
        {
             isActive = false;
            Limits = 0;
            _port = port;
            _adress = IP;
            _user = user;
            _password = password;
            _proxy = new WebProxy(_adress, _port);
            _proxy.Credentials = new NetworkCredential(_user, _password);
        }
        bool isActive { get; set; }
        int _limits;
        public int Limits
        {
            get { return _limits; }
            set
            {
                _limits = value;
                OnPropertyChanged("Limits");
            }
        }
        int _port;
        public int Port
        {
            get { return _port; }
        }
        string _adress;
        public string IPAdress
        {
            get { return _adress; }
        }
        string _user;
        public string User
        {
            get { return _user; }
        }
        string _password;
        public string Password
        {
            get { return _password; }
        }

        WebProxy _proxy;
        public WebProxy Proxy
        {
            get { return _proxy; }
            set { _proxy = value; }
        }
    }
}
