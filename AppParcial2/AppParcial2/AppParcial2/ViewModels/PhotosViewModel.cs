
namespace AppParcial2.ViewModels
{

    using AppParcial2.Services;
    public class PhotosViewModel:BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion

        #region Attributes
        private string id;
        #endregion

        #region properties
        public string Id
        {
                get { return this.id; }
                set { SetValue(ref this.id, value);  }
        }
        #endregion

        #region Constructor
        public PhotosViewModel()
        {
            this.apiService = new ApiService();
            this.LoadPhoto();
        }
        #endregion
     
        #region Methods
        private async System.Threading.Tasks.Task LoadPhoto()
        {
 
            var photos = await this.apiService.Get<photos>(
	        “https://jsonplaceholder.typicode.com/photos/”,
	        “”,
	        “”
            );
            this.Name = photos[number].Name;

        }
        #endregion

    }
};