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

using SourceItFresh.Shared.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceItFresh.Shared.Interface.Services
{
    public interface ISiF_Services_Model_Interface<T> where T : /*class,*/ /* new(),*/ ISiF_Models_CoreInterface
    {
        //private /*readonly*/ ILogger<T> _logger { get; }
        //private /*readonly*/ SiF_Data_DbContext _context { get; }

        //Ctor

        //public Task<T> Initialize(string UserId);

        #region CRUD

        #region Create

        public Task<Guid> AddAsync(string UserId, T ModelToAdd);

        #endregion Create

        #region Read

        public /*internal*/ Task<IEnumerable<T>> GetAllAsync(string UserId, int FilterId);

        public Task<T> GetSpecificByIdAsync(string UserId, Guid ModelId);

        public Task<T> GetCurrentAsync(string UserId);

        #endregion Read

        #region Update

        public Task<bool> UpdateAsync(string UserId, T ModelToUpdate);

        #endregion Update

        #region Delete

        public Task<bool> DeleteByIdAsync(string UserId, Guid ModelId);

        #endregion Delete

        #endregion CRUD

        #region Other/CustomActions

        public /*internal*/ Task<bool> ExistsAsync(string UserId, Guid ModelId);

        public /*internal*/ Task<bool> HavePermissionAsync(string UserId, Guid ModelId);

        //public Task<T> CloneAsync(string UserId, Guid IdToClone);

        #endregion Other/CustomActions
    }
}