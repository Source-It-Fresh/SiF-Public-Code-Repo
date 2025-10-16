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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceItFresh.Shared.Interface.Models
{
    public record SiF_DataModels_BaseRecord : ISiF_DataModels_BaseInterface
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required()]
        //[DataType(DataType.Currency)]
        [Display(Name = "Id")]
        [Column("id", Order = 0)]
        [Range(0, short.MaxValue)]
        public required int Id { get; init; }

        [Required()]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        [Column("name", Order = 11)]
        [StringLength(50, MinimumLength = 1)]
        public required string Name { get; set; }

        //[Required()]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Details")]
        [Column("details", Order = 12)]
        [StringLength(500, MinimumLength = 0)]
        public string? Details { get; set; }

        [Required()]
        [DataType(DataType.Text)]
        [Display(Name = "Owner")]
        [Column("ownerId", Order = 995)]
        [StringLength(50, MinimumLength = 0)]
        public required string/*?*/ OwnerId { get; set; }

        [Required()]
        //[DataType(DataType.Custom)]
        [Display(Name = "Row Version")]
        [Column("rowVersion", Order = 999)]
        public required byte[] RowVersion { get; set; }
    }
}