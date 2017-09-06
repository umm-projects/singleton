namespace UnityModule {

    public abstract class Singleton<T> where T : Singleton<T>, new() {

        /// <summary>
        /// Singleton インスタンスの実体
        /// </summary>
        private static T instance;

        /// <summary>
        /// Singleton インスタンス
        /// </summary>
        public static T Instance {
            get {
                if (instance == default(T)) {
                    instance = new T();
                    instance.OnInitialize();
                }
                return instance;
            }
        }

        /// <summary>
        /// 初期化時のコールバック
        /// </summary>
        protected virtual void OnInitialize() {
            // Do nothing.
        }

    }

}