﻿using System;
using System.Web;
using System.Reflection;
using System.Collections.Generic;
using Router.Attributes;


namespace Router.RoutingList
{
    internal class Routing
    {
        public IHttpHandler handler { get; set; }
        public Dictionary<string, RoutingAction> actions { get; set; }
        public DateTime modifyDate { get; set; }
    }

    internal class RoutingAction
    {
        public MethodInfo action { get; set; }
        public string actionName { get; set; }
        public DateTime modifyDate { get; set; }
        public RoutingMethodAttribute attribute { get; set; }
        public ParameterInfo[] param { get; set; }
        public bool IsDefAction { get; set; }
        public ParameterInfo returnType { get; set; }
    }
}
