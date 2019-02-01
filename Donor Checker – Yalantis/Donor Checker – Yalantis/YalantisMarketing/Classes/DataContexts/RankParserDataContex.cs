using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using YalantisMarketing.Classes.CsvReadWrite;
using YalantisMarketing.Classes.Parsing;
using YalantisMarketing.Classes.RankParserPackage;

namespace YalantisMarketing.Classes.DataContexts
{
    public class RankParserDataContex
    {
        public event UpdateProgressPanel IsParsed;
        public event StartProgressPanel StartParsing;
        public event Action PasingEnd;

        AParseResultBuilder _parser;
        MetricsResultBuilder _metricParser;
        ICsvReaderWriter _csvReaderWriter;
        string _savefilepath;
        int _timeout;
        int _currentposition, _max;
        int _streamsCount;
        private void WriteResult(List<string> list)
        {
            if( _csvReaderWriter.Write(_savefilepath, new TextFromListGetter(list))) MessageBox.Show("Done!");
        }
        private string GetLeftMinutes()
        {
            int timeleft = ((_max - _currentposition) * _timeout) / _streamsCount;
            int minleft = timeleft / 60;
            return minleft.ToString() + " min.";
        }
        private void SetParams(RankParserParams parametr)
        {
            _metricParser.CF_TF = parametr.CF_TF;
            _metricParser.DA_PA = parametr.DA_PA;
            _timeout = parametr.TimeOut;
            _streamsCount = parametr.ThreadCount;
            _currentposition = 0;
        }
        private string ParseDomain(string domainname)
        {
            //string res = _parser.Build(domainname) + _metricParser.Build(domainname);
            string res = domainname + " parsed";
           ++_currentposition;
            //MessageBox.Show("add");
            IsParsed?.Invoke(GetLeftMinutes(),_max - _currentposition);
            return res;
        }
        public RankParserDataContex()
        {
            _metricParser = new MetricsResultBuilder();
            _csvReaderWriter = new SimpleCsvReaderWriter();
            _savefilepath = "sm_result_" + DateTime.Today.ToShortDateString() + ".csv";
            _currentposition = 0;
        }
        public void SetAlexa()
        {
            _parser = new AlexaResultBuilder();
            _savefilepath = "alexa_result_" + DateTime.Today.ToShortDateString() + ".csv";
        }
        public void SetSimilar()
        {
            _parser = new SimilarWebResultBuilder();
            _savefilepath = "sm_result_" + DateTime.Today.ToShortDateString() + ".csv";
        }
        public void SetMetrics()
        {
            _parser =new EmptyResultBuilder();
            _savefilepath = "metrics_result_" + DateTime.Today.ToShortDateString() + ".csv";
        }
       async Task Process(List<string> result, List<string> domains)
        {
             await Task.Run(() => {
                while (true)
                {
                    if (token) 
                     if (_currentposition != _max)
                     {
                         try
                         {
                             lock (this) result.Add(ParseDomain(domains[_currentposition]));
                             Thread.Sleep(_timeout * 1000);
                         }
                         catch (Exception)
                         {
                             break;
                         }                         
                     }
                }
            });            
        }
        List<Task> tasks;
        List<string> result, domains;
        bool token, saver;
        public void Pause()
        {
            token = false;
        }
        public void Continue()
        {
            token = true;
        }
        public void Cancel(bool save)
        {
            saver = save;
            _currentposition = _max;
        }
        public async void Parse(RankParserParams parametr)
        {
            result = new List<string>();
            domains = _csvReaderWriter.ReadFile(parametr.FilePath);
            tasks = new List<Task>();
            token = true;
            saver = true;

            SetParams(parametr);
            _max = domains.Count;
            StartParsing?.Invoke(_max, GetLeftMinutes());            
            result.Add("Url" + _parser.BuildHeader() + _metricParser.BuildHeader());
            
            for (int i = 0; i < _streamsCount ; i++)
            {
                tasks.Add(Process(result,domains));
            }
            await Task.WhenAll(tasks);
            if(saver)
            if(_csvReaderWriter.Write(_savefilepath, new TextFromListGetter(result))) MessageBox.Show("Done");
            PasingEnd?.Invoke();
        }

    }
}
