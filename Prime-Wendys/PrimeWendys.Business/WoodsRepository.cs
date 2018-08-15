using System;
using System.Collections.Generic;
using System.Text;
using PrimeWendys;
using PrimeWendys.Models;
using PrimeWendys.Models.DataModels;
using PrimeWendys.Business;
using System.Linq;

namespace PrimeWendys.Business
{
    public class WoodsRepository
    {
        private readonly PrimeWendysDB db;

        public WoodsRepository(PrimeWendysDB db)
        {
            this.db = db;
        }
        /* Adding a wood type */
        public virtual void addWood(WoodDto wood)
        {
            try
            {
                db.Woods.Add(Helper.GetWoods(wood));
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /* Getting all woods */
        public virtual ICollection<Wood> GetWoods()
        {
            return db.Woods.ToList();
        }
        /* Updating the wood type, price or anything else */
        public virtual Wood UpdatWood(Wood wood)
        {
            try
            {
                db.Woods.Update(wood);
                db.SaveChanges();
                return db.Woods.FirstOrDefault(c => c.Wood_Id == wood.Wood_Id);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /* Delete a wood */
        public virtual void DeleteWood(Wood wood)
        {
            try
            {
                db.Woods.Remove(wood);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
