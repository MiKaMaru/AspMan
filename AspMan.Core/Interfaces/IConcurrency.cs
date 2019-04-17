namespace AspMan.Core.Iterfaces
{
    public interface IConcurrency
    {
        bool IsUpdate();
        void TryUpdate();
    }
}