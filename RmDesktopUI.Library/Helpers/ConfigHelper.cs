﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmDesktopUI.Library.Helpers
{
    public class ConfigHelper : IConfigHelper
    {
        //TODO:  Move this from config to the API
        public decimal GetTaxRate()
        {
            string rateText = ConfigurationManager.AppSettings["taxRate"];

            bool isValidTaxRate = Decimal.TryParse(rateText, out decimal output);

            if (isValidTaxRate == false)
            {
                throw new ConfigurationErrorsException("Tax rate not set up correctly");
            }

            return output;
        }
    }
}
