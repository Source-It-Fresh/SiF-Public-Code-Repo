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

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceItFresh.Components.Shared
{
    public partial class CollapsibleCard
    {
        [Parameter] public bool Collapsed { get; set; } = true;
        [Parameter] public string? CardHeaderIcon { get; set; } = string.Empty;
        [Parameter] public string? CardHeaderTitle { get; set; } = string.Empty;
        [Parameter] public string? BodyClass { get; set; } = string.Empty;
        [Parameter] public RenderFragment? CardBodyContent { get; set; }
        [Parameter] public bool ShowFooter { get; set; } = false;
        [Parameter] public RenderFragment? CardFooterContent { get; set; }
        [Parameter] public bool IsDialog { get; set; } = false;

        //private string CollapseIcon => Collapsed ? "oi oi-collapse-up" : "oi oi-collapse-down";
        private string DialogStyle => IsDialog ? "max-height: 500px; overflow-y: scroll" : "";

        //public void Toggle()
        //{
        //    Collapsed = !Collapsed;
        //}
    }
}