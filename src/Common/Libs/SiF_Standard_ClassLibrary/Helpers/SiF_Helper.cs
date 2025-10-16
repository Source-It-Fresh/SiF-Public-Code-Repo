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

using System;
using System.Drawing;

namespace SourceItFresh.Shared.Helpers
{
    public static class SiF_Helper
    {
        public static string GetRandomColor(int? seed = null)
        {
            Random? rnd = null;
            if (seed != null && seed.HasValue)
            {
                rnd = new Random(seed.Value);
            }
            else
            {
                rnd = new Random();
            }

            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            return ColorTranslator.ToHtml(randomColor);
        }

        public static string Color180(string HTMLColorToChange)
        {
            Color tmpColor = ColorTranslator.FromHtml(HTMLColorToChange);

            float hue = tmpColor.GetHue();
            float saturation = tmpColor.GetSaturation();
            float lightness = tmpColor.GetBrightness();

            hue = (hue + 0.5f) % 1.0f;

            Color uTurnColor = ColorFromHSV(hue, saturation, lightness);

            return ColorTranslator.ToHtml(uTurnColor);
        }

        //private static void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        //{
        //    int max = Math.Max(color.R, Math.Max(color.G, color.B));
        //    int min = Math.Min(color.R, Math.Min(color.G, color.B));

        //    hue = color.GetHue();
        //    saturation = (max == 0) ? 0 : 1d - (1d * min / max);
        //    value = max / 255d;
        //}

        private static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }
    }
}