/*
### ### ### ### ### ### ###
SourceItFresh - Copyright (C) 2020
This SiF file is licensed under v3 of the GNU Affero General Public License.
### ### ###
GNU AGPLv3 lets people do almost anything they want with the project, except distributing closed-source versions.

Permissions of this strongest copyleft license are conditioned on:
Making available the complete source code of works and modifications,
 which include larger works using a licensed work, under the same license.
Copyright and license notices must be preserved.
Contributors provide an express grant of patent rights.
When a modified version is used to provide a service over a network,
 the complete source code of the modified version must be made available.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY,
 without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
### ### ###
See LICENSE.txt for more details or visit <https://www.gnu.org/licenses/>
### ### ### ### ### ### ###
*/

using MudBlazor;

namespace SourceItFresh.Shared.Common
{
    public class CustomSifTheme : MudTheme
    {
        //string[] _baseFontFamily = new[] { "Helvetica", "Arial", "sans-serif" };
        //string[] _otherFontFamilies = new[] { "Montserrat", "Poppins", "Roboto" };

        public CustomSifTheme()
        {
            //PaletteLight = new PaletteLight()
            //{
            //    HoverOpacity = 0.06,           //0.06
            //    RippleOpacity = 0.01,          //0.01
            //    RippleOpacitySecondary = 0.02, //0.02

            //    Black = new MudColor(39, 44, 52, 1),                    //#272c34ff
            //    White = new MudColor(255, 255, 255, 1),                 //#ffffffff
            //    Primary = new MudColor(89, 74, 226, 1),                 //#594ae2ff
            //    PrimaryContrastText = new MudColor(255, 255, 255, 1),   //#ffffffff
            //    Secondary = new MudColor(255, 64, 129, 1),              //#ff4081ff
            //    SecondaryContrastText = new MudColor(255, 255, 255, 1), //#ffffffff
            //    Tertiary = new MudColor(30, 200, 165, 1),               //#1ec8a5ff
            //    TertiaryContrastText = new MudColor(255, 255, 255, 1),  //#ffffffff
            //    Info = new MudColor(33, 150, 243, 1),                   //#2196f3ff
            //    InfoContrastText = new MudColor(255, 255, 255, 1),      //#ffffffff
            //    Success = new MudColor(0, 200, 83, 1),                  //#00c853ff
            //    SuccessContrastText = new MudColor(255, 255, 255, 1),   //#ffffffff
            //    Warning = new MudColor(255, 152, 0, 1),                 //#ff9800ff
            //    WarningContrastText = new MudColor(255, 255, 255, 1),   //#ffffffff
            //    Error = new MudColor(244, 67, 54, 1),                   //#f44336ff
            //    ErrorContrastText = new MudColor(255, 255, 255, 1),     //#ffffffff
            //    Dark = new MudColor(66, 66, 66, 1),                     //#424242ff
            //    DarkContrastText = new MudColor(255, 255, 255, 1),      //#ffffffff

            //    TextPrimary = new MudColor(66, 66, 66, 1),              //#424242ff
            //    TextSecondary = new MudColor(0, 0, 0, 0.5372549019607843),   //#00000089
            //    TextDisabled = new MudColor(0, 0, 0, 0.3764705882352941),    //#00000060
            //    ActionDefault = new MudColor(0, 0, 0, 0.5372549019607843),   //#00000089
            //    ActionDisabled = new MudColor(0, 0, 0, 0.25882352941176473), //#00000042
            //    ActionDisabledBackground = new MudColor(0, 0, 0, 0.11764705882352941), //#0000001e
            //    Background = new MudColor(255, 255, 255, 1),            //#ffffffff
            //    BackgroundGray = new MudColor(245, 245, 245, 1),        //#f5f5f5ff
            //    Surface = new MudColor(255, 255, 255, 1),               //#ffffffff
            //    DrawerBackground = new MudColor(255, 255, 255, 1),      //#ffffffff
            //    DrawerText = new MudColor(66, 66, 66, 1),               //#424242ff
            //    DrawerIcon = new MudColor(97, 97, 97, 1),               //#616161ff
            //    AppbarBackground = new MudColor(89, 74, 226, 1),        //#594ae2ff
            //    AppbarText = new MudColor(255, 255, 255, 1),            //#ffffffff

            //    LinesDefault = new MudColor(0, 0, 0, 0.11764705882352941), //#0000001e
            //    LinesInputs = new MudColor(189, 189, 189, 1),              //#bdbdbdff
            //    TableLines = new MudColor(224, 224, 224, 1),               //#e0e0e0ff
            //    TableStriped = new MudColor(0, 0, 0, 0.0196078431372549),  //#00000005
            //    TableHover = new MudColor(0, 0, 0, 0.0392156862745098),    //#0000000a
            //    Divider = new MudColor(224, 224, 224, 1),                  //#e0e0e0ff
            //    DividerLight = new MudColor(0, 0, 0, 0.8),                 //#000000cc
            //    Skeleton = new MudColor(0, 0, 0, 0.10980392156862745),

            //    PrimaryDarken = "",                      //rgb(62,44,221)
            //    PrimaryLighten = "",                     //rgb(118,106,231)
            //    SecondaryDarken = "",                    //rgb(255,31,105)
            //    SecondaryLighten = "",                   //rgb(255,102,153)
            //    TertiaryDarken = "",                     //rgb(25,169,140)
            //    TertiaryLighten = "",                    //rgb(42,223,187)
            //    InfoDarken = "",                         //rgb(12,128,223)
            //    InfoLighten = "",                        //rgb(71,167,245)
            //    SuccessLighten = "",                     //rgb(0,163,68)
            //    SuccessDarken = "",                      //rgb(0,235,98)
            //    WarningDarken = "",                      //rgb(214,129,0)
            //    WarningLighten = "",                     //rgb(255,167,36)
            //    ErrorDarken = "",                        //rgb(242,28,13)
            //    ErrorLighten = "",                       //rgb(246,96,85)
            //    DarkDarken = "",                         //rgb(46,46,46)
            //    DarkLighten = "",                        //rgb(87,87,87)

            //    GrayDefault = "",                        //#9E9E9E
            //    GrayLight = "",                          //#BDBDBD
            //    GrayLighter = "",                        //#E0E0E0
            //    GrayDark = "",                           //#757575
            //    GrayDarker = "",                         //#616161
            //    OverlayDark = "",                        //rgba(33,33,33,0.4980392156862745)
            //    OverlayLight = "",                       //rgba(255,255,255,0.4980392156862745)
            //};

            //PaletteDark = new PaletteDark()
            //{
            //    //Same properties as above Palette
            //};

            //Shadows = new Shadow() { };

            //LayoutProperties = new LayoutProperties()
            //{
            //    DefaultBorderRadius = "4px",
            //    DrawerMiniWidthLeft = "56px",
            //    DrawerMiniWidthRight = "56px",
            //    DrawerWidthLeft = "240px",
            //    DrawerWidthRight = "240px",
            //    AppbarHeight = "64px",
            //};

            Typography = new Typography()
            {
                //Default = new DefaultTypography()
                //{
                //    FontFamily = _baseFontFamily,
                //    FontWeight = "400",
                //    FontSize = ".875rem",
                //    LineHeight = "1.43",
                //    LetterSpacing = ".01071em",
                //    TextTransform = "None"
                //},
                H1 = new H1Typography()
                {
                    //FontFamily = _baseFontFamily,
                    //FontWeight = "300",
                    FontSize = "2.5rem",
                    //LineHeight = "1.167",
                    //LetterSpacing = "-.01562em",
                    //TextTransform = "none"
                },
                H2 = new H2Typography()
                {
                    //FontFamily = _baseFontFamily,
                    //FontWeight = "300",
                    FontSize = "2.25rem",
                    //LineHeight = "1.2",
                    //LetterSpacing = "-.00833em",
                    //TextTransform = "none"
                },
                H3 = new H3Typography()
                {
                    //FontFamily = _baseFontFamily,
                    //FontWeight = "400",
                    FontSize = "2rem",
                    //LineHeight = "1.167",
                    //LetterSpacing = "0",
                    //TextTransform = "none"
                },
                H4 = new H4Typography()
                {
                    //FontFamily = _baseFontFamily,
                    //FontWeight = "400",
                    FontSize = "1.75rem",
                    //LineHeight = "1.235",
                    //LetterSpacing = ".00735em",
                    //TextTransform = "none"
                },
                H5 = new H5Typography()
                {
                    //FontFamily = _baseFontFamily,
                    //FontWeight = "400",
                    FontSize = "1.5rem",
                    //LineHeight = "1.334",
                    //LetterSpacing = "0",
                    //TextTransform = "none"
                },
                H6 = new H6Typography()
                {
                    //FontFamily = _baseFontFamily,
                    //FontWeight = "500",
                    FontSize = "1.25rem",
                    //LineHeight = "1.6",
                    //LetterSpacing = ".0075em",
                    //TextTransform = "none"
                },
                //Subtitle1 = new Subtitle1Typography()
                //{
                //    FontFamily = _baseFontFamily,
                //    FontWeight = "400",
                //    FontSize = "1rem",
                //    LineHeight = "1.75",
                //    LetterSpacing = ".00938em",
                //    TextTransform = "none"
                //},
                //Subtitle2 = new Subtitle2Typography()
                //{
                //    FontFamily = _otherFontFamilies,
                //    FontWeight = "500",
                //    FontSize = ".875rem",
                //    LineHeight = "1.57",
                //    LetterSpacing = ".00714em",
                //    TextTransform = "none"
                //},
                //Body1 = new Body1Typography()
                //{
                //    FontFamily = _baseFontFamily,
                //    FontWeight = "400",
                //    FontSize = "1rem",
                //    LineHeight = "1.5",
                //    LetterSpacing = ".00938em",
                //    TextTransform = "none"
                //},
                //Body2 = new Body2Typography()
                //{
                //    FontFamily = _otherFontFamilies,
                //    FontWeight = "400",
                //    FontSize = ".875rem",
                //    LineHeight = "1.43",
                //    LetterSpacing = ".01071em",
                //    TextTransform = "none"
                //},
                //Button = new ButtonTypography()
                //{
                //    FontFamily = _otherFontFamilies,
                //    FontWeight = "500",
                //    FontSize = ".875rem",
                //    LineHeight = "1.75",
                //    LetterSpacing = ".02857em",
                //    TextTransform = "uppercase"
                //},
                //Caption = new CaptionTypography()
                //{
                //    FontFamily = _otherFontFamilies,
                //    FontWeight = "400",
                //    FontSize = ".75rem",
                //    LineHeight = "1.66",
                //    LetterSpacing = ".03333em",
                //    TextTransform = "none"
                //},
                //Overline = new OverlineTypography()
                //{
                //    FontFamily = _otherFontFamilies,
                //    FontWeight = "400",
                //    FontSize = ".75rem",
                //    LineHeight = "2.66",
                //    LetterSpacing = ".08333em",
                //    TextTransform = "none"
                //}
            };

            //ZIndex = new ZIndex()
            //{
            //    Drawer = 1100,
            //    Popover = 1200,
            //    AppBar = 1300,
            //    Dialog = 1400,
            //    Snackbar = 1500,
            //    Tooltip = 1600,
            //};
        }
    }
}