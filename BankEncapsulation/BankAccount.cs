﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private  double _balance = 0;

        public void deposit(double amount) 
        {

            _balance += amount;
        
        }
        public double GetBalance()
        {
            return _balance;
        }
            
        
        
        

    
    
    
    
    
    
    
    
    
    }





}
