namespace Patterns.Prototype
{
    public interface ICloneable<out T>
    {
        T Clone();
    }
}