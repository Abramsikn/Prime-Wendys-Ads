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
    public class WindowsRepository
    {
        private readonly PrimeWendysDB db;

        public WindowsRepository(PrimeWendysDB db)
        {
            this.db = db;
        }
        /* Adding a window type */
        public virtual void addWindow(WindowDto window)
        {
            try
            {
                db.Windows.Add(Helper.GetWindows(window));
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /* Getting all windows */
        public virtual ICollection<Window> GetWindows()
        {
            return db.Windows.ToList();
        }
        /* Updating the wood type, price or anything else */
        public virtual Window UpdatWindow(Window window)
        {
            try
            {
                db.Windows.Update(window);
                db.SaveChanges();
                return db.Windows.FirstOrDefault(c => c.Win_Id == window.Win_Id);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /* Delete a window */
        public virtual void DeleteWindow(Window window)
        {
            try
            {
                db.Windows.Remove(window);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
