using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace iCherDialog.Dialogs
{
    [Serializable]
    public abstract class BaseDialog<T> : IDialog<T>
    {
        public virtual async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceived);
        }

        protected abstract Task MessageReceived(IDialogContext context, IAwaitable<IMessageActivity> result);

        protected async Task SendAttachment(IDialogContext context, Attachment attachment)
        {
            await SendAttachments(context, new List<Attachment> { attachment });
        }

        protected async Task SendAttachments(IDialogContext context, List<Attachment> attachments)
        {
            var attachmentMsgActivity = context.MakeMessage();
            string layoutType = AttachmentLayoutTypes.List;

            attachmentMsgActivity.Attachments = attachments;
            attachmentMsgActivity.AttachmentLayout = layoutType;

            await context.PostAsync(attachmentMsgActivity);
        }
    }
}