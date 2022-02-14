using AngleSharp.Html.Dom;

namespace HTMLParcer.Core
{
    interface IParcer<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
