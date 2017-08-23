using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GridToRelativeLayout
{
    public partial class RelativeLayoutPage : ContentPage
    {
        public RelativeLayoutPage()
        {
            var emptyLabel = new Label
            {
                Text = "Empty Label",
                Margin = new Thickness(10, 0, 10, 0),
                FontSize = 18,
                TextColor = Color.Gray,
                HorizontalTextAlignment = TextAlignment.Center
            };

            var resetPointsButton = new Button
            {
                BackgroundColor = Color.FromHex("E19A3F"),
                Text = "Reset points?",
                TextColor = Color.White,
                FontAttributes = FontAttributes.Bold,
            };
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    resetPointsButton.FontSize = 20;
                    break;
                case Device.iOS:
                    resetPointsButton.FontSize = 25;
                    break;
            }

            var msg1Label = new Label
            {
                Text = "msg1",
                Margin = new Thickness(0, 26, 0, 0)
            };
            var msg2Label = new Label
            {
                Text = "msg2",
                Margin = new Thickness(0, 26, 0, 0)
            };
            var msg3Label = new Label
            {
                Text = "msg3",
                Margin = new Thickness(0, 26, 0, 0)
            };

            var faveLabel = new Label { Text = "Fave Label" };
            var wordTypeLabel = new Label { Text = "Word Type Label" };

            var textLabel = new Label
            {
                BackgroundColor = Color.Brown,
                Text = "Text Label",
                FontSize = 45,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };

            var detail1Label = new Label
            {
                Text = "Detail 1 Label",
                Margin = new Thickness(10, 0)
            };
            var detail2Label = new Label
            {
                Text = "Detail 2 Label",
                Margin = new Thickness(10, 0)
            };
            var detail3Label = new Label
            {
                Text = "Detail 3 Label",
                Margin = new Thickness(10, 0)
            };

            var zeroButton = new Button
            {
                Text = "0",
                Margin = new Thickness(0, 0, 0, 20)
            };
            var oneButton = new Button
            {
                Text = "1",
                Margin = new Thickness(0, 0, 0, 20)
            };
            var twoButton = new Button
            {
                Text = "2",
                Margin = new Thickness(0, 0, 0, 20)
            };
            var fiveButton = new Button
            {
                Text = "5",
                Margin = new Thickness(0, 0, 0, 20)
            };

            var tapScreenLabel = new Label
            {
                Text = "Tap Screen",
                Margin = new Thickness(0, 0, 0, 20),
                VerticalTextAlignment = TextAlignment.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Func<RelativeLayout, double> GetZeroButtonHeight = parent => zeroButton.Measure(parent.Width, parent.Height).Request.Height;
            Func<RelativeLayout, double> GetOneButtonHeight = parent => oneButton.Measure(parent.Width, parent.Height).Request.Height;
            Func<RelativeLayout, double> GetTwoButtonHeight = parent => twoButton.Measure(parent.Width, parent.Height).Request.Height;
            Func<RelativeLayout, double> GetFiveButtonHeight = parent => fiveButton.Measure(parent.Width, parent.Height).Request.Height;

            var relativeLayout = new RelativeLayout();
            relativeLayout.Children.Add(emptyLabel,
                                        Constraint.Constant(0),
                                        Constraint.Constant(0),
                                        Constraint.RelativeToParent(parent => parent.Width));
            relativeLayout.Children.Add(resetPointsButton,
                                        Constraint.Constant(0),
                                        Constraint.Constant(0),
                                        Constraint.RelativeToParent(parent => parent.Width));
            relativeLayout.Children.Add(msg1Label,
                                        Constraint.Constant(25),
                                        Constraint.RelativeToView(resetPointsButton, (parent, view) => view.Y + view.Height),
                                        Constraint.RelativeToParent(parent => parent.Width * 0.25));
            relativeLayout.Children.Add(msg2Label,
                                        Constraint.RelativeToView(msg1Label, (parent, view) => view.X + view.Width),
                                        Constraint.RelativeToView(resetPointsButton, (parent, view) => view.Y + view.Height),
                                        Constraint.RelativeToParent(parent => parent.Width * 0.25));
            relativeLayout.Children.Add(msg3Label,
                                        Constraint.RelativeToView(msg2Label, (parent, view) => view.X + view.Width),
                                        Constraint.RelativeToView(resetPointsButton, (parent, view) => view.Y + view.Height),
                                        Constraint.RelativeToParent(parent => parent.Width * 0.5));
            relativeLayout.Children.Add(faveLabel,
                                        Constraint.Constant(25),
                                        Constraint.RelativeToView(msg1Label, (parent, view) => view.Y + view.Height + 20),
                                        Constraint.RelativeToParent(parent => parent.Width * 0.25));
            relativeLayout.Children.Add(wordTypeLabel,
                                        Constraint.RelativeToView(faveLabel, (parent, view) => view.X + view.Width),
                                        Constraint.RelativeToView(msg1Label, (parent, view) => view.Y + view.Height + 20),
                                        Constraint.RelativeToParent(parent => parent.Width * 0.25));
            relativeLayout.Children.Add(textLabel,
                                        Constraint.Constant(20),
                                        Constraint.RelativeToView(faveLabel, (parent, view) => view.Y + view.Height + 20),
                                        Constraint.RelativeToParent(parent => parent.Width - 40),
                                        Constraint.RelativeToParent(parent => parent.Height * 0.25));
            relativeLayout.Children.Add(detail1Label,
                                       Constraint.Constant(20),
                                       Constraint.RelativeToView(textLabel, (parent, view) => view.Y + view.Height + 20));
            relativeLayout.Children.Add(detail2Label,
                                       Constraint.Constant(20),
                                       Constraint.RelativeToView(detail1Label, (parent, view) => view.Y + view.Height));
			relativeLayout.Children.Add(detail3Label,
									   Constraint.Constant(20),
									   Constraint.RelativeToView(detail2Label, (parent, view) => view.Y + view.Height));
            relativeLayout.Children.Add(zeroButton,
                                        Constraint.Constant(40),
                                        Constraint.RelativeToParent(parent => parent.Height - GetZeroButtonHeight(parent) - 40),
                                        Constraint.RelativeToParent(parent => (parent.Width - 80) / 4));
            relativeLayout.Children.Add(oneButton,
                                        Constraint.RelativeToView(zeroButton, (parent, view) => view.X + view.Width),
                                        Constraint.RelativeToParent(parent => parent.Height - GetZeroButtonHeight(parent) - 40),
                                        Constraint.RelativeToParent(parent => (parent.Width - 80) / 4));
            relativeLayout.Children.Add(twoButton,
                                        Constraint.RelativeToView(oneButton, (parent, view) => view.X + view.Width),
                                        Constraint.RelativeToParent(parent => parent.Height - GetZeroButtonHeight(parent) - 40),
                                        Constraint.RelativeToParent(parent => (parent.Width - 80) / 4));
            relativeLayout.Children.Add(fiveButton,
                                        Constraint.RelativeToView(twoButton, (parent, view) => view.X + view.Width),
                                        Constraint.RelativeToParent(parent => parent.Height - GetZeroButtonHeight(parent) - 40),
                                        Constraint.RelativeToParent(parent => (parent.Width - 80) / 4));
            relativeLayout.Children.Add(tapScreenLabel,
                                        Constraint.Constant(20),
                                        Constraint.RelativeToView(zeroButton, (parent, view) => view.Y),
                                        Constraint.RelativeToParent(parent => parent.Width - 40));

            Padding = GetPadding();
            Content = relativeLayout;
        }

        Thickness GetPadding()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    return new Thickness(0, 20, 0, 0);
                default:
                    return default(Thickness);
            }
        }
    }
}
