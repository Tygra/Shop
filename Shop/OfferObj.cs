﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class OfferObj
    {
        public int ID = new int();
        public string User = "";
        public int ItemID = new int();
        public int Stack = new int();
        public int Type = new int();
        public int Active = new int();

        public OfferObj(int id, string user, int itemid, int stack, int type, int active)
        {
            this.ID = id;
            this.User = user;
            this.ItemID = itemid;
            this.Stack = stack;
            this.Type = type;
            this.Active = active;
        }
    }
}
