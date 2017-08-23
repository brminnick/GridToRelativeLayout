using Xamarin.Forms;

namespace GridToRelativeLayout
{
    public partial class GridPage : ContentPage
    {
        public GridPage()
        {
            InitializeComponent();

            SetBackgroundColors(true);
        }

        void SetBackgroundColors(bool areBackgroundColorsEnabled)
        {
            switch(areBackgroundColorsEnabled)
            {
                case false:
                    return;
            }

            emptyGrid.BackgroundColor = Color.Aqua;
            phraseGrid.BackgroundColor = Color.Green;
            prGrid.BackgroundColor = Color.Gray;
            siGrid.BackgroundColor = Color.Yellow;
            wordGrid.BackgroundColor = Color.Blue;
            textLabelGrid.BackgroundColor = Color.Brown;
            detailGrid.BackgroundColor = Color.Lime;
            buttonGrid.BackgroundColor = Color.Red;
            tapGrid.BackgroundColor = Color.Teal;
        }
    }
}
