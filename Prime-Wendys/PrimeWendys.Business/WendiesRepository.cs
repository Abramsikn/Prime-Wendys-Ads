using System;
using System.Collections.Generic;
using System.Text;
using PrimeWendys.Models;
using PrimeWendys.Models.DataModels;
using PrimeWendys.Business;
using System.Linq;

namespace PrimeWendys.Business
{
    public class WendiesRepository
    {
        private readonly PrimeWendysDB db;

        public WendiesRepository(PrimeWendysDB db)
        {
            this.db = db;
        }
        /* Add wendy with a certain wood */
        public virtual void AddWendy(WendyDto wendy)
        {
            try
            {
                var wen = Helper.GetWendys(wendy);
                var wood = db.Woods.FirstOrDefault(c => c.Wood_Type.Equals(wendy.Wood.Wood_Type, StringComparison.CurrentCultureIgnoreCase));
                wen.Wood_Id = wood.Wood_Id;

                db.Wendies.Add(wen);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /* Find the certain wendy */
        public virtual Wendy FindWendy(int Id)
        {
            var wendies = db.Wendies.FirstOrDefault(p => p.Wendy_Id == Id);
            return wendies;
        }
        /* Delete a certain wendy */
        public virtual void DeleteWendy(Wendy wendy)
        {
            db.Wendies.Remove(wendy);
            db.SaveChanges();
        }
        /* Updating the wendy */
        public virtual void UpdateWendy(Wendy wendy)
        {
            db.Wendies.Update(wendy);
            db.SaveChanges();
        }
        /* Get all wendies */
        public virtual ICollection<Wendy> GetWendies()
        {
            return db.Wendies.ToList();
        }
    }
}
