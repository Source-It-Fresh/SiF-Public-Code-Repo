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
using MudBlazor;
using QRCoder;
using SiF_Common_RCL.Pages.Information;
using SiF_Common_RCL.Shared.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using static MudBlazor.Colors;
using static SourceItFresh.Shared.Common.SiF_Constants.Areas;

namespace SourceItFresh.Components.Shared
{
    public partial class SiF_QrCodeControl
    {
        [Inject] private IDialogService? _DialogService { get; set; }

        [Parameter] public required string UrlLnik { get; set; } = string.Empty;
        [Parameter] public required string DialogTitle { get; set; } = string.Empty;

        private MudBlazor.DialogOptions _DialogOptions = new() { FullScreen = false };
        private MudBlazor.DialogParameters _DialogParameters = new();

        //private string _QrByteArray1;
        //private byte[] _QrByteArray2;
        private byte[]? _QrByteArray3;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                //if UrlLnik is null throw exception
                UrlLnik = string.IsNullOrWhiteSpace(UrlLnik) ? "https:\\www.SourceItFrech.com" : UrlLnik;

                //parm Link
                // @*Image As QR Code *@
                //hover text = link
                //  @*Btn click => Printable PDF *@
            }
            catch (Exception ex)
            {
                //_SummaryMessage = $"FarmLayout";
                //_StatusMessage = string.Format(SiF_Constants.LoggerStrings.Failed, SiF_Constants.Actions.Page.Find, SiF_Constants.AreaModels.Manage_Farm.Farm, null);
                //_Snackbar.Add($"<ul><li>{_SummaryMessage}</li><li>{_StatusMessage}</li></ul>", Severity.Error);
                //_Logger.LogError(ex.Message);
            }
        }

        protected override async Task OnParametersSetAsync()
        {
            QRCodeGenerator? qrGenerator = new QRCodeGenerator();
            QRCodeData? qrCodeData = qrGenerator.CreateQrCode(UrlLnik, QRCodeGenerator.ECCLevel.Q);

            //AsciiQRCode qrCode1 = new AsciiQRCode(qrCodeData);
            //string qrCodeAsAsciiArt = qrCode1.GetGraphic(1);

            //BitmapByteQRCode qrCode2 = new BitmapByteQRCode(qrCodeData);
            //byte[] qrCodeAsBitmapByteArr = qrCode2.GetGraphic(20);

            PngByteQRCode? qrCode3 = new PngByteQRCode(qrCodeData);
            byte[]? qrCodeAsPngByteArr = qrCode3.GetGraphic(20);

            //_QrByteArray1 = qrCodeAsAsciiArt;
            //_QrByteArray2 = qrCodeAsBitmapByteArr;
            _QrByteArray3 = qrCodeAsPngByteArr;
        }

        private async Task OpenDialogAsync()
        {
            //MudTextField<string> tmpTest = new MudBlazor.MudTextField<string>();
            //tmpTest.Label = "Read Only Test";
            //tmpTest.ReadOnly = true;
            //tmpTest.Variant = Variant.Outlined;

            RenderFragment? renderFragment1 = (Builder) =>
            {
                Builder.AddMarkupContent(0, $"<img style=\"width:500px;height:500px; object-fit:fill;\" src=\"data:image/*;base64,{Convert.ToBase64String(_QrByteArray3)}\" title=\"{UrlLnik}\" />");
            };

            RenderFragment? renderFragment2 = (Builder) =>
            {
                Builder.AddMarkupContent(0, "<MudButton Variant=\"Variant.Filled\" EndIcon=\"@Icons.Material.Filled.Send\" Color=\"Color.Primary\">Print</MudButton>");
            };

            _DialogParameters = new()
            {
                { "Collapsed", false },
                { "CardHeaderTitle", UrlLnik },
                { "CardBodyContent", renderFragment1 },
                { "ShowFooter", true },
                { "CardFooterContent", renderFragment2 }
            };
            _DialogParameters.Add("IsDialog", true);
            //_DialogParameters.Add("OnChange", RefreshDataAsync);

            try
            {
                var tmpDialog = await _DialogService.ShowAsync<CollapsibleCard>(DialogTitle, _DialogParameters, _DialogOptions);
                await tmpDialog.Result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}