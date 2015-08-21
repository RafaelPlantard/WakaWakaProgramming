using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Mvvm.Interfaces;
using Microsoft.Practices.Unity;

namespace WakaWakaProgramming
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App : MvvmAppBase
    {
        #region Fields

        private IUnityContainer _unityContainer = new UnityContainer();

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        #region Protected

        /// <summary>
        /// Register the instance of objects on the Unity container.
        /// </summary>
        /// <param name="args">A implementation of <see cref="IActivatedEventArgs"/>.</param>
        /// <returns>Returns a <see cref="Task"/>, so that you can perform asynchronous operations inside it.</returns>
        protected override Task OnInitializeAsync(IActivatedEventArgs args)
        {
            // Register MvvmAppBase services with the container so that view models can take dependencies on them.
            _unityContainer.RegisterInstance<ISessionStateService>(SessionStateService);
            _unityContainer.RegisterInstance<INavigationService>(NavigationService);

            // Register any app specific types with the container.

            // Set a factory for the ViewModelLocator to use the container to construct view models so their
            // dependencies get injected by the container.
            ViewModelLocationProvider.SetDefaultViewModelFactory((viewModelType) => _unityContainer.Resolve(viewModelType));

            return Task.FromResult<object>(null);
        }

        /// <summary>
        /// This method is raised when the application is launched.
        /// </summary>
        /// <param name="args">The launch activated event arguments.</param>
        /// <returns>Returns a <see cref="Task"/>, so that you can perform asynchronous operations inside it.</returns>
        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate("Main", null);

            return Task.FromResult<object>(null);
        }

        #endregion

        #endregion


    }
}