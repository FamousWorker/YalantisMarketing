using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Net;
using YalantisMarketing.Classes.CsvReadWrite;
using System.Windows;
using System.Collections.ObjectModel;

namespace YalantisMarketing.Classes.Parsing
{
   public static class ProxyServers
    {
        static ObservableCollection<ProxyServer> _servers = new ObservableCollection<ProxyServer>();
        static int _limit = 100;
        static ICsvReaderWriter _csvReaderWriter = new SimpleCsvReaderWriter();
        static string filepath = "proxy.txt";
        public static ProxyServer GetProxy()
        {
            return _servers.FirstOrDefault(x => x.Limits != _limit);
        }
        public static ObservableCollection<ProxyServer> Servers
        {
            get { return _servers; }
        }
        public static void AddProxy(int port, string IP, string user, string password, int limits = 100)
        {
            _servers.Add(new ProxyServer(port, IP, user, password) { Limits = limits});
        }
        public static void Clear()
        {
            _servers = new ObservableCollection<ProxyServer>();
        }
        public static void Delete( ProxyServer ps)
        {
            _servers.Remove(ps);
        }
        public static void ServersInit()
        {
            try
            {
                var txt = _csvReaderWriter.ReadFile(filepath);
                foreach (var item in txt)
                {
                    var strings = item.Split(';');
                    try
                    {
                        AddProxy(Convert.ToInt32(strings[1]), strings[0], strings[2], strings[3], Convert.ToInt32(strings[4]));
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }            
        }
        public static bool WriteServers()
        {
            List<string> list = new List<string>();
            foreach (var item in _servers)
            {
                list.Add(item.IPAdress +";"+ item.Port + ";" + item.User + ";" + item.Password + ";" + item.Limits);
            }
            return _csvReaderWriter.Write(filepath, new TextFromListGetter(list));
        }
    }
}
