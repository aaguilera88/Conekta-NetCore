using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conekta_NetStandard.Base
{
	public class ConektaException : Exception
	{
		public JArray details;
		public string message;
		public String _type;
		public String _object;

		public ConektaException()
		{
		}

		public ConektaException(string message) : base(message)
		{
			this.message = message;
		}
	}
}
