namespace Module5.Premium.Server.ViewModels
{
    public class ViewModelBase
    {
        public ViewModelBase()
        {
            Title = "CQRS Premium";
        }

        public string Title { get; set; } 
    }
}