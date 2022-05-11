using System;

namespace Library
{
    public class Singleton<T> where T : class, new()
    {
        private static T instance = null;

        private Singleton() { }

        public static T Instance
        {
            get 
            {
                if (instance == null)
                    instance = new T();
                return instance;
            }
        }
    }
}