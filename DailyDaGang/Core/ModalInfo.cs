using AntDesign;
using DailyDaGang.Components.Forms;

namespace DailyDaGang.Core;

public static class ModalInfo
{
    public static ModalRef<TResult> CreateModal<TForm,TModel,TResult>(TModel model,string title,ModalService modalService) where TForm : FeedbackComponent<TModel, TResult>
    {
        var modalConfig = new ModalOptions();
        modalConfig.Title = title;
        modalConfig.DestroyOnClose = true;
        modalConfig.Centered = true;
        var modalRef = modalService.CreateModal<TForm,TModel,TResult>(modalConfig,model);
        return modalRef;
    }
}