namespace Contour.Domain.Base.Abstractions
{
    public interface IImage
    {
        string Url { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int ContourId { get; set; }
    }
}
