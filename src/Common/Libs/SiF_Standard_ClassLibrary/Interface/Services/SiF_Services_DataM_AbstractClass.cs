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

//////////using Microsoft.Extensions.Logging;
using SourceItFresh.Shared.Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceItFresh.Shared.Interface.Services
{
    public abstract class SiF_Services_DataM_AbstractClass<T> : ISiF_Services_DataM_Interface<T> where T : /*class,*/ ISiF_DataModels_BaseInterface
    {
        //////////private /*abstract*/ ILogger<T> _logger { get; }
        //private /*abstract*/ SiF_Data_DbContext _context { get; }

        //Ctor

        //public abstract Task<T> Initialize(string UserId);

        #region CRUD

        #region Create

        public abstract Task<Guid> AddAsync(string UserId, T ModelToAdd);

        //Task<Guid> ISiF_Services_DataM_Interface<T>.AddAsync(string UserId, T ModelToAdd)
        //{
        //    Guid returnValue = Guid.Empty;
        //    try
        //    {
        //        //modelToAdd.UserModified = UserId;
        //        //modelToAdd.DateModified = DateTime.UtcNow;
        //    }
        //    catch (Exception ex)
        //    {
        //        //////////_logger.LogError(ex.Message);
        //        throw;
        //    }

        //    return Task.FromResult(returnValue);
        //}

        #endregion Create

        #region Read

        /*internal*/

        public abstract Task<List<T>> GetAllAsync(string UserId, int FilterId);

        //internal virtual Task<List<T>> GetAllAsync(string UserId, int FilterId)
        //{
        //    List<T> returnValue = null;
        //    try
        //    {
        //        //return T.Where(/*not system and oderby name*/);
        //        //returnValue = _context.User_TraderEntities.Where(t => t.UserBaseId == UserId).ToList();

        //        //ToDo: override Task<List<T>> GetAll()
        //        throw new NotImplementedException();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex.Message);
        //        throw;
        //    }

        //    return Task.FromResult(returnValue);
        //}

        public abstract Task<T> GetSpecificByIdAsync(string UserId, int ModelId);

        public abstract Task<T> GetCurrentAsync(string UserId);

        #endregion Read

        #region Update

        public abstract Task<bool> UpdateAsync(string UserId, T ModelToUpdate);

        #endregion Update

        #region Delete

        public abstract Task<bool> DeleteByIdAsync(string UserId, int ModelId);

        #endregion Delete

        #endregion CRUD

        #region Other/CustomActions

        /*internal*/

        public abstract Task<bool> ExistsAsync(string UserId, int ModelId);

        //internal virtual Task<bool> ExistsAsync(int ModelId)
        //{
        //    bool returnValue = false;
        //    try
        //    {
        //        returnValue = GetAll(UserId).Result.Any(e => e.Id == ModelId);
        //    }
        //    catch (Exception ex)
        //    {
        //        //////////_logger.LogError(ex.Message);
        //        throw;
        //    }

        //    return returnValue;
        //}

        /*internal*/

        public abstract Task<bool> HavePermissionAsync(string UserId, int ModelId);

        //public abstract Task<T> CloneAsync(string UserId, int IdToClone);

        #endregion Other/CustomActions
    }
}