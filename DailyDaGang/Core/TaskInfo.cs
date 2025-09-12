namespace DailyDaGang.Core
{
    public static class TaskInfo
    {
        // 用于存储 IServiceProvider
        private static IServiceProvider _serviceProvider;

        // 初始化时设置 IServiceProvider
        public static void Initialize(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;

        // 获取服务的静态方法
        public static T GetService<T>() where T : class
        {
            if (_serviceProvider == null)
            {
                throw new InvalidOperationException("ServiceProvider is not initialized.");
            }

            var service = _serviceProvider.GetService<T>();
            if (service == null)
            {
                throw new InvalidOperationException($"Service of type {typeof(T)} is not registered.");
            }

            return service;
        }
    }
}
