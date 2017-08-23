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

            var msg1Label = new Label { Text = "msg1" };
            var msg2Label = new Label { Text = "msg2" };
            var msg3Label = new Label { Text = "msg3" };

            var faveLabel = new Label { Text = "faveLabel" };
            var wordTypeLabel = new Label { Text = "wordType" };

            var textLabel = new Label { Text = "Text Label" };

            var detail1Label = new Label { Text = "detail1" };
            var detail2Label = new Label { Text = "detail2" };
            var detail3Label = new Label { Text = "detail3" };

            var zeroButton = new Button { Text = "0" };
            var oneButton = new Button { Text = "1" };
            var twoButton = new Button { Text = "2" };
            var fiveButton = new Button { Text = "5" };

            var relativeLayout = new RelativeLayout();
            relativeLayout.Children.Add(emptyLabel,
                                       Constraint.Constant(0),
                                       Constraint.Constant(0),
                                       Constraint.RelativeToParent(parent => parent.Width),
                                       Constraint.Constant(60));

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
