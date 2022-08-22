namespace Demo.Common
{
    public interface IService
    {
        string ValuePassedIn { get; set }
        bool DoSomeWork();
    }
}