using CommunityToolkit.Mvvm.Input;
using MapsApplication.Models;

namespace MapsApplication.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}