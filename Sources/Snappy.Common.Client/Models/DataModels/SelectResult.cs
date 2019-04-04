namespace Snappy.Common.Client.Models.DataModels
{
    public class SelectResult
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }

        public SelectResult(string value, string text, string image)
        {
            Value = value;
            Text = text;
            Image = image;
        }
    }
}