namespace AspMan.Infrastructure.Interfaces
{
    public interface IContextMaker
    {
        void ContextApply(AppContext dump);
    }
}