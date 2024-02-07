﻿using DependencyInjectionCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionCoreApp.Controllers
{
    public class BankController : Controller
    {

        private readonly IBankRepository _bankRepository;

        public BankController(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }
        public JsonResult GetAllBanksInfo()
        {
            //BankRepository bankRepository = new BankRepository();

            //List<Bank> bankList = bankRepository.GetAllBanks();
            //return Json(bankList);
            return Json(_bankRepository.GetAllBanks());
        }

        public JsonResult GetBankInfoByRegNo(int BankRegNo)
        {
            //No need to create the object here , instead we will create the obj in the constructer
           // BankRepository bankRepository = new BankRepository();

           return Json(_bankRepository.GetBankInfoByRegNo(BankRegNo));

        }
    }
}
