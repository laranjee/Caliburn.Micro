namespace Caliburn.Micro {
    using System;

    public interface IPhoneContainer {
        event Action<object> Activated;
        void RegisterWithPhoneService(Type service, string phoneStateKey, Type implementation);
        void RegisterWithIsolatedStorage(Type service, string fileName, Type implementation);
    }
}