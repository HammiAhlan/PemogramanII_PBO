﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220062
{
    public class Product_714220062
    {
        private string myType;
        private string myTitle;

        public Product_714220062()
        {

        }

        public Product_714220062 (string type, string title)
            {   
                this.myType  = type;
                this.myTitle =  title;
            }
            public string MyType
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }
        public string MyTitle
    {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = value;
            }
        }    
    }
    } 


