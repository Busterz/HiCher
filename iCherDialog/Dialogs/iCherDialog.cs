using iCherDialog.Service;
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
    public class iCherDialog : BaseDialog<object>
    {
        protected override async Task MessageReceived(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var resultMessage = await result;
            var userInput = resultMessage.Text;

            if (userInput.ToLower().Contains("strategic income opportunities"))
            {
                context.Wait(SearchSecurities);
            }
            else
            {
                await context.PostAsync("Right now, I don't know anything about that, but can I help you with this products.");

                var hero = new HeroCard
                {
                    Title = "Options: ",
                    //Subtitle = "Please select a country that you would like to visit from the options below.",
                    Buttons = new List<CardAction>
                {
                    new CardAction{Type = ActionTypes.ImBack, Title = "1. What is investing?", Value = "1"},
                    new CardAction{Type = ActionTypes.ImBack, Title = "2. How to start investing?", Value = "2"},
                    new CardAction{Type = ActionTypes.ImBack, Title = "3. What is a broker?", Value = "3"},
                    new CardAction{Type = ActionTypes.ImBack, Title = "4. Let’s play a game?", Value = "4"},
                    new CardAction{Type = ActionTypes.ImBack, Title = "5. Search for securities", Value = "5"}
                }
                };

                var attached = hero.ToAttachment();
                await SendAttachment(context, attached);
                context.Wait(SelectedOption);
            }
        }

        private async Task SelectedOption(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var resultMessage = await result;

            if(resultMessage.Text == "1")
            {
                await FirstOption(context);
            }
            else if(resultMessage.Text == "4")
            {
                await PlayGame(context);
            }
            else if (resultMessage.Text == "5")
            {
                await context.PostAsync("What would you like to search for?");
                context.Wait(FifthOption);
            }
            else
            {
                await context.PostAsync("The option is still being developed, please try again later. Type 'hi' after this.");
                await MessageReceived(context, result);
            }
        }

        private async Task FirstOption(IDialogContext context)
        {
            await context.PostAsync("Investing is making your money work harder. A process of laying out money now to receive more money in the future. Would you like to know more about investing?");
            var hero = new HeroCard
            {
                Title = "Options: ",
                Buttons = new List<CardAction>
                {
                    new CardAction{Type = ActionTypes.ImBack, Title = "1. Yes!", Value = "1"},
                    new CardAction{Type = ActionTypes.ImBack, Title = "2. No :(", Value = "2"}
                }
            };

            var att = hero.ToAttachment();
            await SendAttachment(context, att);

            context.Wait(SelectedFirstOptOptions);
        }

        private async Task SelectedFirstOptOptions(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var resultMessage = await result;

            if (resultMessage.Text == "1")
            {
                await YesOption(context);
            }
            else if(resultMessage.Text == "2")
            {
                await context.PostAsync("Type 'hi' after this.");
                await MessageReceived(context, result);
            }
        }

        private async Task YesOption(IDialogContext context)
        {
            await context.PostAsync("There are various types of investment such as stocks, bonds, mutual funds, , ETFs and real estate. Which one would like to know more?");

            context.Wait(UserInputInvestmentType);
        }

        private async Task UserInputInvestmentType(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var resultMessage = await result;

            if(resultMessage.Text.ToLower() == "stocks" || resultMessage.Text.ToLower() == "stock")
            {
                await context.PostAsync($"{resultMessage.Text} also known as equity. A stock is a type of security that signifies ownership in a corporation and represents a claim on part of the corporation's assets and earnings.");
                await context.PostAsync("Type 'hi' after this.");
                context.Wait(MessageReceived);
            }
            else
            {
                await context.PostAsync("Please type according to the available options.");
                context.Wait(UserInputInvestmentType);
            }
        }

        private async Task PlayGame(IDialogContext context)
        {
            await context.PostAsync("I see that you want to test yourself so let’s play a short quiz to see how knowledgeable you are. Stand a chance to win movie tickets. No cheating ;)");
            await GameQuestionOne(context);
        }

        private async Task GameQuestionOne(IDialogContext context)
        {
            await context.PostAsync("1st Question: What does ETF means?");

            var hero = new HeroCard
            {
                Title = "Options: ",
                Buttons = new List<CardAction>
                {
                    new CardAction{Type = ActionTypes.ImBack, Title = "1. Exchange Traffic Funds", Value = "1"},
                    new CardAction{Type = ActionTypes.ImBack, Title = "2. Expedited Traded Funds", Value = "2"},
                    new CardAction{Type = ActionTypes.ImBack, Title = "3. Exchange Traded Funds", Value = "3"}
                }
            };

            var att = hero.ToAttachment();
            await SendAttachment(context, att);

            context.Wait(CheckGameFirstQn);
        }

        private async Task CheckGameFirstQn(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var resultMessage = await result;
            var answer = resultMessage.Text;

            if(answer == "3")
            {
                await context.PostAsync("Ding Ding Ding! You got it right! Next Question.");
                await GameQuestionTwo(context);
            }
            else
            {
                await context.PostAsync("Beeeeepppppp! Please try again!");
                await GameQuestionOne(context);
            }
        }

        private async Task GameQuestionTwo(IDialogContext context)
        {
            await context.PostAsync("2nd Question: Which investment instrument has the highest risk and rewards?");

            var hero = new HeroCard
            {
                Title = "Options: ",
                Buttons = new List<CardAction>
                {
                    new CardAction{Type = ActionTypes.ImBack, Title = "1. Cash Plus Fund", Value = "1"},
                    new CardAction{Type = ActionTypes.ImBack, Title = "2. Foreign Emerging Markets", Value = "2"},
                    new CardAction{Type = ActionTypes.ImBack, Title = "3. Blue Chips Equity", Value = "3"}
                }
            };

            var att = hero.ToAttachment();
            await SendAttachment(context, att);

            context.Wait(CheckGameSecondQn);
        }

        private async Task CheckGameSecondQn(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var resultMessage = await result;
            var answer = resultMessage.Text;

            if (answer == "2")
            {
                await context.PostAsync("Ding Ding Ding! You got it right! Next Question.");
                await GameQuestionThree(context);
            }
            else
            {
                await context.PostAsync("Beeeeepppppp! Please try again!");
                await GameQuestionTwo(context);
            }
        }

        private async Task GameQuestionThree(IDialogContext context)
        {
            await context.PostAsync("3rd Question: Is it true that retail investor can invest directly on BlackRock funds?");

            var hero = new HeroCard
            {
                Title = "Options: ",
                Buttons = new List<CardAction>
                {
                    new CardAction{Type = ActionTypes.ImBack, Title = "1. True", Value = "1"},
                    new CardAction{Type = ActionTypes.ImBack, Title = "2. False", Value = "2"}
                }
            };

            var att = hero.ToAttachment();
            await SendAttachment(context, att);

            context.Wait(CheckGameThirdQn);
        }

        private async Task CheckGameThirdQn(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var resultMessage = await result;
            var answer = resultMessage.Text;

            if (answer == "2")
            {
                await context.PostAsync("Ding Ding Ding! You got it right! Next Question.");
                await context.PostAsync("Congratulations! Your total score is 3/3. We will contact you if you win the prize :D");
                await context.PostAsync("Type 'hi' after this.");
                context.Wait(MessageReceived);
            }
            else
            {
                await context.PostAsync("Beeeeepppppp! Please try again!");
                await GameQuestionThree(context);
            }
        }

        private async Task FifthOption(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var resultMessage = await result;
            var userInput = resultMessage.Text;

            //string urlString = $"https://www.blackrock.com/tools/hackathon/search-securities?query={userInput}";
            HttpClientFact hcf = new HttpClientFact();
            ICherService ics = new ICherService(hcf);
            var highestMatchName = await ics.GetSecuritiesDescription(userInput);

            await context.PostAsync($"The possible stock name match is {highestMatchName}");
        }

        private async Task SearchSecurities(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            await context.PostAsync("Which share class would it be for?");
            await FifthOption(context, result);
        }
    }
}