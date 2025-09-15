namespace CommunityToolkit.Mvvm.Navigation.Wpf
{
    /// <summary>
    /// 接口用于指示视图模型是否应在导航历史记录中保留
    /// </summary>    
    public interface IJournalAware
    {
        /// <summary>
        /// 导航是否被记录
        /// </summary>
        /// <returns></returns>
        bool PersistInHistory();
    }
}
