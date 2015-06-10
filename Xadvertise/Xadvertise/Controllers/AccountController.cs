using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xadvertise.Models;

namespace Xadvertise.Controllers
{
    public class AccountController : Controller
    {
        private AccountsContext _db = new AccountsContext();
        //private IList<Account> dbnew = AccountsViewModel();
        // GET: Account
        public ActionResult Index()
        {
            return View(_db.Accounts.ToList());
        }

        public ActionResult Edit(int id)
        {
            Account thing = _db.Accounts.First(x => x.AccountId == id);
            return View(thing);
        }

        [HttpPost]
        public ActionResult Edit(Account account)
        {
            if (ModelState.IsValid)
            {
                var original = _db.Accounts.Find(account.AccountId);
                _db.Entry(original).CurrentValues.SetValues(account);
                _db.SaveChanges();
            }
            return RedirectToAction("ObjDetails", account);
        }
        public ActionResult Details(int id)
        {
            Account thing = _db.Accounts.First(x => x.AccountId == id);
            return View(thing);
        }

        public ActionResult ObjDetails(Account account)
        {
            return View(_db.Accounts.First(x => x.AccountId == account.AccountId));
        }

        public ActionResult Delete(int id)
        {
            Account thing = _db.Accounts.First(x => x.AccountId == id);
            _db.Accounts.Remove(thing);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Account account)
        {
            _db.Accounts.Add(account);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}