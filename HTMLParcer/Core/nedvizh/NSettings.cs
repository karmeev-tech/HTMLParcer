namespace HTMLParcer.Core.nedvizh
{
    class NSettings : IPSettings
    {
        public string url { get; set; } = "your URL";
        public string prefix { get; set; } = "page{CurrentId}";
        public int startPoint { get; set; }
        public int endPoint { get; set; }
    }
}
