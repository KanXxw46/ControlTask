using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ControlWork_StarWors_
{
    public class Program
    {
        static void Main(string[] args)
        {
            string url = "https://swapi.dev/api/people/1/";
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            var potantialCancelledTask = Task.Run(() =>
            {
                Console.WriteLine("Запуск");
                Thread.Sleep(4000);
            throw new FileNotFoundException("Упс");
            }, cancellationTokenSource.Token);

            Thread.Sleep(3000);
            cancellationTokenSource.Cancel();

            CancellationToken token = cancellationTokenSource.Token;

            using (var webClient = new WebClient())
            {
                var pars = new NameValueCollection();

                pars.Add("format", "json");

                var response = webClient.UploadValues(url, pars);
            }


        }
    }
}
