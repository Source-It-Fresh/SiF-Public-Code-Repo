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

using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using SourceItFresh.Shared.Common;
using System.Globalization;

namespace SiF_Common_RCL.Shared.Services
{
    public class LocalizationCultureService
    {
        //private readonly ILogger<LocalizationCultureService> _logger;
        private readonly IStringLocalizer<LocalizationCultureService> _stringLocalizer;

        public LocalizationCultureService
        (
            //ILogger<LocalizationCultureService> logger,
            IStringLocalizer<LocalizationCultureService> stringLocalizer
        )
        {
            //_logger = logger;
            _stringLocalizer = stringLocalizer;
        }

        public string GetValue(string key)
        {
            return _stringLocalizer[key];
        }
    }
}