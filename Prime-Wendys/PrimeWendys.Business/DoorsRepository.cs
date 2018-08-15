using System.Collections.Generic;
using System.Text;
using PrimeWendys;
using PrimeWendys.Models;
using PrimeWendys.Models.DataModels;
using PrimeWendys.Business;
using System.Linq;
using System;

namespace PrimeWendys.Business
{
    public class DoorsRepository
    {
        private readonly PrimeWendysDB db;

        public DoorsRepository(PrimeWendysDB db)
        {
            this.db = db;
        }
        /* Adding a door type */
        public virtual void addDoor(DoorDto door)
        {
            try
            {
                db.Doors.Add(Helper.GetDoors(door));
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /* Getting all doors */
        public virtual ICollection<Door> GetDoors()
        {
            return db.Doors.ToList();
        }
        /* Updating the door type, price or anything else */
        public virtual Door UpdateDoor(Door door)
        {
            try
            {
                db.Doors.Update(door);
                db.SaveChanges();
                return db.Doors.FirstOrDefault(c => c.Door_Id == door.Door_Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /* Delete a door */
        public virtual void DeleteDoor(Door door)
        {
            try
            {
                db.Doors.Remove(door);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
