﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using Pihrtsoft.Records.Utilities;

namespace Pihrtsoft.Records
{
    internal static class XContainerExtensions
    {
        public static XElement FirstElement(this XContainer container)
        {
            return container.Elements().FirstOrDefault();
        }
    }
}