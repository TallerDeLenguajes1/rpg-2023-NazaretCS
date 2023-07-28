using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ChuckNorrisJokes
{
    public class JokeResponse
    {
        public string IconUrl { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public string Value { get; set; }
    }
}
