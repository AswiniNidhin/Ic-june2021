using System;
using System.Collections.Generic;
using System.Text;

namespace Ic_june2021
{
    class CustomerResponse
    {
        public bool success { get; set; }
        public Customer data { get; set; }
        public string message { get; set; }
    }
}
