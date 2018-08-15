using System;
using System.Collections.Generic;
using System.Text;
using PrimeWendys.Models;
using PrimeWendys.Models.DataModels;

namespace PrimeWendys.Business
{
    internal static partial class Helper
    {
        /* -- For getting the users --*/
        internal static User GetUsers(UserDto user)
        {
            return new User
            {
                Email = user.Email,
                Password = user.Password,
                First_Name = user.First_Name,
                Last_Name = user.Last_Name,
                ContactNumber =  user.ContactNumber,
                DoB = user.DoB,
                Home_Address = user.Home_Address,
                City = user.City,
                State = user.State,
                Zip_Code = user.Zip_Code
            };
        }
        /* -- For getting the addressess
        internal static Address GetUserAddress(AddressDto address)
        {
            return new Address
            {
                Home_Address = address.Home_Address,
                City = address.City,
                State = address.State,
                Zip_Code = address.Zip_Code
            };
        }*/
        /* -- For getting the wendies --*/
        internal static Wendy GetWendys(WendyDto wendy)
        {
            return new Wendy
            {
                Size = wendy.Size,
                NumOfRooms = wendy.NumOfRooms,
                Price = wendy.Price,
                Picture = wendy.Picture
            };
        }
        /* -- For getting the windows --*/
        internal static Window GetWindows(WindowDto window)
        {
            return new Window
            {
                Win_Type = window.Win_Type,
                Win_Price = window.Win_Price,
                Win_Picture = window.Win_Picture
            };
        }
        /* -- For getting the doors --*/
        internal static Door GetDoors(DoorDto door)
        {
            return new Door
            {
                Door_Type = door.Door_Type,
                Door_Price = door.Door_Price,
                Door_Picture = door.Door_Picture
            };
        }
        /* -- For getting the woods --*/
        internal static Wood GetWoods(WoodDto wood)
        {
            return new Wood
            {
                Wood_Type = wood.Wood_Type,
                Wood_Desc = wood.Wood_Desc,
                Wood_Price = wood.Wood_Price,
                Wood_Picture = wood.Wood_Picture
            };
        }
    }
}
