namespace Snappy.Common.Client.Models.ViewModels
{
    public abstract class BaseModel
    {
        /// <summary>
        /// Page title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Entity name
        /// </summary>
        public string Name { get; set; }

        public virtual void SetInputModelValues()
        {
        }
    }
}