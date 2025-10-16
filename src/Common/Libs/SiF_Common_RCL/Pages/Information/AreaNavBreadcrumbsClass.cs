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
using MudBlazor;
using SiF_Common_RCL.Shared.Services;

namespace SiF_Common_RCL.Pages.Information
{
    internal class AreaNavBreadcrumbsClass
    {
        //ViewData["ActivePage"] = ManageNavPages.Information;

        private LocalizationCultureService _LocalizationCultureService { get; set; }

        public List<BreadcrumbItem>? NavBreadcrumbs = null;

        public AreaNavBreadcrumbsClass(LocalizationCultureService LocalizationCultureService)
        {
            _LocalizationCultureService = LocalizationCultureService;

            if (NavBreadcrumbs == null)
            {
                NavBreadcrumbs = new List<BreadcrumbItem>
                {
                    new BreadcrumbItem(_LocalizationCultureService.GetValue("Bar_Header:Information:Producer"), href: "/SiF_Common_RCL/Information/GrowersComponent", icon: "fas fa-hand-holding-water"),
                    new BreadcrumbItem(_LocalizationCultureService.GetValue("Bar_Header:Information:Supplier"), href: "/SiF_Common_RCL/Information/SuppliersComponent", icon: "fas fa-parachute-box"),
                    new BreadcrumbItem(_LocalizationCultureService.GetValue("Bar_Header:Information:Consumer"), href: "/SiF_Common_RCL/Information/BuyersComponent", icon: "fas fa-utensils"),
                };
            }
        }
    }
}