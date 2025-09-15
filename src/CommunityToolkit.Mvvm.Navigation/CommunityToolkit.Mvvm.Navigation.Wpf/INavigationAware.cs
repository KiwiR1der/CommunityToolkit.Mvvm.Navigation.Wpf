namespace CommunityToolkit.Mvvm.Navigation.Wpf
{
    public interface INavigationAware
    {
        /// <summary>
        /// 是否这次导航继续
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        bool IsNavigationTarget(NavigationParameters parameters);

        /// <summary>
        /// 导航后参数接收方法
        /// 到达页面后回调
        /// </summary>
        /// <param name="parameters">参数</param>
        void OnNavigatedTo(NavigationParameters parameters);

        /// <summary>
        /// 导航前参数传递方法
        /// 离开当前页面前回调
        /// </summary>
        /// <param name="parameters">参数</param>
        void OnNavigatedFrom(NavigationParameters parameters);
    }
}
