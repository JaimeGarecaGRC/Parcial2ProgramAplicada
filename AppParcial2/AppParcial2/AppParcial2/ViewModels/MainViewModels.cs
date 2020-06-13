
namespace AppParcial2.ViewModels
{
    public class MainViewModels
    {
        private MainViewModels instance;
        #region ViewModels
        public PhotosViewModel Id { get; set; }

        #endregion

        #region Constructor
        public MainViewModels()
        {
            instance = this;
            this.Id = new PhotosViewModel();
        }
        #endregion

    }
}
