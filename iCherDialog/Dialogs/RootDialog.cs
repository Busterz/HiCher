using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.Threading;

namespace iCherDialog.Dialogs
{
    [Serializable]
    public class RootDialog : BaseDialog<object>
    {
        protected override async Task MessageReceived(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var message = await result;

            await context.PostAsync("Hi there!");

            var mainDialog = new iCherDialog();

            await context.Forward(mainDialog, AfterGreetings, message, CancellationToken.None);
        }

        private async Task AfterGreetings(IDialogContext context, IAwaitable<object> result)
        {
            context.Wait(MessageReceived);
        }
    }
}