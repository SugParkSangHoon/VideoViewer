﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 영상뷰어.Interfaces
{
    public interface ICrudRepositoryBase<T, TIdentifier>
    {
        Task<T> AddAsync(T model);//입력
        Task<List<T>> GetAllAsync();//출력
        Task<T> GetByIdAsync(TIdentifier id);//상세
        Task<bool> UpdateAsync(T model);//수정
        Task<bool> DeleteAsync(TIdentifier id); //delete
    }
    public interface ISatelliteCrudRepository<T> : ICrudRepositoryBase<T, int>
    {
        //Empty 
        //여기서는 아이디조회가 int 형이라는것을 암시
    }
    public interface IUserCrudRepository<T> : ICrudRepositoryBase<T, string>
    {
        //Empty 
        //여기서는 아이디조회가 int 형이라는것을 암시
    }
}
