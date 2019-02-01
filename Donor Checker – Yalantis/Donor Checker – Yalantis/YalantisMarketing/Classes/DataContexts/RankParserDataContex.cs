using System;
using System.Collections.Concurrent;
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
        public event Action ParsingEnd;

        AParseResultBuilder _parser;
        MetricsResultBuilder _metricParser;
        ICsvReaderWriter _csvReaderWriter;
        string _savefilepath;
        int _timeout, _streamsCount;
        ConcurrentQueue<string> _result, _domains;
        bool _pauseToken, _cancelToken, _saver;
        private void SetParams(RankParserParams parametr)
        {
            _metricParser.CF_TF = parametr.CF_TF;
            _metricParser.DA_PA = parametr.DA_PA;
            _timeout = parametr.TimeOut;
            _streamsCount = parametr.ThreadCount;
        }
        private string ParseDomain(string domainname)
        {
            string res = _parser.Build(domainname) + _metricParser.Build(domainname);
            //string res = domainname + " parsed";
            //_parser.Exp();
            //MessageBox.Show("add");
            IsParsed?.Invoke();
            return res;
        }
        public RankParserDataContex()
        {
            _metricParser = new MetricsResultBuilder();
            _csvReaderWriter = new SimpleCsvReaderWriter();
            _savefilepath = "sm_result_" + DateTime.Today.ToShortDateString() + ".csv";
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
        public void SetProxy()
        {
            _parser.SetProxy();
        }
        public void RemoveProxy()
        {
            _parser.RemoveProxy();
        }
        public void Pause()
        {
            _pauseToken = false;
        }
        public void Continue()
        {
            _pauseToken = true;
        }
        public void Cancel(bool save)
        {
            _saver = save;
            _cancelToken = false;
        }

        Task startTask()
        {
            return Task.Run(() =>
            {
                try
                {
                    while (true)
                    {
                        if (_cancelToken)
                        {
                            if(_pauseToken)
                            {
                                string dom;
                                if (_domains.TryDequeue(out dom))
                                    _result.Enqueue(ParseDomain(dom));
                                else break;
                                Thread.Sleep(_timeout * 1000);
                            }
                            
                        }
                        else break;
                    }
                        
                }
                catch (Exception)
                {
                }
            });
        }
        public async void Parse(RankParserParams parametr)
        {
            _result = new ConcurrentQueue<string>();
            _domains = new ConcurrentQueue<string>(_csvReaderWriter.ReadFile(parametr.FilePath));
            List<Task>  tasks = new List<Task>();
            _pauseToken = true;
            _cancelToken = true;
            _saver = true;
            SetParams(parametr);
            StartParsing?.Invoke(_domains.Count, _streamsCount, _timeout);            
            _result.Enqueue("Url" + _parser.BuildHeader() + _metricParser.BuildHeader());            
            for (int i = 0; i < _streamsCount ; i++)
            {
                tasks.Add(startTask());
            }
            await Task.WhenAll(tasks);
            if(_saver)
            if(_csvReaderWriter.Write(_savefilepath, new TextFromListGetter(_result.ToList())))
                    MessageBox.Show("Done");
            ParsingEnd?.Invoke();
            foreach (var item in tasks)
            {
                item.Dispose();
            }
        }

    }
}
