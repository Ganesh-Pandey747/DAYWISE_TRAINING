using System.Collections.Generic;
using System;
using myAutoMapperExample.myPOCO;
namespace myAutoMapperExample.Services
{
    public interface IUserprofileRepository
    {
         UserProfile GetUserProfile(int id);
    }
}