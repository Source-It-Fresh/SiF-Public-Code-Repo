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
    public class SiF_Services_DataM_BaseClass<T> : SiF_Services_DataM_AbstractClass<T> where T : SiF_DataModels_BaseRecord
    {
        //////////private ILogger<T> _logger { get; }

        //Ctor

        //public override Task<T> Initialize(string UserId)
        //{
        //    T returnValue = null;
        //    try
        //    {
        //        //base.Initialize(UserId);

        //        //ToDo: override Task<Guid> Add(T modelToAdd)
        //        throw new NotImplementedException();
        //    }
        //    catch (Exception ex)
        //    {
        //        //////////_logger.LogError(ex.Message);
        //        throw;
        //    }

        //    return Task.FromResult(returnValue);
        //}

        #region CRUD

        #region Create

        public override Task<Guid> AddAsync(string UserId, T ModelToAdd)
        {
            Guid returnValue = Guid.Empty;
            try
            {
                //base.AddAsync(modelToAdd);

                //ToDo: override Task<Guid> Add(T modelToAdd)
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                //////////_logger.LogError(ex.Message);
                throw;
            }

            return Task.FromResult(returnValue);
        }

        #endregion Create

        #region Read

        /*internal*/

        public override Task<List<T>> GetAllAsync(string UserId, int FilterId)
        {
            List<T>? returnValue = null;
            try
            {
                //base.GetAllAsync(UserId);

                //ToDo: override Task<List<T>> GetAll()
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                //////////_logger.LogError(ex.Message);
                throw;
            }

            return Task.FromResult(returnValue);
        }

        public override Task<T> GetSpecificByIdAsync(string UserId, int ModelId)
        {
            T? returnValue = default(T);
            try
            {
                //base.GetSpecificByIdAsync(ModelId);

                //ToDo:  override Task<T> GetById(int ModelId)
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                //////////_logger.LogError(ex.Message);
                throw;
            }

            return Task.FromResult(returnValue);
        }

        public override Task<T> GetCurrentAsync(string UserId)
        {
            T? returnValue = default(T);
            try
            {
                //base.GetCurrent(UserId);

                //ToDo:  override Task<T> GetById(int ModelId)
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                //////////_logger.LogError(ex.Message);
                throw;
            }

            return Task.FromResult(returnValue);
        }

        #endregion Read

        #region Update

        public override Task<bool> UpdateAsync(string UserId, T ModelToUpdate)
        {
            bool returnValue = false;
            try
            {
                //base.Update(modelToUpdate);

                //ToDo: override Task<bool> Update(T modelToUpdate)
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                //////////_logger.LogError(ex.Message);
                throw;
            }

            return Task.FromResult(returnValue);
        }

        #endregion Update

        #region Delete

        public override Task<bool> DeleteByIdAsync(string UserId, int ModelId)
        {
            bool returnValue = false;
            try
            {
                //base.DeleteById(id);

                //ToDo: override Task<bool> DeleteById(int id)
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                //////////_logger.LogError(ex.Message);
                throw;
            }

            return Task.FromResult(returnValue);
        }

        #endregion Delete

        #endregion CRUD

        #region Other/CustomActions

        /*internal*/

        public override Task<bool> ExistsAsync(string UserId, int ModelId)
        {
            bool returnValue = false;
            try
            {
                //base.Exists(/*UserId,*/ ModelId);

                //ToDo: override bool Exists(int ModelId)
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                //////////_logger.LogError(ex.Message);
                throw;
            }

            return Task.FromResult(returnValue);
        }

        /*internal*/

        public override Task<bool> HavePermissionAsync(string UserId, int ModelId)
        {
            bool returnValue = false;
            try
            {
                //base.HavePermission(UserId, ModelId);

                //ToDo: override bool Exists(int ModelId)
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                //////////_logger.LogError(ex.Message);
                throw;
            }

            return Task.FromResult(returnValue);
        }

        //public override Task<T> CloneAsync(string UserId, int IdToClone)
        //{
        //    T returnValue = null;
        //    try
        //    {
        //        //base.CloneAsync(UserId, ModelToAdd);

        //        //ToDo: override Task<Guid> CloneAsync(T modelToAdd)
        //        throw new NotImplementedException();
        //    }
        //    catch (Exception ex)
        //    {
        //        //////////_logger.LogError(ex.Message);
        //        throw;
        //    }

        //    return Task.FromResult(returnValue);
        //}

        #endregion Other/CustomActions
    }
}